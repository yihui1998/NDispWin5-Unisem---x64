﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NDispWin
{
    internal partial class frm_DispCore_DispProg_PPRecycleN : Form
    {
        public DispProg.TLine CmdLine = new DispProg.TLine();
        public int ProgNo = 0;
        public int LineNo = 0;
        public frm_DispCore_DispProg_PPRecycleN()
        {
            InitializeComponent();
            GControl.LogForm(this);

            TopLevel = false;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            //AppLanguage.Func.SetComponent(this);
        }

        private void UpdateDisplay()
        {
            lbl_Count.Text = CmdLine.IPara[2].ToString();
        }

        private string CmdName
        {
            get
            {
                return LineNo.ToString("d3") + " " + CmdLine.Cmd.ToString();
            }
        }

        private void frm_DispCore_DispProg_PPRecycleN_Load(object sender, EventArgs e)
        {
            GControl.UpdateFormControl(this);
            AppLanguage.Func2.UpdateText(this);

            this.Text = CmdName;
            CmdLine.Copy(DispProg.Script[ProgNo].CmdList.Line[LineNo]);
            UpdateDisplay();
        }

        private void lbl_Count_Click(object sender, EventArgs e)
        {
            UC.AdjustExec(CmdName + ", Count", ref CmdLine.IPara[2], 1, 20);
            UpdateDisplay();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DispProg.Script[ProgNo].CmdList.Line[LineNo].Copy(CmdLine);
            //frm_DispProg2.Done = true;
            Log.OnAction("OK", CmdName);
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //frm_DispProg2.Done = true;
            Log.OnAction("Cancel", CmdName);
            Close();
        }

        private void frm_DispCore_DispProg_PPRecycleN_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_DispProg2.Done = true;
        }
    }
}
