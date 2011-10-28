﻿namespace MagicMongoDBTool
{
    partial class frmAddConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddConnection));
            this.lblReplsetName = new System.Windows.Forms.Label();
            this.radRouteSrv = new System.Windows.Forms.RadioButton();
            this.radConfigSrv = new System.Windows.Forms.RadioButton();
            this.radDataSrv = new System.Windows.Forms.RadioButton();
            this.chkSlaveOk = new System.Windows.Forms.CheckBox();
            this.cmdCancel = new System.Windows.Forms.VistaButton();
            this.cmdAdd = new System.Windows.Forms.VistaButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblIpAddr = new System.Windows.Forms.Label();
            this.txtHostName = new QLFUI.TextBoxEx();
            this.txtPassword = new QLFUI.TextBoxEx();
            this.txtUsername = new QLFUI.TextBoxEx();
            this.txtIpAddr = new QLFUI.TextBoxEx();
            this.txtPort = new QLFUI.TextBoxEx();
            this.txtReplSet = new QLFUI.TextBoxEx();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentPanel.BackgroundImage")));
            this.contentPanel.Controls.Add(this.txtReplSet);
            this.contentPanel.Controls.Add(this.txtPort);
            this.contentPanel.Controls.Add(this.txtIpAddr);
            this.contentPanel.Controls.Add(this.txtUsername);
            this.contentPanel.Controls.Add(this.txtPassword);
            this.contentPanel.Controls.Add(this.txtHostName);
            this.contentPanel.Controls.Add(this.lblIpAddr);
            this.contentPanel.Controls.Add(this.lblReplsetName);
            this.contentPanel.Controls.Add(this.radRouteSrv);
            this.contentPanel.Controls.Add(this.radConfigSrv);
            this.contentPanel.Controls.Add(this.radDataSrv);
            this.contentPanel.Controls.Add(this.chkSlaveOk);
            this.contentPanel.Controls.Add(this.cmdCancel);
            this.contentPanel.Controls.Add(this.cmdAdd);
            this.contentPanel.Controls.Add(this.lblPassword);
            this.contentPanel.Controls.Add(this.lblUsername);
            this.contentPanel.Controls.Add(this.lblPort);
            this.contentPanel.Controls.Add(this.lblHostName);
            this.contentPanel.Location = new System.Drawing.Point(1, 38);
            this.contentPanel.Size = new System.Drawing.Size(572, 170);
            // 
            // lblReplsetName
            // 
            this.lblReplsetName.AutoSize = true;
            this.lblReplsetName.BackColor = System.Drawing.Color.Transparent;
            this.lblReplsetName.Location = new System.Drawing.Point(381, 54);
            this.lblReplsetName.Name = "lblReplsetName";
            this.lblReplsetName.Size = new System.Drawing.Size(55, 13);
            this.lblReplsetName.TabIndex = 29;
            this.lblReplsetName.Text = "副本名称";
            // 
            // radRouteSrv
            // 
            this.radRouteSrv.AutoSize = true;
            this.radRouteSrv.BackColor = System.Drawing.Color.Transparent;
            this.radRouteSrv.Location = new System.Drawing.Point(273, 81);
            this.radRouteSrv.Name = "radRouteSrv";
            this.radRouteSrv.Size = new System.Drawing.Size(85, 17);
            this.radRouteSrv.TabIndex = 8;
            this.radRouteSrv.TabStop = true;
            this.radRouteSrv.Text = "路由服务器";
            this.radRouteSrv.UseVisualStyleBackColor = false;
            // 
            // radConfigSrv
            // 
            this.radConfigSrv.AutoSize = true;
            this.radConfigSrv.BackColor = System.Drawing.Color.Transparent;
            this.radConfigSrv.Location = new System.Drawing.Point(155, 81);
            this.radConfigSrv.Name = "radConfigSrv";
            this.radConfigSrv.Size = new System.Drawing.Size(85, 17);
            this.radConfigSrv.TabIndex = 7;
            this.radConfigSrv.TabStop = true;
            this.radConfigSrv.Text = "配置服务器";
            this.radConfigSrv.UseVisualStyleBackColor = false;
            // 
            // radDataSrv
            // 
            this.radDataSrv.AutoSize = true;
            this.radDataSrv.BackColor = System.Drawing.Color.Transparent;
            this.radDataSrv.Location = new System.Drawing.Point(52, 82);
            this.radDataSrv.Name = "radDataSrv";
            this.radDataSrv.Size = new System.Drawing.Size(85, 17);
            this.radDataSrv.TabIndex = 6;
            this.radDataSrv.TabStop = true;
            this.radDataSrv.Text = "数据服务器";
            this.radDataSrv.UseVisualStyleBackColor = false;
            // 
            // chkSlaveOk
            // 
            this.chkSlaveOk.AutoSize = true;
            this.chkSlaveOk.BackColor = System.Drawing.Color.Transparent;
            this.chkSlaveOk.Location = new System.Drawing.Point(382, 83);
            this.chkSlaveOk.Name = "chkSlaveOk";
            this.chkSlaveOk.Size = new System.Drawing.Size(152, 17);
            this.chkSlaveOk.TabIndex = 9;
            this.chkSlaveOk.Text = "主从模式[GFS 操作限制]";
            this.chkSlaveOk.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Transparent;
            this.cmdCancel.Location = new System.Drawing.Point(471, 120);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 37);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "取消";
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.Color.Transparent;
            this.cmdAdd.Location = new System.Drawing.Point(382, 120);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 37);
            this.cmdAdd.TabIndex = 10;
            this.cmdAdd.Text = "添加";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(224, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(31, 13);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "密码";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(49, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(43, 13);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "用户名";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            this.lblPort.Location = new System.Drawing.Point(379, 23);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(43, 13);
            this.lblPort.TabIndex = 22;
            this.lblPort.Text = "端口号";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.BackColor = System.Drawing.Color.Transparent;
            this.lblHostName.Location = new System.Drawing.Point(49, 26);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(31, 13);
            this.lblHostName.TabIndex = 20;
            this.lblHostName.Text = "名称";
            // 
            // lblIpAddr
            // 
            this.lblIpAddr.AutoSize = true;
            this.lblIpAddr.BackColor = System.Drawing.Color.Transparent;
            this.lblIpAddr.Location = new System.Drawing.Point(224, 26);
            this.lblIpAddr.Name = "lblIpAddr";
            this.lblIpAddr.Size = new System.Drawing.Size(31, 13);
            this.lblIpAddr.TabIndex = 31;
            this.lblIpAddr.Text = "地址";
            // 
            // txtHostName
            // 
            this.txtHostName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHostName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHostName.BackColor = System.Drawing.Color.Transparent;
            this.txtHostName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtHostName.ForeImage = null;
            this.txtHostName.Location = new System.Drawing.Point(110, 17);
            this.txtHostName.Multiline = false;
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Radius = 3;
            this.txtHostName.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtHostName.Size = new System.Drawing.Size(103, 29);
            this.txtHostName.TabIndex = 0;
            this.txtHostName.UseSystemPasswordChar = false;
            this.txtHostName.WaterMark = "服务器表示名称";
            this.txtHostName.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtPassword.ForeImage = null;
            this.txtPassword.Location = new System.Drawing.Point(272, 48);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Radius = 3;
            this.txtPassword.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtPassword.Size = new System.Drawing.Size(103, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "密码（可选项）";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtUsername.ForeImage = null;
            this.txtUsername.Location = new System.Drawing.Point(110, 48);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Radius = 3;
            this.txtUsername.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtUsername.Size = new System.Drawing.Size(103, 29);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WaterMark = "用户名（可选项）";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // txtIpAddr
            // 
            this.txtIpAddr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIpAddr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIpAddr.BackColor = System.Drawing.Color.Transparent;
            this.txtIpAddr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtIpAddr.ForeImage = null;
            this.txtIpAddr.Location = new System.Drawing.Point(273, 17);
            this.txtIpAddr.Multiline = false;
            this.txtIpAddr.Name = "txtIpAddr";
            this.txtIpAddr.Radius = 3;
            this.txtIpAddr.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtIpAddr.Size = new System.Drawing.Size(103, 29);
            this.txtIpAddr.TabIndex = 1;
            this.txtIpAddr.UseSystemPasswordChar = false;
            this.txtIpAddr.WaterMark = "服务器IP地址";
            this.txtIpAddr.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // txtPort
            // 
            this.txtPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPort.BackColor = System.Drawing.Color.Transparent;
            this.txtPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtPort.ForeImage = null;
            this.txtPort.Location = new System.Drawing.Point(442, 17);
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.Radius = 3;
            this.txtPort.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtPort.Size = new System.Drawing.Size(103, 29);
            this.txtPort.TabIndex = 2;
            this.txtPort.UseSystemPasswordChar = false;
            this.txtPort.WaterMark = "服务器端口号";
            this.txtPort.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // txtReplSet
            // 
            this.txtReplSet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtReplSet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtReplSet.BackColor = System.Drawing.Color.Transparent;
            this.txtReplSet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(208)))), ((int)(((byte)(226)))));
            this.txtReplSet.ForeImage = null;
            this.txtReplSet.Location = new System.Drawing.Point(442, 45);
            this.txtReplSet.Multiline = false;
            this.txtReplSet.Name = "txtReplSet";
            this.txtReplSet.Radius = 3;
            this.txtReplSet.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.txtReplSet.Size = new System.Drawing.Size(103, 29);
            this.txtReplSet.TabIndex = 5;
            this.txtReplSet.UseSystemPasswordChar = false;
            this.txtReplSet.WaterMark = "副本名称（可选项）";
            this.txtReplSet.WaterMarkColor = System.Drawing.Color.Silver;
            // 
            // frmAddConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 233);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddConnection";
            this.ShowSelectSkinButton = false;
            this.Text = "数据连接";
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReplsetName;
        private System.Windows.Forms.RadioButton radRouteSrv;
        private System.Windows.Forms.RadioButton radConfigSrv;
        private System.Windows.Forms.RadioButton radDataSrv;
        private System.Windows.Forms.CheckBox chkSlaveOk;
        private System.Windows.Forms.VistaButton cmdCancel;
        private System.Windows.Forms.VistaButton cmdAdd;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblIpAddr;
        private QLFUI.TextBoxEx txtHostName;
        private QLFUI.TextBoxEx txtPort;
        private QLFUI.TextBoxEx txtIpAddr;
        private QLFUI.TextBoxEx txtUsername;
        private QLFUI.TextBoxEx txtPassword;
        private QLFUI.TextBoxEx txtReplSet;
    }
}