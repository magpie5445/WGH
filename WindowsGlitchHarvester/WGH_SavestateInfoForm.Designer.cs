﻿namespace WindowsGlitchHarvester
{
    partial class WGH_SavestateInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WGH_SavestateInfoForm));
            this.sramLabel = new System.Windows.Forms.Label();
            this.aramexramLabel = new System.Windows.Forms.Label();
            this.aramexramOffset = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sramAlignment = new System.Windows.Forms.Label();
            this.aramexramAlignment = new System.Windows.Forms.Label();
            this.sramOffset = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNetCoreConsole = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartNetCore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnLoadState = new System.Windows.Forms.Button();
            this.btnSaveState = new System.Windows.Forms.Button();
            this.pnNetCoreActions = new System.Windows.Forms.Panel();
            this.btnPokeBytes = new System.Windows.Forms.Button();
            this.btnPeekBytes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.peekedValue = new System.Windows.Forms.Label();
            this.valueNum = new System.Windows.Forms.NumericUpDown();
            this.addressNum = new System.Windows.Forms.NumericUpDown();
            this.btnPeekByte = new System.Windows.Forms.Button();
            this.btnPokeByte = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnNetCoreActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressNum)).BeginInit();
            this.SuspendLayout();
            // 
            // sramLabel
            // 
            this.sramLabel.AutoSize = true;
            this.sramLabel.BackColor = System.Drawing.Color.Transparent;
            this.sramLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sramLabel.ForeColor = System.Drawing.Color.White;
            this.sramLabel.Location = new System.Drawing.Point(16, 52);
            this.sramLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sramLabel.Name = "sramLabel";
            this.sramLabel.Size = new System.Drawing.Size(55, 23);
            this.sramLabel.TabIndex = 0;
            this.sramLabel.Text = "SRAM";
            this.sramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aramexramLabel
            // 
            this.aramexramLabel.AutoSize = true;
            this.aramexramLabel.BackColor = System.Drawing.Color.Transparent;
            this.aramexramLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.aramexramLabel.ForeColor = System.Drawing.Color.White;
            this.aramexramLabel.Location = new System.Drawing.Point(16, 84);
            this.aramexramLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aramexramLabel.Name = "aramexramLabel";
            this.aramexramLabel.Size = new System.Drawing.Size(57, 23);
            this.aramexramLabel.TabIndex = 1;
            this.aramexramLabel.Text = "ARAM";
            this.aramexramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aramexramOffset
            // 
            this.aramexramOffset.AutoSize = true;
            this.aramexramOffset.BackColor = System.Drawing.Color.Transparent;
            this.aramexramOffset.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.aramexramOffset.ForeColor = System.Drawing.Color.White;
            this.aramexramOffset.Location = new System.Drawing.Point(104, 84);
            this.aramexramOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aramexramOffset.Name = "aramexramOffset";
            this.aramexramOffset.Size = new System.Drawing.Size(82, 23);
            this.aramexramOffset.TabIndex = 5;
            this.aramexramOffset.Text = "00000000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.sramAlignment);
            this.panel1.Controls.Add(this.aramexramAlignment);
            this.panel1.Controls.Add(this.sramOffset);
            this.panel1.Controls.Add(this.aramexramOffset);
            this.panel1.Controls.Add(this.aramexramLabel);
            this.panel1.Controls.Add(this.sramLabel);
            this.panel1.Location = new System.Drawing.Point(16, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 165);
            this.panel1.TabIndex = 7;
            // 
            // sramAlignment
            // 
            this.sramAlignment.AutoSize = true;
            this.sramAlignment.BackColor = System.Drawing.Color.Transparent;
            this.sramAlignment.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sramAlignment.ForeColor = System.Drawing.Color.White;
            this.sramAlignment.Location = new System.Drawing.Point(265, 52);
            this.sramAlignment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sramAlignment.Name = "sramAlignment";
            this.sramAlignment.Size = new System.Drawing.Size(19, 23);
            this.sramAlignment.TabIndex = 7;
            this.sramAlignment.Text = "0";
            // 
            // aramexramAlignment
            // 
            this.aramexramAlignment.AutoSize = true;
            this.aramexramAlignment.BackColor = System.Drawing.Color.Transparent;
            this.aramexramAlignment.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.aramexramAlignment.ForeColor = System.Drawing.Color.White;
            this.aramexramAlignment.Location = new System.Drawing.Point(265, 84);
            this.aramexramAlignment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aramexramAlignment.Name = "aramexramAlignment";
            this.aramexramAlignment.Size = new System.Drawing.Size(19, 23);
            this.aramexramAlignment.TabIndex = 8;
            this.aramexramAlignment.Text = "0";
            // 
            // sramOffset
            // 
            this.sramOffset.AutoSize = true;
            this.sramOffset.BackColor = System.Drawing.Color.Transparent;
            this.sramOffset.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sramOffset.ForeColor = System.Drawing.Color.White;
            this.sramOffset.Location = new System.Drawing.Point(104, 52);
            this.sramOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sramOffset.Name = "sramOffset";
            this.sramOffset.Size = new System.Drawing.Size(82, 23);
            this.sramOffset.TabIndex = 4;
            this.sramOffset.Text = "00000000";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(16, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 41);
            this.panel3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(201, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alignment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Offset";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Domain";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dolphin Savestate Info";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNetCoreConsole
            // 
            this.lbNetCoreConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbNetCoreConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNetCoreConsole.ForeColor = System.Drawing.Color.White;
            this.lbNetCoreConsole.FormattingEnabled = true;
            this.lbNetCoreConsole.ItemHeight = 16;
            this.lbNetCoreConsole.Location = new System.Drawing.Point(355, 41);
            this.lbNetCoreConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNetCoreConsole.Name = "lbNetCoreConsole";
            this.lbNetCoreConsole.Size = new System.Drawing.Size(775, 160);
            this.lbNetCoreConsole.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(351, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "NetCore Console info";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartNetCore
            // 
            this.btnStartNetCore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartNetCore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStartNetCore.FlatAppearance.BorderSize = 0;
            this.btnStartNetCore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartNetCore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStartNetCore.ForeColor = System.Drawing.Color.Black;
            this.btnStartNetCore.Location = new System.Drawing.Point(16, 16);
            this.btnStartNetCore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartNetCore.Name = "btnStartNetCore";
            this.btnStartNetCore.Size = new System.Drawing.Size(285, 39);
            this.btnStartNetCore.TabIndex = 22;
            this.btnStartNetCore.TabStop = false;
            this.btnStartNetCore.Tag = "color:light";
            this.btnStartNetCore.Text = "Start NetCore Server";
            this.btnStartNetCore.UseVisualStyleBackColor = false;
            this.btnStartNetCore.Click += new System.EventHandler(this.btnStartNetCore_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "NetCore Remote Dolphin Controller";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.btnStartNetCore);
            this.panel2.Location = new System.Drawing.Point(16, 261);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 117);
            this.panel2.TabIndex = 24;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(16, 74);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(168, 23);
            this.lbStatus.TabIndex = 23;
            this.lbStatus.Text = "Status: Disconnected";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadState
            // 
            this.btnLoadState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoadState.FlatAppearance.BorderSize = 0;
            this.btnLoadState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLoadState.ForeColor = System.Drawing.Color.Black;
            this.btnLoadState.Location = new System.Drawing.Point(19, 16);
            this.btnLoadState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadState.Name = "btnLoadState";
            this.btnLoadState.Size = new System.Drawing.Size(183, 39);
            this.btnLoadState.TabIndex = 24;
            this.btnLoadState.TabStop = false;
            this.btnLoadState.Tag = "color:light";
            this.btnLoadState.Text = "Load State";
            this.btnLoadState.UseVisualStyleBackColor = false;
            this.btnLoadState.Click += new System.EventHandler(this.btnLoadState_Click);
            // 
            // btnSaveState
            // 
            this.btnSaveState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveState.FlatAppearance.BorderSize = 0;
            this.btnSaveState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveState.Location = new System.Drawing.Point(19, 64);
            this.btnSaveState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveState.Name = "btnSaveState";
            this.btnSaveState.Size = new System.Drawing.Size(183, 39);
            this.btnSaveState.TabIndex = 25;
            this.btnSaveState.TabStop = false;
            this.btnSaveState.Tag = "color:light";
            this.btnSaveState.Text = "Save State";
            this.btnSaveState.UseVisualStyleBackColor = false;
            this.btnSaveState.Click += new System.EventHandler(this.btnSaveState_Click);
            // 
            // pnNetCoreActions
            // 
            this.pnNetCoreActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnNetCoreActions.Controls.Add(this.btnPokeBytes);
            this.pnNetCoreActions.Controls.Add(this.btnPeekBytes);
            this.pnNetCoreActions.Controls.Add(this.label8);
            this.pnNetCoreActions.Controls.Add(this.label7);
            this.pnNetCoreActions.Controls.Add(this.peekedValue);
            this.pnNetCoreActions.Controls.Add(this.valueNum);
            this.pnNetCoreActions.Controls.Add(this.addressNum);
            this.pnNetCoreActions.Controls.Add(this.btnPeekByte);
            this.pnNetCoreActions.Controls.Add(this.btnPokeByte);
            this.pnNetCoreActions.Controls.Add(this.btnLoadState);
            this.pnNetCoreActions.Controls.Add(this.btnSaveState);
            this.pnNetCoreActions.Location = new System.Drawing.Point(336, 261);
            this.pnNetCoreActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnNetCoreActions.Name = "pnNetCoreActions";
            this.pnNetCoreActions.Size = new System.Drawing.Size(793, 117);
            this.pnNetCoreActions.TabIndex = 18;
            // 
            // btnPokeBytes
            // 
            this.btnPokeBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPokeBytes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPokeBytes.FlatAppearance.BorderSize = 0;
            this.btnPokeBytes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokeBytes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPokeBytes.ForeColor = System.Drawing.Color.Black;
            this.btnPokeBytes.Location = new System.Drawing.Point(425, 16);
            this.btnPokeBytes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPokeBytes.Name = "btnPokeBytes";
            this.btnPokeBytes.Size = new System.Drawing.Size(183, 39);
            this.btnPokeBytes.TabIndex = 35;
            this.btnPokeBytes.TabStop = false;
            this.btnPokeBytes.Tag = "color:light";
            this.btnPokeBytes.Text = "Poke Bytes (4)";
            this.btnPokeBytes.UseVisualStyleBackColor = false;
            this.btnPokeBytes.Click += new System.EventHandler(this.btnPokeBytes_Click);
            // 
            // btnPeekBytes
            // 
            this.btnPeekBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPeekBytes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPeekBytes.FlatAppearance.BorderSize = 0;
            this.btnPeekBytes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeekBytes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPeekBytes.ForeColor = System.Drawing.Color.Black;
            this.btnPeekBytes.Location = new System.Drawing.Point(425, 63);
            this.btnPeekBytes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPeekBytes.Name = "btnPeekBytes";
            this.btnPeekBytes.Size = new System.Drawing.Size(183, 39);
            this.btnPeekBytes.TabIndex = 34;
            this.btnPeekBytes.TabStop = false;
            this.btnPeekBytes.Tag = "color:light";
            this.btnPeekBytes.Text = "Peek Bytes (4)";
            this.btnPeekBytes.UseVisualStyleBackColor = false;
            this.btnPeekBytes.Click += new System.EventHandler(this.btnPeekBytes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(643, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(628, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Address:";
            // 
            // peekedValue
            // 
            this.peekedValue.AutoSize = true;
            this.peekedValue.ForeColor = System.Drawing.Color.White;
            this.peekedValue.Location = new System.Drawing.Point(652, 85);
            this.peekedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.peekedValue.Name = "peekedValue";
            this.peekedValue.Size = new System.Drawing.Size(44, 17);
            this.peekedValue.TabIndex = 30;
            this.peekedValue.Text = "NULL";
            // 
            // valueNum
            // 
            this.valueNum.Location = new System.Drawing.Point(700, 46);
            this.valueNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valueNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.valueNum.Name = "valueNum";
            this.valueNum.Size = new System.Drawing.Size(89, 22);
            this.valueNum.TabIndex = 29;
            // 
            // addressNum
            // 
            this.addressNum.Location = new System.Drawing.Point(700, 14);
            this.addressNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressNum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.addressNum.Name = "addressNum";
            this.addressNum.Size = new System.Drawing.Size(89, 22);
            this.addressNum.TabIndex = 28;
            // 
            // btnPeekByte
            // 
            this.btnPeekByte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPeekByte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPeekByte.FlatAppearance.BorderSize = 0;
            this.btnPeekByte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeekByte.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPeekByte.ForeColor = System.Drawing.Color.Black;
            this.btnPeekByte.Location = new System.Drawing.Point(223, 63);
            this.btnPeekByte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPeekByte.Name = "btnPeekByte";
            this.btnPeekByte.Size = new System.Drawing.Size(183, 39);
            this.btnPeekByte.TabIndex = 27;
            this.btnPeekByte.TabStop = false;
            this.btnPeekByte.Tag = "color:light";
            this.btnPeekByte.Text = "Peek Byte";
            this.btnPeekByte.UseVisualStyleBackColor = false;
            this.btnPeekByte.Click += new System.EventHandler(this.btnPeekByte_Click);
            // 
            // btnPokeByte
            // 
            this.btnPokeByte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPokeByte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPokeByte.FlatAppearance.BorderSize = 0;
            this.btnPokeByte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokeByte.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPokeByte.ForeColor = System.Drawing.Color.Black;
            this.btnPokeByte.Location = new System.Drawing.Point(223, 16);
            this.btnPokeByte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPokeByte.Name = "btnPokeByte";
            this.btnPokeByte.Size = new System.Drawing.Size(183, 39);
            this.btnPokeByte.TabIndex = 26;
            this.btnPokeByte.TabStop = false;
            this.btnPokeByte.Tag = "color:light";
            this.btnPokeByte.Text = "Poke Byte";
            this.btnPokeByte.UseVisualStyleBackColor = false;
            this.btnPokeByte.Click += new System.EventHandler(this.btnPokeByte_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(351, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Debug ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WGH_SavestateInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1145, 404);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnNetCoreActions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNetCoreConsole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "WGH_SavestateInfoForm";
            this.Text = "Dolphin Savestate Info";
            this.Load += new System.EventHandler(this.WGH_SavestateInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnNetCoreActions.ResumeLayout(false);
            this.pnNetCoreActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sramLabel;
        private System.Windows.Forms.Label aramexramLabel;
        private System.Windows.Forms.Label aramexramOffset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sramAlignment;
        private System.Windows.Forms.Label aramexramAlignment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sramOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox lbNetCoreConsole;
        public System.Windows.Forms.Button btnStartNetCore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnLoadState;
        private System.Windows.Forms.Button btnSaveState;
        private System.Windows.Forms.Panel pnNetCoreActions;
        public System.Windows.Forms.Button btnPeekByte;
        public System.Windows.Forms.Button btnPokeByte;
        public System.Windows.Forms.NumericUpDown valueNum;
        public System.Windows.Forms.NumericUpDown addressNum;
        public System.Windows.Forms.Label peekedValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnPokeBytes;
        public System.Windows.Forms.Button btnPeekBytes;
        public System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label9;
    }
}