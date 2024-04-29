﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace NDispWin
{
    internal partial class frm_DispCore_DispProg_DoHeight : Form
    {
        public DispProg.TLine CmdLine = new DispProg.TLine();
        public int ProgNo = 0;
        public int LineNo = 0;
        public TPos2 SubOrigin = new TPos2(0, 0);

        public frm_DispCore_DispProg_DoHeight()
        {
            InitializeComponent();
            GControl.LogForm(this);

            TopLevel = false;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        const int MAX_POINTS = 20;
        int i_PointNo = 0;//index starts from 0

        private void UpdateDisplay()
        {
            lbl_HeightID.Text = CmdLine.ID.ToString();
            lbl_AlignType.Text = CmdLine.IPara[2].ToString() + " - " + Enum.GetName(typeof(EAlignType), CmdLine.IPara[2]);

            if (CmdLine.IPara[0] != 3)
                btn_HeightType.BackColor = Color.Lime;
            else
                btn_HeightType.BackColor = this.BackColor;

            if (CmdLine.IPara[0] == 3)
                btn_PlaneType.BackColor = Color.Lime;
            else
                btn_PlaneType.BackColor = this.BackColor;

            gbox_HeightPositions.Visible = CmdLine.IPara[0] != 3 && CmdLine.Cmd == DispProg.ECmd.DO_HEIGHT;
            CmdLine.IPara[1] = Math.Max(1, CmdLine.IPara[1]);
            lbl_PointCount.Text = CmdLine.IPara[1].ToString();
            lbl_PointNo.Text = (i_PointNo + 1).ToString();
            lbl_PointXY.Text = CmdLine.X[i_PointNo].ToString("F3") + ", " + CmdLine.Y[i_PointNo].ToString("F3");

            btn_Prev.Enabled = (i_PointNo != 0);
            btn_Next.Enabled = (i_PointNo < CmdLine.IPara[1] - 1);

            gbox_PlanePositions.Visible = CmdLine.IPara[0] == 3 && CmdLine.Cmd == DispProg.ECmd.DO_HEIGHT;
            lbl_X1Y1.Text = CmdLine.X[0].ToString("F3") + ", " + CmdLine.Y[0].ToString("F3");
            lbl_X2Y2.Text = CmdLine.X[1].ToString("F3") + ", " + CmdLine.Y[1].ToString("F3");
            lbl_X3Y3.Text = CmdLine.X[2].ToString("F3") + ", " + CmdLine.Y[2].ToString("F3");

            lbl_RefHeight.Text = TaskDisp.Laser_CalValue == 0 ? CmdLine.DPara[5].ToString("f3") :(TaskDisp.Laser_CalValue - TaskDisp.Laser_RefPosZ + CmdLine.DPara[5]).ToString("f3");
            lbl_ErrorTol.Text = CmdLine.DPara[6].ToString("f3");
            lbl_SkipTol.Text = CmdLine.DPara[7].ToString("f3");

            lbl_ZDiff.Text = CmdLine.DPara[0].ToString("f3");
            lbl_ZRelTol.Text = CmdLine.DPara[1].ToString("f3");

            double StartV = CmdLine.DPara[10];
            if (StartV == 0)
            {
                StartV = TaskGantry.GXAxis.Para.StartV;
                lbl_StartV.Text = "(" + StartV.ToString("f3") + ")";
            }
            else lbl_StartV.Text = StartV.ToString("f3");
            lbl_StartV.Enabled = true;
            lbl_StartV.BackColor = Color.White;

            double DriveV = CmdLine.DPara[11];
            if (DriveV == 0)
            {
                DriveV = TaskGantry.GXAxis.Para.FastV;
                lbl_DriveV.Text = "(" + DriveV.ToString("f3") + ")";
            }
            else lbl_DriveV.Text = DriveV.ToString("f3");

            double Accel = CmdLine.DPara[12];
            if (Accel == 0)
            {
                Accel = TaskGantry.GXAxis.Para.Accel;
                lbl_Accel.Text = "(" + Accel.ToString("f3") + ")";
            }
            else lbl_Accel.Text = Accel.ToString("f3");
            lbl_Accel.Enabled = true;
            lbl_Accel.BackColor = Color.White;

            lbl_SettleTime.Text = CmdLine.IPara[4].ToString();

            lbl_SkipCount.Text = CmdLine.IPara[5].ToString();
            lbl_FailAction.Text = CmdLine.IPara[6].ToString() + " - " + Enum.GetName(typeof(EFailAction), CmdLine.IPara[6]);

            lbl_UpdateAllLayouts.Text = (CmdLine.IPara[7] > 0).ToString();
        }

        private string CmdName
        {
            get
            {
                return LineNo.ToString("d3") + " " + CmdLine.Cmd.ToString();
            }
        }

        private void frmDispProg_DoHeight_Load(object sender, EventArgs e)
        {
            GControl.UpdateFormControl(this);
            AppLanguage.Func2.UpdateText(this);

            CmdLine.Copy(DispProg.Script[ProgNo].CmdList.Line[LineNo]);
            this.Text = CmdName;

            pnlType.Visible = (CmdLine.Cmd == DispProg.ECmd.DO_HEIGHT);
            gbxType.Visible = (CmdLine.Cmd == DispProg.ECmd.DO_HEIGHT);
            gbox_PlanePositions.Visible = (CmdLine.Cmd == DispProg.ECmd.DO_HEIGHT);
            gbox_HeightPositions.Visible = (CmdLine.Cmd == DispProg.ECmd.DO_HEIGHT);

            if (CmdLine.DPara[0] == 0) CmdLine.DPara[0] = 0.5;
            if (CmdLine.IPara[4] == 0) CmdLine.IPara[4] = 150;//Settle Time

            try
            {
                TaskDisp.TaskMoveGZFocus(CmdLine.IPara[21]);
            }
            catch { };


            UpdateDisplay();
        }
        private void frmDispProg_DoHeight_Shown(object sender, EventArgs e)
        {
        }
        private void frmDispProg_DoHeight_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void lbl_HeightID_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Height ID", ref CmdLine.ID, 0, DispProg.MAX_IDS - 1);
            UpdateDisplay();
        }

        private void lbl_AlignType_Click(object sender, EventArgs e)
        {
            EAlignType E = EAlignType.Board;

            UC.AdjustExec(CmdName + ", AlignType", ref CmdLine.IPara[2], E);
            UpdateDisplay();
        }

        private void btn_HeightType_Click(object sender, EventArgs e)
        {
            int Old = CmdLine.IPara[0];
            CmdLine.IPara[0] = 1;
            int New = CmdLine.IPara[0];
            Log.OnSet(CmdName + ", Height Type", Old, New);

            UpdateDisplay();
        }

        private void btn_PlaneType_Click(object sender, EventArgs e)
        {
            int Old = CmdLine.IPara[0];
            CmdLine.IPara[0] = 3;
            int New = CmdLine.IPara[0];
            Log.OnSet(CmdName + ", Height Type", Old, New);

            UpdateDisplay();
        }

        private void btn_SetPt1Pos_Click(object sender, EventArgs e)
        {
            double X = TaskGantry.GXPos();
            double Y = TaskGantry.GYPos();

            NSW.Net.Point2D Old = new NSW.Net.Point2D(CmdLine.X[0], CmdLine.Y[0]);
            CmdLine.X[0] = X - (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X);
            CmdLine.Y[0] = Y - (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y);
            NSW.Net.Point2D New = new NSW.Net.Point2D(CmdLine.X[0], CmdLine.Y[0]);
            Log.OnSet(CmdName + ", Point 1 XY", Old, New);

            UpdateDisplay();
        }

        private void btn_GotoPt1Pos_Click(object sender, EventArgs e)
        {
            double X = (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X) + CmdLine.X[0];
            double Y = (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y) + CmdLine.Y[0];

            if (!TaskDisp.TaskMoveGZZ2Up()) return;

            if (!TaskGantry.MoveGX2Y2DefPos(true)) return;
            if (!TaskGantry.SetMotionParamGXY()) return;
            if (!TaskGantry.MoveAbsGXY(X, Y)) return;
        }

        private void btn_SetPt2Pos_Click(object sender, EventArgs e)
        {
            double X = TaskGantry.GXPos();
            double Y = TaskGantry.GYPos();

            NSW.Net.Point2D Old = new NSW.Net.Point2D(CmdLine.X[1], CmdLine.Y[1]);
            CmdLine.X[1] = X - (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X);
            CmdLine.Y[1] = Y - (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y);
            NSW.Net.Point2D New = new NSW.Net.Point2D(CmdLine.X[1], CmdLine.Y[1]);
            Log.OnSet(CmdName + ", Point 2 XY", Old, New);

            UpdateDisplay();
        }

        private void btn_GotoPt2Pos_Click(object sender, EventArgs e)
        {
            double X = (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X) + CmdLine.X[1];
            double Y = (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y) + CmdLine.Y[1];

            if (!TaskDisp.TaskMoveGZZ2Up()) return;

            if (!TaskGantry.MoveGX2Y2DefPos(true)) return;
            if (!TaskGantry.SetMotionParamGXY()) return;
            if (!TaskGantry.MoveAbsGXY(X, Y)) return;
        }

        private void btn_SetPt3Pos_Click(object sender, EventArgs e)
        {
            double X = TaskGantry.GXPos();
            double Y = TaskGantry.GYPos();

            NSW.Net.Point2D Old = new NSW.Net.Point2D(CmdLine.X[2], CmdLine.Y[2]);
            CmdLine.X[2] = X - (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X);
            CmdLine.Y[2] = Y - (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y);
            NSW.Net.Point2D New = new NSW.Net.Point2D(CmdLine.X[2], CmdLine.Y[2]);
            Log.OnSet(CmdName + ", Point 3 XY", Old, New);

            UpdateDisplay();
        }

        private void btn_GotoPt3Pos_Click(object sender, EventArgs e)
        {
            double X = (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X) + CmdLine.X[2];
            double Y = (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y) + CmdLine.Y[2];

            if (!TaskDisp.TaskMoveGZZ2Up()) return;

            if (!TaskGantry.MoveGX2Y2DefPos(true)) return;
            if (!TaskGantry.SetMotionParamGXY()) return;
            if (!TaskGantry.MoveAbsGXY(X, Y)) return;
        }


        private void lbl_PointCount_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Point Count", ref CmdLine.IPara[1], 1, MAX_POINTS);
            i_PointNo = Math.Min(i_PointNo, CmdLine.IPara[1] - 1);
            UpdateDisplay();
        }

        private void lbl_PointNo_Click(object sender, EventArgs e)
        {
            int i = i_PointNo + 1;
            UC.AdjustExec(CmdName + ", Point No", ref i, 1, MAX_POINTS);
            i_PointNo = i - 1;
            UpdateDisplay();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (i_PointNo == 0) return;
            i_PointNo--;
            UpdateDisplay();

            if (!TaskDisp.TaskMoveGZZ2Up()) return;

            double X = (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X) + CmdLine.X[i_PointNo];
            double Y = (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y) + CmdLine.Y[i_PointNo];

            if (!TaskGantry.SetMotionParamGXY()) return;
            if (!TaskGantry.MoveAbsGXY(X, Y)) return;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (i_PointNo == MAX_POINTS - 1) return;
            i_PointNo++;
            UpdateDisplay();

            if (!TaskDisp.TaskMoveGZZ2Up()) return;

            double X = (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X) + CmdLine.X[i_PointNo];
            double Y = (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y) + CmdLine.Y[i_PointNo];

            if (!TaskGantry.SetMotionParamGXY()) return;
            if (!TaskGantry.MoveAbsGXY(X, Y)) return;
        }

        private void btn_GotoPt_Click(object sender, EventArgs e)
        {
            if (!TaskDisp.TaskMoveGZZ2Up()) return;
            
            double X = (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X) + CmdLine.X[i_PointNo];
            double Y = (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y) + CmdLine.Y[i_PointNo];

            if (!TaskGantry.MoveGX2Y2DefPos(true)) return;
            if (!TaskGantry.SetMotionParamGXY()) return;
            if (!TaskGantry.MoveAbsGXY(X, Y)) return;
        }

        private void btn_SetPt_Click(object sender, EventArgs e)
        {
            double X = TaskGantry.GXPos();
            double Y = TaskGantry.GYPos();

            NSW.Net.Point2D Old = new NSW.Net.Point2D(CmdLine.X[i_PointNo], CmdLine.Y[i_PointNo]);
            CmdLine.X[i_PointNo] = X - (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X);
            CmdLine.Y[i_PointNo] = Y - (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y);
            NSW.Net.Point2D New = new NSW.Net.Point2D(CmdLine.X[i_PointNo], CmdLine.Y[i_PointNo]);
            Log.OnSet(CmdName + ", Point " + i_PointNo.ToString() + " XY", Old, New);

            UpdateDisplay();
        }

        private void btn_SetSecX1Y1_Click(object sender, EventArgs e)
        {
            double X = TaskGantry.GXPos();
            double Y = TaskGantry.GYPos();

            CmdLine.X[MAX_POINTS] = X - (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X);
            CmdLine.Y[MAX_POINTS] = Y - (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y);

            UpdateDisplay();
        }

        private void btn_GotoSecXY_Click(object sender, EventArgs e)
        {
            if (!TaskDisp.TaskMoveGZZ2Up()) return;

            double X = (DispProg.Origin(DispProg.rt_StationNo).X + SubOrigin.X) + CmdLine.X[MAX_POINTS];
            double Y = (DispProg.Origin(DispProg.rt_StationNo).Y + SubOrigin.Y) + CmdLine.Y[MAX_POINTS];

            if (!TaskGantry.SetMotionParamGXY()) return;
            if (!TaskGantry.MoveAbsGXY(X, Y)) return;
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            DispProg.Script[ProgNo].CmdList.Line[LineNo].Copy(CmdLine);
            Log.OnAction("OK", CmdName);
            Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Log.OnAction("Cancel", CmdName); 
            Close();
        }

        #region Settings
        private void lbl_StartV_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Start Speed (mm/s)", ref CmdLine.DPara[10], 0, 50);
            UpdateDisplay();
        }
        private void lbl_DriveV_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Drive Speed (mm/s)", ref CmdLine.DPara[11], 0, 300);
            UpdateDisplay();
        }
        private void lbl_Accel_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Accel (mm/s2)", ref CmdLine.DPara[12], 0, 10000);
            UpdateDisplay();
        }
        private void lbl_SettleTime_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Settle Time", ref CmdLine.IPara[4], 0, 500);
            UpdateDisplay();
        }
        #endregion

        private void lbl_SkipCount_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Skip Count", ref CmdLine.IPara[5], 0, 99);
            UpdateDisplay();
        }
        private void lbl_FailAction_Click(object sender, EventArgs e)
        {
            EFailAction E = EFailAction.Normal;
            UC.AdjustExec(CmdName + ", Fail Action", ref CmdLine.IPara[6], E);
            UpdateDisplay();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            lbox_Info.Items.Clear();

            switch (CmdLine.Cmd)
            {
                case DispProg.ECmd.DO_HEIGHT:
                    {
                        try
                        {
                            #region
                            double d_RefHeight = TaskDisp.Laser_CalValue == 0 ? CmdLine.DPara[5] : TaskDisp.Laser_CalValue - TaskDisp.Laser_RefPosZ + CmdLine.DPara[5];
                            double d_RefHeightTol = CmdLine.DPara[6];

                            List<double> Z = new List<double>();

                            int t = GDefine.GetTickCount();

                            if (!TaskDisp.TaskMoveGZZ2Up()) return;

                            int i_PointIndex = 0;//index starts from 0
                            int i_PointCount = 1;

                            if (CmdLine.IPara[0] == 3)//Plane Align
                                i_PointCount = 3;
                            else//Height Align
                                i_PointCount = CmdLine.IPara[1];

                            while (i_PointIndex < i_PointCount)
                            {
                                TPos2 GXY = new TPos2();
                                GXY.X = DispProg.Origin(ERunStationNo.Station1).X + CmdLine.X[i_PointIndex];// +(SecIDRelX * i_IDIndex);
                                GXY.Y = DispProg.Origin(ERunStationNo.Station1).Y + CmdLine.Y[i_PointIndex];// +(SecIDRelY * i_IDIndex);
                                GXY.X = GXY.X + TaskDisp.Laser_Ofst.X;
                                GXY.Y = GXY.Y + TaskDisp.Laser_Ofst.Y;

                                if (!TaskGantry.MoveGX2Y2DefPos(true)) return;
                                if (!TaskGantry.SetMotionParamGXY()) return;
                                if (!TaskGantry.MoveAbsGXY(GXY.X, GXY.Y)) return;

                                int t1 = GDefine.GetTickCount() + CmdLine.IPara[4];
                                while (GDefine.GetTickCount() <= t1) { Thread.Sleep(1); }

                                //get value
                                double v = 0;
                                double i = 0;

                                bool b_OK = TaskLaser.GetHeight(ref i);
                                if (!b_OK) goto _GetHeightFail;

                                v = i;
                                Z.Add(v - TaskDisp.Laser_RefPosZ);

                                i_PointIndex++;
                            }

                            t = GDefine.GetTickCount() - t;

                            string str = "";
                            bool OK = true;
                            if (d_RefHeightTol > 0)
                            {
                                foreach (double d in Z)
                                {
                                    if ((d <= d_RefHeight - d_RefHeightTol) || (d >= d_RefHeight + d_RefHeightTol))
                                    {
                                        str = str + "Result: NG ";
                                        str = str + "(Out of Ref Height Tolerance)";
                                        OK = false;
                                        break;
                                    }
                                }
                            }

                            double Diff = Z.Max() - Z.Min();
                            if (Diff > CmdLine.DPara[0])
                            {
                                str = str + "Result: NG ";
                                str = str + "(Min Max Tolerance Fail)";
                                OK = false;
                            }

                            if (OK) str = str + "Result: OK";

                            if (OK) lbox_Info.BackColor = Color.Lime;
                            if (!OK) lbox_Info.BackColor = Color.Red;
                            lbox_Info.Items.Add(str);

                            if (CmdLine.IPara[0] == 3)//Plane Align
                            {
                                #region Plane Align
                                str = "Data:" + (char)9;
                                for (int i = 0; i < 3; i++)
                                {
                                    str = str + "Point" + i.ToString() + (char)9;
                                }
                                str = str + "Ave" + (char)9 + "Diff" + (char)9 + "Time" + (char)9;
                                lbox_Info.Items.Add(str);

                                str = "Data:" + (char)9;
                                for (int i = 0; i < 3; i++)
                                {
                                    str = str + Z[i].ToString("F3") + (char)9;
                                }
                                str = str + Z.Average().ToString("f3") + (char)9 + Diff.ToString("f3") + (char)9 + t.ToString();
                                lbox_Info.Items.Add(str);
                                #endregion
                            }
                            else//Height Align
                            {
                                #region
                                str = "Data:" + (char)9;
                                str = str + "Points" + (char)9 + "Min" + (char)9 + "Max" + (char)9 + "Ave" + (char)9 + "Diff" + (char)9;
                                str = str + "Time";
                                lbox_Info.Items.Add(str);

                                str = "Data:" + (char)9;
                                str = str + Z.Count.ToString() + (char)9 + Z.Min().ToString("F3") + (char)9 + Z.Max().ToString("F3") + (char)9 + Z.Average().ToString("F3") + (char)9 + Diff.ToString("F3") + (char)9;
                                str = str + t.ToString();
                                lbox_Info.Items.Add(str);
                                #endregion
                            }

                            lbox_Info.SelectedIndex = lbox_Info.Items.Count - 1;

                            return;

                        _GetHeightFail:
                            lbox_Info.Items.Add("Get Height Fail");
                            #endregion
                        }
                        catch (Exception ex)
                        {
                            TaskVision.CameraRun = true;
                            MessageBox.Show(ex.Message.ToString());
                        }

                        TaskVision.CameraRun = true;
                        break;
                    }
                case DispProg.ECmd.HEIGHT_SET:
                    {
                        try
                        {
                            THeightData HeightData = new THeightData();
                            HeightData.OK = false;

                            int nextLine = LineNo + 1;
                            bool bNextCmdIsValid =
                                (
                                DispProg.Script[ProgNo].CmdList.Line[nextLine].Cmd == DispProg.ECmd.DOT ||
                                DispProg.Script[ProgNo].CmdList.Line[nextLine].Cmd == DispProg.ECmd.DOT_MULTI ||
                                DispProg.Script[ProgNo].CmdList.Line[nextLine].Cmd == DispProg.ECmd.DOTLINE_MULTI ||
                                DispProg.Script[ProgNo].CmdList.Line[nextLine].Cmd == DispProg.ECmd.DOT_P ||
                                DispProg.Script[ProgNo].CmdList.Line[nextLine].Cmd == DispProg.ECmd.MOVE
                                );
                            if (!bNextCmdIsValid) throw new Exception("Invalid command after HEIGHT_SET");

                            int t = GDefine.GetTickCount();

                            if (!TaskDisp.TaskMoveGZZ2Up()) return;

                            double dx = DispProg.Origin(ERunStationNo.Station1).X + DispProg.Script[ProgNo].CmdList.Line[nextLine].X[0];
                            double dy = DispProg.Origin(ERunStationNo.Station1).Y + DispProg.Script[ProgNo].CmdList.Line[nextLine].Y[0];

                            DispProg.EHeightSetReturn ret = DispProg.HeightSet(CmdLine, HeightData, new PointD(dx, dy));

                            t = GDefine.GetTickCount() - t;

                            lbox_Info.BackColor = HeightData.OK ? this.BackColor : Color.Red;
                            string str = $"Height Value {HeightData.C:f5}, Result " + (HeightData.OK?"OK":"NG") + $",Time {t}ms";
                            lbox_Info.Items.Add(str);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                        finally
                        {
                            TaskVision.CameraRun = true;
                        }

                        break;
                    }
            }
        }

        private void cbox_Tol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frm_DispCore_DispProg_DoHeight_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_DispProg2.Done = true;
        }

        private void lbl_UpdateAllLayouts_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Update All Layouts", ref CmdLine.IPara[7], 0, 1);
            UpdateDisplay();
        }

        #region Judgement
        private void lbl_RefHeight_Click(object sender, EventArgs e)
        {
            if (TaskDisp.Laser_CalValue == 0)
            {
                if (!UC.AdjustExec(CmdName + ", RefHeight", ref CmdLine.DPara[5], -15, 15)) return;
            }
            else
            {
                double d = TaskDisp.Laser_CalValue - TaskDisp.Laser_RefPosZ + CmdLine.DPara[5];
                d = Math.Round(d, 3);

                if (!UC.AdjustExec(CmdName + ", RefHeight", ref d, -15, 15)) return;
                CmdLine.DPara[5] = d - TaskDisp.Laser_CalValue + TaskDisp.Laser_RefPosZ;
            }
            UpdateDisplay();
        }
        private void lbl_ErrorTol_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Ref Height Error Tolerance (mm)", ref CmdLine.DPara[6], 0, 5);
            UpdateDisplay();
        }
        private void lbl_SkipTol_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Ref Height Skip Tolerance (mm)", ref CmdLine.DPara[7], 0, 5);
            UpdateDisplay();
        }

        private void lbl_ZDiff_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Z Diff (mm)", ref CmdLine.DPara[0], 0, 5);
            UpdateDisplay();
        }
        private void lbl_ZRelTol_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Rel Tol (mm)", ref CmdLine.DPara[1], 0, 5);
            UpdateDisplay();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ref Height - Setting Laser Value." + '\r' +
                "Error Tol - Ref Height Tolerance to Prompt Error." + '\r' +
                "Skip Tol - Ref Height Tolerance to Skip Unit." + '\r' +
                "Z Range - Maximum allowable Min and Max range.");
        }

        private void btn_OK_Click_1(object sender, EventArgs e)
        {

        }
    }
}
