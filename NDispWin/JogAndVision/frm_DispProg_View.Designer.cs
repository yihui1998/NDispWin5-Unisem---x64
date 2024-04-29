﻿namespace NDispWin
{
    partial class frm_DispProg_View
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
            this.components = new System.ComponentModel.Container();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pbox_Image = new System.Windows.Forms.PictureBox();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_CamOfst = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Set = new System.Windows.Forms.Button();
            this.btn_JogPos = new System.Windows.Forms.Button();
            this.uctrl_JogGantry1 = new NDispWin.uctrl_JogGantry();
            this.tmr_Debug = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Image)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.AccessibleDescription = "Close";
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Location = new System.Drawing.Point(760, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 30);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pbox_Image
            // 
            this.pbox_Image.Location = new System.Drawing.Point(3, 45);
            this.pbox_Image.Name = "pbox_Image";
            this.pbox_Image.Size = new System.Drawing.Size(800, 600);
            this.pbox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Image.TabIndex = 0;
            this.pbox_Image.TabStop = false;
            // 
            // pnl_Top
            // 
            this.pnl_Top.AutoSize = true;
            this.pnl_Top.Controls.Add(this.btn_CamOfst);
            this.pnl_Top.Controls.Add(this.btn_Confirm);
            this.pnl_Top.Controls.Add(this.btn_Set);
            this.pnl_Top.Controls.Add(this.btn_JogPos);
            this.pnl_Top.Controls.Add(this.btn_Close);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(3, 3);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(838, 36);
            this.pnl_Top.TabIndex = 6;
            // 
            // btn_CamOfst
            // 
            this.btn_CamOfst.AccessibleDescription = "CamOfst";
            this.btn_CamOfst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CamOfst.Location = new System.Drawing.Point(517, 3);
            this.btn_CamOfst.Name = "btn_CamOfst";
            this.btn_CamOfst.Size = new System.Drawing.Size(75, 30);
            this.btn_CamOfst.TabIndex = 8;
            this.btn_CamOfst.Text = "CamOfst";
            this.btn_CamOfst.UseVisualStyleBackColor = true;
            this.btn_CamOfst.Click += new System.EventHandler(this.btn_CamOfst_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.AccessibleDescription = "Confirm";
            this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirm.Location = new System.Drawing.Point(679, 3);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 30);
            this.btn_Confirm.TabIndex = 7;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Set
            // 
            this.btn_Set.AccessibleDescription = "Set";
            this.btn_Set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Set.Location = new System.Drawing.Point(598, 3);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 30);
            this.btn_Set.TabIndex = 6;
            this.btn_Set.Text = "Set";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_SetOrigin_Click);
            // 
            // btn_JogPos
            // 
            this.btn_JogPos.Location = new System.Drawing.Point(3, 3);
            this.btn_JogPos.Name = "btn_JogPos";
            this.btn_JogPos.Size = new System.Drawing.Size(75, 30);
            this.btn_JogPos.TabIndex = 5;
            this.btn_JogPos.Text = "Jog Pos";
            this.btn_JogPos.UseVisualStyleBackColor = true;
            this.btn_JogPos.Click += new System.EventHandler(this.btn_JogPos_Click);
            // 
            // uctrl_JogGantry1
            // 
            this.uctrl_JogGantry1.AutoSize = true;
            this.uctrl_JogGantry1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uctrl_JogGantry1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uctrl_JogGantry1.ForeColor = System.Drawing.Color.Navy;
            this.uctrl_JogGantry1.Location = new System.Drawing.Point(268, 97);
            this.uctrl_JogGantry1.Name = "uctrl_JogGantry1";
            this.uctrl_JogGantry1.Size = new System.Drawing.Size(503, 223);
            this.uctrl_JogGantry1.TabIndex = 5;
            // 
            // tmr_Debug
            // 
            this.tmr_Debug.Interval = 3000;
            this.tmr_Debug.Tick += new System.EventHandler(this.tmr_Debug_Tick);
            // 
            // frm_DispProg_View
            // 
            this.AccessibleDescription = "OK";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 700);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.uctrl_JogGantry1);
            this.Controls.Add(this.pbox_Image);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_DispProg_View";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DispProg_View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DispProg_View_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_DispProg_View_FormClosed);
            this.Load += new System.EventHandler(this.frm_DispProg_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Image)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_Image;
        private System.Windows.Forms.Button btn_Close;
        private uctrl_JogGantry uctrl_JogGantry1;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_JogPos;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Timer tmr_Debug;
        private System.Windows.Forms.Button btn_CamOfst;
    }
}