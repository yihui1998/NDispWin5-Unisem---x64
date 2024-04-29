﻿namespace NDispWin
{
    partial class frmDeviceIOConfigEditor
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
            this.combox_Device = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_AxisPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combox_Mask = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_Label = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.combox_IONo = new System.Windows.Forms.ComboBox();
            this.combox_MotorNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combox_Device
            // 
            this.combox_Device.FormattingEnabled = true;
            this.combox_Device.Location = new System.Drawing.Point(87, 11);
            this.combox_Device.Name = "combox_Device";
            this.combox_Device.Size = new System.Drawing.Size(160, 22);
            this.combox_Device.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Axis_Port";
            // 
            // combox_AxisPort
            // 
            this.combox_AxisPort.FormattingEnabled = true;
            this.combox_AxisPort.Location = new System.Drawing.Point(75, 6);
            this.combox_AxisPort.Name = "combox_AxisPort";
            this.combox_AxisPort.Size = new System.Drawing.Size(160, 22);
            this.combox_AxisPort.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mask";
            // 
            // combox_Mask
            // 
            this.combox_Mask.FormattingEnabled = true;
            this.combox_Mask.Location = new System.Drawing.Point(75, 34);
            this.combox_Mask.Name = "combox_Mask";
            this.combox_Mask.Size = new System.Drawing.Size(160, 22);
            this.combox_Mask.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 30;
            this.label4.Text = "Label";
            // 
            // tbox_Label
            // 
            this.tbox_Label.Location = new System.Drawing.Point(87, 137);
            this.tbox_Label.Name = "tbox_Label";
            this.tbox_Label.Size = new System.Drawing.Size(160, 22);
            this.tbox_Label.TabIndex = 33;
            // 
            // btn_OK
            // 
            this.btn_OK.ForeColor = System.Drawing.Color.Navy;
            this.btn_OK.Location = new System.Drawing.Point(91, 176);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 36);
            this.btn_OK.TabIndex = 35;
            this.btn_OK.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ForeColor = System.Drawing.Color.Navy;
            this.btn_Cancel.Location = new System.Drawing.Point(172, 176);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 36);
            this.btn_Cancel.TabIndex = 36;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // combox_IONo
            // 
            this.combox_IONo.FormattingEnabled = true;
            this.combox_IONo.Location = new System.Drawing.Point(75, 34);
            this.combox_IONo.Name = "combox_IONo";
            this.combox_IONo.Size = new System.Drawing.Size(160, 22);
            this.combox_IONo.TabIndex = 37;
            this.combox_IONo.SelectionChangeCommitted += new System.EventHandler(this.combox_IONo_SelectionChangeCommitted);
            // 
            // combox_MotorNo
            // 
            this.combox_MotorNo.FormattingEnabled = true;
            this.combox_MotorNo.Location = new System.Drawing.Point(75, 6);
            this.combox_MotorNo.Name = "combox_MotorNo";
            this.combox_MotorNo.Size = new System.Drawing.Size(160, 22);
            this.combox_MotorNo.TabIndex = 38;
            this.combox_MotorNo.SelectionChangeCommitted += new System.EventHandler(this.combox_MotorNo_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 39;
            this.label5.Text = "IO No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 14);
            this.label6.TabIndex = 40;
            this.label6.Text = "Motor No";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(253, 92);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.combox_MotorNo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.combox_IONo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 129);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MCT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.combox_AxisPort);
            this.tabPage2.Controls.Add(this.combox_Mask);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(245, 65);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Motion Card Address";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmDeviceIOConfigEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(298, 237);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tbox_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox_Device);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDeviceIOConfigEditor";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeviceIOConfigEditor";
            this.Load += new System.EventHandler(this.frmDeviceConfigEditor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combox_Device;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combox_AxisPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combox_Mask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_Label;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox combox_IONo;
        private System.Windows.Forms.ComboBox combox_MotorNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}