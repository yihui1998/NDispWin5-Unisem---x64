﻿namespace DispCore
{
    partial class frm_DispProg_PurgeStage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Jog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EditModel = new System.Windows.Forms.Button();
            this.lbl_ModelNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_PurgeCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbox_Pos = new System.Windows.Forms.GroupBox();
            this.lbl_StartY = new System.Windows.Forms.Label();
            this.lbl_PitchY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_PitchX = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_RemainCount = new System.Windows.Forms.Label();
            this.lbl_UsedCount = new System.Windows.Forms.Label();
            this.lbl_LastCR_X = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_LastCR_Y = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_TotalRow = new System.Windows.Forms.Label();
            this.lbl_TotalCol = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_EndY = new System.Windows.Forms.Label();
            this.btn_EndXY = new System.Windows.Forms.Button();
            this.lbl_EndX = new System.Windows.Forms.Label();
            this.btn_SetXY2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_StartXY = new System.Windows.Forms.Button();
            this.lbl_StartX = new System.Windows.Forms.Label();
            this.btn_SetXY1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbox_Pos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btn_Jog);
            this.panel2.Controls.Add(this.btn_Execute);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(6, 415);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(480, 44);
            this.panel2.TabIndex = 137;
            // 
            // btn_Execute
            // 
            this.btn_Execute.AccessibleDescription = "Execute";
            this.btn_Execute.Location = new System.Drawing.Point(7, 7);
            this.btn_Execute.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(75, 30);
            this.btn_Execute.TabIndex = 102;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.AccessibleDescription = "Close";
            this.btn_Close.Location = new System.Drawing.Point(398, 7);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 30);
            this.btn_Close.TabIndex = 100;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_EditModel);
            this.panel1.Controls.Add(this.lbl_ModelNo);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(480, 64);
            this.panel1.TabIndex = 136;
            // 
            // btn_Jog
            // 
            this.btn_Jog.AccessibleDescription = "Jog";
            this.btn_Jog.Location = new System.Drawing.Point(290, 7);
            this.btn_Jog.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Jog.Name = "btn_Jog";
            this.btn_Jog.Size = new System.Drawing.Size(75, 30);
            this.btn_Jog.TabIndex = 131;
            this.btn_Jog.Text = "Jog";
            this.btn_Jog.UseVisualStyleBackColor = true;
            this.btn_Jog.Click += new System.EventHandler(this.btn_Jog_Click);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Model No";
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Model No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_EditModel
            // 
            this.btn_EditModel.AccessibleDescription = "Edit";
            this.btn_EditModel.Location = new System.Drawing.Point(165, 7);
            this.btn_EditModel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditModel.Name = "btn_EditModel";
            this.btn_EditModel.Size = new System.Drawing.Size(75, 23);
            this.btn_EditModel.TabIndex = 3;
            this.btn_EditModel.Text = "Edit";
            this.btn_EditModel.UseVisualStyleBackColor = true;
            this.btn_EditModel.Click += new System.EventHandler(this.btn_EditModel_Click);
            // 
            // lbl_ModelNo
            // 
            this.lbl_ModelNo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ModelNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ModelNo.Location = new System.Drawing.Point(86, 7);
            this.lbl_ModelNo.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_ModelNo.Name = "lbl_ModelNo";
            this.lbl_ModelNo.Size = new System.Drawing.Size(75, 23);
            this.lbl_ModelNo.TabIndex = 113;
            this.lbl_ModelNo.Text = "lbl_ModelNo";
            this.lbl_ModelNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ModelNo.Click += new System.EventHandler(this.lbl_ModelNo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "Settings";
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_PurgeCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.groupBox1.Size = new System.Drawing.Size(480, 116);
            this.groupBox1.TabIndex = 134;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "Count";
            this.label6.Location = new System.Drawing.Point(240, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 114;
            this.label6.Text = "Count";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PurgeCount
            // 
            this.lbl_PurgeCount.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_PurgeCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PurgeCount.Location = new System.Drawing.Point(240, 49);
            this.lbl_PurgeCount.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_PurgeCount.Name = "lbl_PurgeCount";
            this.lbl_PurgeCount.Size = new System.Drawing.Size(75, 23);
            this.lbl_PurgeCount.TabIndex = 113;
            this.lbl_PurgeCount.Text = "3";
            this.lbl_PurgeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_PurgeCount.Click += new System.EventHandler(this.lbl_PurgeCount_Click);
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "Purge Count";
            this.label7.Location = new System.Drawing.Point(7, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 110;
            this.label7.Text = "Purge Count";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbox_Pos
            // 
            this.gbox_Pos.AccessibleDescription = "Position";
            this.gbox_Pos.AutoSize = true;
            this.gbox_Pos.Controls.Add(this.lbl_StartY);
            this.gbox_Pos.Controls.Add(this.lbl_PitchY);
            this.gbox_Pos.Controls.Add(this.label2);
            this.gbox_Pos.Controls.Add(this.lbl_PitchX);
            this.gbox_Pos.Controls.Add(this.label14);
            this.gbox_Pos.Controls.Add(this.btn_Reset);
            this.gbox_Pos.Controls.Add(this.label18);
            this.gbox_Pos.Controls.Add(this.lbl_RemainCount);
            this.gbox_Pos.Controls.Add(this.lbl_UsedCount);
            this.gbox_Pos.Controls.Add(this.lbl_LastCR_X);
            this.gbox_Pos.Controls.Add(this.label15);
            this.gbox_Pos.Controls.Add(this.lbl_LastCR_Y);
            this.gbox_Pos.Controls.Add(this.label13);
            this.gbox_Pos.Controls.Add(this.label12);
            this.gbox_Pos.Controls.Add(this.lbl_TotalRow);
            this.gbox_Pos.Controls.Add(this.lbl_TotalCol);
            this.gbox_Pos.Controls.Add(this.label9);
            this.gbox_Pos.Controls.Add(this.lbl_EndY);
            this.gbox_Pos.Controls.Add(this.btn_EndXY);
            this.gbox_Pos.Controls.Add(this.lbl_EndX);
            this.gbox_Pos.Controls.Add(this.btn_SetXY2);
            this.gbox_Pos.Controls.Add(this.label8);
            this.gbox_Pos.Controls.Add(this.btn_StartXY);
            this.gbox_Pos.Controls.Add(this.lbl_StartX);
            this.gbox_Pos.Controls.Add(this.btn_SetXY1);
            this.gbox_Pos.Controls.Add(this.label5);
            this.gbox_Pos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_Pos.Location = new System.Drawing.Point(6, 76);
            this.gbox_Pos.Name = "gbox_Pos";
            this.gbox_Pos.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.gbox_Pos.Size = new System.Drawing.Size(480, 211);
            this.gbox_Pos.TabIndex = 133;
            this.gbox_Pos.TabStop = false;
            this.gbox_Pos.Text = "Position";
            // 
            // lbl_StartY
            // 
            this.lbl_StartY.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_StartY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_StartY.Location = new System.Drawing.Point(240, 26);
            this.lbl_StartY.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_StartY.Name = "lbl_StartY";
            this.lbl_StartY.Size = new System.Drawing.Size(75, 23);
            this.lbl_StartY.TabIndex = 155;
            this.lbl_StartY.Text = "-999.999";
            this.lbl_StartY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_StartY.Click += new System.EventHandler(this.lbl_Y1_Click);
            // 
            // lbl_PitchY
            // 
            this.lbl_PitchY.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_PitchY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PitchY.Location = new System.Drawing.Point(240, 90);
            this.lbl_PitchY.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_PitchY.Name = "lbl_PitchY";
            this.lbl_PitchY.Size = new System.Drawing.Size(75, 23);
            this.lbl_PitchY.TabIndex = 154;
            this.lbl_PitchY.Text = "-999.999";
            this.lbl_PitchY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_PitchY.Click += new System.EventHandler(this.lbl_PitchY_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(117, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 153;
            this.label2.Text = "(C, R)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PitchX
            // 
            this.lbl_PitchX.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_PitchX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PitchX.Location = new System.Drawing.Point(161, 90);
            this.lbl_PitchX.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_PitchX.Name = "lbl_PitchX";
            this.lbl_PitchX.Size = new System.Drawing.Size(75, 23);
            this.lbl_PitchX.TabIndex = 152;
            this.lbl_PitchX.Text = "-999.999";
            this.lbl_PitchX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_PitchX.Click += new System.EventHandler(this.lbl_PitchX_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(7, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 23);
            this.label14.TabIndex = 151;
            this.label14.Text = "Pitch";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Reset
            // 
            this.btn_Reset.AccessibleDescription = "Reset";
            this.btn_Reset.Location = new System.Drawing.Point(319, 140);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 30);
            this.btn_Reset.TabIndex = 150;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(58, 171);
            this.label18.Margin = new System.Windows.Forms.Padding(2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 23);
            this.label18.TabIndex = 149;
            this.label18.Text = "(Used, Remain)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_RemainCount
            // 
            this.lbl_RemainCount.Location = new System.Drawing.Point(240, 171);
            this.lbl_RemainCount.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_RemainCount.Name = "lbl_RemainCount";
            this.lbl_RemainCount.Size = new System.Drawing.Size(75, 23);
            this.lbl_RemainCount.TabIndex = 148;
            this.lbl_RemainCount.Text = "lbl_CurrRemain";
            this.lbl_RemainCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UsedCount
            // 
            this.lbl_UsedCount.Location = new System.Drawing.Point(161, 171);
            this.lbl_UsedCount.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_UsedCount.Name = "lbl_UsedCount";
            this.lbl_UsedCount.Size = new System.Drawing.Size(75, 23);
            this.lbl_UsedCount.TabIndex = 146;
            this.lbl_UsedCount.Text = "lbl_CurrUsed";
            this.lbl_UsedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LastCR_X
            // 
            this.lbl_LastCR_X.Location = new System.Drawing.Point(161, 144);
            this.lbl_LastCR_X.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_LastCR_X.Name = "lbl_LastCR_X";
            this.lbl_LastCR_X.Size = new System.Drawing.Size(75, 23);
            this.lbl_LastCR_X.TabIndex = 144;
            this.lbl_LastCR_X.Text = "lbl_CurrCol";
            this.lbl_LastCR_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(117, 144);
            this.label15.Margin = new System.Windows.Forms.Padding(2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 23);
            this.label15.TabIndex = 143;
            this.label15.Text = "(C, R)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_LastCR_Y
            // 
            this.lbl_LastCR_Y.Location = new System.Drawing.Point(240, 144);
            this.lbl_LastCR_Y.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_LastCR_Y.Name = "lbl_LastCR_Y";
            this.lbl_LastCR_Y.Size = new System.Drawing.Size(75, 23);
            this.lbl_LastCR_Y.TabIndex = 142;
            this.lbl_LastCR_Y.Text = "lbl_CurrRow";
            this.lbl_LastCR_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(7, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 23);
            this.label13.TabIndex = 141;
            this.label13.Text = "Current ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(117, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 23);
            this.label12.TabIndex = 140;
            this.label12.Text = "(C, R)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TotalRow
            // 
            this.lbl_TotalRow.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_TotalRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TotalRow.Location = new System.Drawing.Point(240, 117);
            this.lbl_TotalRow.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_TotalRow.Name = "lbl_TotalRow";
            this.lbl_TotalRow.Size = new System.Drawing.Size(75, 23);
            this.lbl_TotalRow.TabIndex = 139;
            this.lbl_TotalRow.Text = "-999.999";
            this.lbl_TotalRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_TotalRow.Click += new System.EventHandler(this.lbl_CRCountR_Click);
            // 
            // lbl_TotalCol
            // 
            this.lbl_TotalCol.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_TotalCol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TotalCol.Location = new System.Drawing.Point(161, 117);
            this.lbl_TotalCol.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_TotalCol.Name = "lbl_TotalCol";
            this.lbl_TotalCol.Size = new System.Drawing.Size(75, 23);
            this.lbl_TotalCol.TabIndex = 138;
            this.lbl_TotalCol.Text = "-999.999";
            this.lbl_TotalCol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_TotalCol.Click += new System.EventHandler(this.lbl_CRCountX_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 137;
            this.label9.Text = "Col Row ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_EndY
            // 
            this.lbl_EndY.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_EndY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_EndY.Location = new System.Drawing.Point(240, 60);
            this.lbl_EndY.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_EndY.Name = "lbl_EndY";
            this.lbl_EndY.Size = new System.Drawing.Size(75, 23);
            this.lbl_EndY.TabIndex = 135;
            this.lbl_EndY.Text = "-999.999";
            this.lbl_EndY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_EndXY
            // 
            this.btn_EndXY.AccessibleDescription = "End XY";
            this.btn_EndXY.Location = new System.Drawing.Point(7, 56);
            this.btn_EndXY.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EndXY.Name = "btn_EndXY";
            this.btn_EndXY.Size = new System.Drawing.Size(106, 30);
            this.btn_EndXY.TabIndex = 133;
            this.btn_EndXY.Text = "End XY";
            this.btn_EndXY.UseVisualStyleBackColor = true;
            this.btn_EndXY.Click += new System.EventHandler(this.btn_EndXY_Click);
            // 
            // lbl_EndX
            // 
            this.lbl_EndX.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_EndX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_EndX.Location = new System.Drawing.Point(161, 60);
            this.lbl_EndX.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_EndX.Name = "lbl_EndX";
            this.lbl_EndX.Size = new System.Drawing.Size(75, 23);
            this.lbl_EndX.TabIndex = 134;
            this.lbl_EndX.Text = "-999.999";
            this.lbl_EndX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_SetXY2
            // 
            this.btn_SetXY2.AccessibleDescription = "Set";
            this.btn_SetXY2.Location = new System.Drawing.Point(319, 56);
            this.btn_SetXY2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SetXY2.Name = "btn_SetXY2";
            this.btn_SetXY2.Size = new System.Drawing.Size(75, 30);
            this.btn_SetXY2.TabIndex = 132;
            this.btn_SetXY2.Text = "Set";
            this.btn_SetXY2.UseVisualStyleBackColor = true;
            this.btn_SetXY2.Click += new System.EventHandler(this.btn_SetEndXY_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(117, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 131;
            this.label8.Text = "(mm)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_StartXY
            // 
            this.btn_StartXY.AccessibleDescription = "Start XY";
            this.btn_StartXY.Location = new System.Drawing.Point(7, 22);
            this.btn_StartXY.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StartXY.Name = "btn_StartXY";
            this.btn_StartXY.Size = new System.Drawing.Size(106, 30);
            this.btn_StartXY.TabIndex = 8;
            this.btn_StartXY.Text = "Start XY";
            this.btn_StartXY.UseVisualStyleBackColor = true;
            this.btn_StartXY.Click += new System.EventHandler(this.btn_StartXY_Click);
            // 
            // lbl_StartX
            // 
            this.lbl_StartX.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_StartX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_StartX.Location = new System.Drawing.Point(161, 26);
            this.lbl_StartX.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_StartX.Name = "lbl_StartX";
            this.lbl_StartX.Size = new System.Drawing.Size(75, 23);
            this.lbl_StartX.TabIndex = 109;
            this.lbl_StartX.Text = "-999.999";
            this.lbl_StartX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_StartX.Click += new System.EventHandler(this.lbl_X1_Click);
            // 
            // btn_SetXY1
            // 
            this.btn_SetXY1.AccessibleDescription = "Set";
            this.btn_SetXY1.Location = new System.Drawing.Point(319, 22);
            this.btn_SetXY1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SetXY1.Name = "btn_SetXY1";
            this.btn_SetXY1.Size = new System.Drawing.Size(75, 30);
            this.btn_SetXY1.TabIndex = 7;
            this.btn_SetXY1.Text = "Set";
            this.btn_SetXY1.UseVisualStyleBackColor = true;
            this.btn_SetXY1.Click += new System.EventHandler(this.btn_SetStartXY_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(117, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "(mm)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_DispProg_PurgeStage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(506, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbox_Pos);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_DispProg_PurgeStage";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "frm_DispProg_PurgeStage";
            this.Load += new System.EventHandler(this.frm_DispProg_PurgeStage_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbox_Pos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EditModel;
        private System.Windows.Forms.Label lbl_ModelNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbox_Pos;
        private System.Windows.Forms.Button btn_StartXY;
        private System.Windows.Forms.Label lbl_StartX;
        private System.Windows.Forms.Button btn_SetXY1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_TotalRow;
        private System.Windows.Forms.Label lbl_TotalCol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_EndY;
        private System.Windows.Forms.Button btn_EndXY;
        private System.Windows.Forms.Label lbl_EndX;
        private System.Windows.Forms.Button btn_SetXY2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_RemainCount;
        private System.Windows.Forms.Label lbl_UsedCount;
        private System.Windows.Forms.Label lbl_LastCR_X;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_LastCR_Y;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_PurgeCount;
        private System.Windows.Forms.Label lbl_PitchY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_PitchX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_StartY;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Button btn_Jog;
    }
}