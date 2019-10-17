using System;
using System.Drawing;
using ExtensionMethods;
using System.Windows.Forms;

namespace SerialConnect
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.IDCOPY = new System.Windows.Forms.Button();
            this.pro = new System.Windows.Forms.Button();
            this.numbertires = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel21 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.RRL2 = new System.Windows.Forms.TextBox();
            this.RRI2 = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.RRL1 = new System.Windows.Forms.Label();
            this.RRI1 = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.RRC = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.RFL2 = new System.Windows.Forms.Label();
            this.RFI2 = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.RFL1 = new System.Windows.Forms.TextBox();
            this.RFI1 = new System.Windows.Forms.PictureBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.RFC = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LFC = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LFI1 = new System.Windows.Forms.PictureBox();
            this.LFL1 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LFI2 = new System.Windows.Forms.PictureBox();
            this.LFL2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.LRC = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.LRI1 = new System.Windows.Forms.PictureBox();
            this.LRL1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.LRI2 = new System.Windows.Forms.PictureBox();
            this.LRL2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3.SuspendLayout();
            this.panel22.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RRI2)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RRI1)).BeginInit();
            this.panel15.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RRC)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RFI2)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RFI1)).BeginInit();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RFC)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LFC)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LFI1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LFI2)).BeginInit();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LRC)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LRI1)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LRI2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.IDCOPY);
            this.panel3.Controls.Add(this.pro);
            this.panel3.Controls.Add(this.numbertires);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(538, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 457);
            this.panel3.TabIndex = 15;
            // 
            // IDCOPY
            // 
            this.IDCOPY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IDCOPY.BackgroundImage = global::SerialConnect.Properties.Resources.whitw;
            this.IDCOPY.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IDCOPY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.IDCOPY.Image = global::SerialConnect.Properties.Resources.whitw;
            this.IDCOPY.Location = new System.Drawing.Point(118, 334);
            this.IDCOPY.Margin = new System.Windows.Forms.Padding(0);
            this.IDCOPY.Name = "IDCOPY";
            this.IDCOPY.Size = new System.Drawing.Size(105, 40);
            this.IDCOPY.TabIndex = 16;
            this.IDCOPY.Text = "ID COPY";
            this.IDCOPY.UseVisualStyleBackColor = true;
            this.IDCOPY.Click += new System.EventHandler(this.IDCOPY_Click);
            // 
            // pro
            // 
            this.pro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pro.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pro.ForeColor = System.Drawing.Color.White;
            this.pro.Image = global::SerialConnect.Properties.Resources.button_normal;
            this.pro.Location = new System.Drawing.Point(8, 334);
            this.pro.Margin = new System.Windows.Forms.Padding(0);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(105, 40);
            this.pro.TabIndex = 15;
            this.pro.Text = "Program";
            this.pro.UseVisualStyleBackColor = true;
            this.pro.Click += new System.EventHandler(this.Pro_Click_1);
            // 
            // numbertires
            // 
            this.numbertires.BackgroundImage = global::SerialConnect.Properties.Resources.img_Drop_down_menu_gray;
            this.numbertires.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numbertires.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.numbertires.FlatAppearance.BorderSize = 0;
            this.numbertires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numbertires.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numbertires.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numbertires.Location = new System.Drawing.Point(13, 188);
            this.numbertires.Name = "numbertires";
            this.numbertires.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.numbertires.Size = new System.Drawing.Size(210, 44);
            this.numbertires.TabIndex = 14;
            this.numbertires.TabStop = false;
            this.numbertires.Text = "Number of tires";
            this.numbertires.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.numbertires.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::SerialConnect.Properties.Resources.img_Drop_down_menu_Blue;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(13, 135);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(210, 44);
            this.button6.TabIndex = 13;
            this.button6.TabStop = false;
            this.button6.Text = "Year";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::SerialConnect.Properties.Resources.img_Drop_down_menu_Blue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(13, 85);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(210, 44);
            this.button5.TabIndex = 10;
            this.button5.TabStop = false;
            this.button5.Text = "Model";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SerialConnect.Properties.Resources.img_Drop_down_menu_Blue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(13, 35);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(210, 44);
            this.button4.TabIndex = 9;
            this.button4.TabStop = false;
            this.button4.Text = "Maker";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackgroundImage = global::SerialConnect.Properties.Resources.button_Locked;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(8, 377);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(29, 0, 20, 0);
            this.button1.Size = new System.Drawing.Size(215, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 27);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicle Selection";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(13, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(210, 27);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged_1);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(13, 148);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(210, 27);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.ComboBox4_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel21
            // 
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(774, 549);
            this.panel21.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "label10";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel22.Controls.Add(this.tableLayoutPanel10);
            this.panel22.Location = new System.Drawing.Point(320, 252);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(160, 97);
            this.panel22.TabIndex = 15;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(80)))), ((int)(((byte)(8)))));
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(160, 97);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox4.Image = global::SerialConnect.Properties.Resources.gif_load;
            this.pictureBox4.Location = new System.Drawing.Point(20, 24);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(20, 3, 20, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Progamming";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel12, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(529, 318);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel9);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(193, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 312);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 277);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(142, 35);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::SerialConnect.Properties.Resources.img_car;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 238);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.tableLayoutPanel6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(341, 15);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 15, 3, 20);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(185, 283);
            this.panel12.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.panel13, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.panel14, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.panel15, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.panel16, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel18, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 15, 3, 20);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(185, 283);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel13.Controls.Add(this.RRL2);
            this.panel13.Controls.Add(this.RRI2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(3, 238);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 3, 33, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(149, 42);
            this.panel13.TabIndex = 5;
            // 
            // RRL2
            // 
            this.RRL2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RRL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.RRL2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RRL2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RRL2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RRL2.Location = new System.Drawing.Point(14, 10);
            this.RRL2.Name = "RRL2";
            this.RRL2.Size = new System.Drawing.Size(120, 15);
            this.RRL2.TabIndex = 5;
            this.RRL2.Tag = "RR";
            this.RRL2.Text = "Original sensor ID";
            this.RRL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RRI2
            // 
            this.RRI2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RRI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RRI2.Dock = System.Windows.Forms.DockStyle.Left;
            this.RRI2.Image = global::SerialConnect.Properties.Resources.img_rectangle_gray;
            this.RRI2.Location = new System.Drawing.Point(0, 0);
            this.RRI2.Name = "RRI2";
            this.RRI2.Size = new System.Drawing.Size(149, 42);
            this.RRI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RRI2.TabIndex = 2;
            this.RRI2.TabStop = false;
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel14.Controls.Add(this.RRL1);
            this.panel14.Controls.Add(this.RRI1);
            this.panel14.Location = new System.Drawing.Point(3, 191);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 3, 33, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(149, 41);
            this.panel14.TabIndex = 4;
            // 
            // RRL1
            // 
            this.RRL1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RRL1.BackColor = System.Drawing.Color.Transparent;
            this.RRL1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RRL1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RRL1.Location = new System.Drawing.Point(0, 0);
            this.RRL1.Name = "RRL1";
            this.RRL1.Size = new System.Drawing.Size(149, 41);
            this.RRL1.TabIndex = 4;
            this.RRL1.Text = "New sensor ID";
            this.RRL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RRI1
            // 
            this.RRI1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RRI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RRI1.Image = global::SerialConnect.Properties.Resources.img_rectangle_gray;
            this.RRI1.Location = new System.Drawing.Point(0, 0);
            this.RRI1.Name = "RRI1";
            this.RRI1.Size = new System.Drawing.Size(149, 41);
            this.RRI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RRI1.TabIndex = 2;
            this.RRI1.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel15.Controls.Add(this.tableLayoutPanel7);
            this.panel15.Location = new System.Drawing.Point(3, 144);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(179, 41);
            this.panel15.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.RRC, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(179, 41);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.label7.Location = new System.Drawing.Point(38, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 41);
            this.label7.TabIndex = 3;
            this.label7.Text = "3. RR (right rear)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RRC
            // 
            this.RRC.BackgroundImage = global::SerialConnect.Properties.Resources.icon_Round_normal;
            this.RRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RRC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RRC.Location = new System.Drawing.Point(3, 3);
            this.RRC.Name = "RRC";
            this.RRC.Padding = new System.Windows.Forms.Padding(5);
            this.RRC.Size = new System.Drawing.Size(29, 35);
            this.RRC.TabIndex = 2;
            this.RRC.TabStop = false;
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel16.Controls.Add(this.RFL2);
            this.panel16.Controls.Add(this.RFI2);
            this.panel16.Location = new System.Drawing.Point(3, 50);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 3, 33, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(149, 41);
            this.panel16.TabIndex = 1;
            // 
            // RFL2
            // 
            this.RFL2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RFL2.BackColor = System.Drawing.Color.Transparent;
            this.RFL2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RFL2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RFL2.Location = new System.Drawing.Point(3, 0);
            this.RFL2.Name = "RFL2";
            this.RFL2.Size = new System.Drawing.Size(149, 41);
            this.RFL2.TabIndex = 4;
            this.RFL2.Text = "New sensor ID";
            this.RFL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RFI2
            // 
            this.RFI2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RFI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RFI2.Image = global::SerialConnect.Properties.Resources.img_rectangle_gray;
            this.RFI2.Location = new System.Drawing.Point(0, 0);
            this.RFI2.Name = "RFI2";
            this.RFI2.Size = new System.Drawing.Size(149, 41);
            this.RFI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RFI2.TabIndex = 2;
            this.RFI2.TabStop = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel17.Controls.Add(this.RFL1);
            this.panel17.Controls.Add(this.RFI1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 3, 33, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(149, 41);
            this.panel17.TabIndex = 0;
            // 
            // RFL1
            // 
            this.RFL1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RFL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.RFL1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RFL1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RFL1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RFL1.Location = new System.Drawing.Point(15, 9);
            this.RFL1.Name = "RFL1";
            this.RFL1.Size = new System.Drawing.Size(120, 15);
            this.RFL1.TabIndex = 5;
            this.RFL1.Tag = "RF";
            this.RFL1.Text = "Original sensor ID";
            this.RFL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RFL1.WordWrap = false;
            // 
            // RFI1
            // 
            this.RFI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RFI1.Dock = System.Windows.Forms.DockStyle.Left;
            this.RFI1.Image = global::SerialConnect.Properties.Resources.img_rectangle_gray;
            this.RFI1.Location = new System.Drawing.Point(0, 0);
            this.RFI1.Name = "RFI1";
            this.RFI1.Size = new System.Drawing.Size(149, 41);
            this.RFI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RFI1.TabIndex = 1;
            this.RFI1.TabStop = false;
            // 
            // panel18
            // 
            this.panel18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Location = new System.Drawing.Point(3, 97);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(179, 41);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel19.Controls.Add(this.tableLayoutPanel8);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(179, 41);
            this.panel19.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.RFC, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(179, 41);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.label8.Location = new System.Drawing.Point(38, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 41);
            this.label8.TabIndex = 3;
            this.label8.Text = "2. RF (right front)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RFC
            // 
            this.RFC.BackgroundImage = global::SerialConnect.Properties.Resources.icon_Round_normal;
            this.RFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RFC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RFC.Location = new System.Drawing.Point(3, 3);
            this.RFC.Name = "RFC";
            this.RFC.Padding = new System.Windows.Forms.Padding(5);
            this.RFC.Size = new System.Drawing.Size(29, 35);
            this.RFC.TabIndex = 2;
            this.RFC.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(529, 44);
            this.panel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(529, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vehicle Selection, please select Make, Model, Year, tire position, \r\nand then cli" +
    "ck \"Next\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 457);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 377);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(529, 77);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(529, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Relearn Procedure";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(529, 49);
            this.textBox1.TabIndex = 1;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.panel20.Controls.Add(this.label11);
            this.panel20.Controls.Add(this.pictureBox5);
            this.panel20.Location = new System.Drawing.Point(151, 600);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(498, 234);
            this.panel20.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(59, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(379, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Please connect with Scanner and USB PAD or LF PAD.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::SerialConnect.Properties.Resources.img_Tool_connection_prompt;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(498, 234);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 4);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SerialConnect.Properties.Resources.backorange;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::SerialConnect.Properties.Resources.img_Drop_down_menu_Blue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(538, 56);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 13;
            this.button2.TabStop = false;
            this.button2.Text = "USB PAD";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SerialConnect.Properties.Resources.orange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(152, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 56, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Orange TPMS Programming System";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::SerialConnect.Properties.Resources.backorange;
            this.pictureBox3.Image = global::SerialConnect.Properties.Resources.icon_scanner;
            this.pictureBox3.Location = new System.Drawing.Point(692, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Controls.Add(this.tableLayoutPanel4);
            this.panel8.Location = new System.Drawing.Point(3, 97);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(178, 41);
            this.panel8.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.LFC, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(178, 41);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // LFC
            // 
            this.LFC.BackgroundImage = global::SerialConnect.Properties.Resources.icon_Round_normal;
            this.LFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LFC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LFC.Location = new System.Drawing.Point(146, 3);
            this.LFC.Name = "LFC";
            this.LFC.Padding = new System.Windows.Forms.Padding(5);
            this.LFC.Size = new System.Drawing.Size(29, 35);
            this.LFC.TabIndex = 1;
            this.LFC.TabStop = false;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "1. LF (left front)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.LFL1);
            this.panel6.Controls.Add(this.LFI1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(33, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(33, 3, 3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(148, 41);
            this.panel6.TabIndex = 0;
            // 
            // LFI1
            // 
            this.LFI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LFI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LFI1.Image = global::SerialConnect.Properties.Resources.img_rectangle_gray;
            this.LFI1.Location = new System.Drawing.Point(0, 0);
            this.LFI1.Name = "LFI1";
            this.LFI1.Size = new System.Drawing.Size(148, 41);
            this.LFI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LFI1.TabIndex = 4;
            this.LFI1.TabStop = false;
            // 
            // LFL1
            // 
            this.LFL1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LFL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.LFL1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LFL1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LFL1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LFL1.Location = new System.Drawing.Point(15, 9);
            this.LFL1.Name = "LFL1";
            this.LFL1.Size = new System.Drawing.Size(120, 15);
            this.LFL1.TabIndex = 3;
            this.LFL1.Tag = "LF";
            this.LFL1.Text = "Original sensor ID";
            this.LFL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.LFL2);
            this.panel7.Controls.Add(this.LFI2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(33, 50);
            this.panel7.Margin = new System.Windows.Forms.Padding(33, 3, 3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(148, 41);
            this.panel7.TabIndex = 1;
            // 
            // LFI2
            // 
            this.LFI2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LFI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LFI2.Dock = System.Windows.Forms.DockStyle.Right;
            this.LFI2.Image = global::SerialConnect.Properties.Resources.img_rectangle_gray;
            this.LFI2.Location = new System.Drawing.Point(-1, 0);
            this.LFI2.Name = "LFI2";
            this.LFI2.Size = new System.Drawing.Size(149, 41);
            this.LFI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LFI2.TabIndex = 2;
            this.LFI2.TabStop = false;
            // 
            // LFL2
            // 
            this.LFL2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LFL2.BackColor = System.Drawing.Color.Transparent;
            this.LFL2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LFL2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LFL2.Location = new System.Drawing.Point(0, 0);
            this.LFL2.Name = "LFL2";
            this.LFL2.Size = new System.Drawing.Size(149, 41);
            this.LFL2.TabIndex = 3;
            this.LFL2.Text = "New sensor ID";
            this.LFL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Controls.Add(this.tableLayoutPanel5);
            this.panel9.Location = new System.Drawing.Point(3, 144);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(178, 41);
            this.panel9.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.Controls.Add(this.LRC, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(178, 41);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "4. LR (left rear)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LRC
            // 
            this.LRC.BackgroundImage = global::SerialConnect.Properties.Resources.icon_Round_normal;
            this.LRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LRC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LRC.Location = new System.Drawing.Point(146, 3);
            this.LRC.Name = "LRC";
            this.LRC.Padding = new System.Windows.Forms.Padding(5);
            this.LRC.Size = new System.Drawing.Size(29, 35);
            this.LRC.TabIndex = 2;
            this.LRC.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel10.Controls.Add(this.LRL1);
            this.panel10.Controls.Add(this.LRI1);
            this.panel10.Location = new System.Drawing.Point(33, 191);
            this.panel10.Margin = new System.Windows.Forms.Padding(33, 3, 3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(148, 41);
            this.panel10.TabIndex = 4;
            // 
            // LRI1
            // 
            this.LRI1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LRI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LRI1.Dock = System.Windows.Forms.DockStyle.Right;
            this.LRI1.Image = global::SerialConnect.Properties.Resources.img_rectangle_gray;
            this.LRI1.Location = new System.Drawing.Point(-1, 0);
            this.LRI1.Name = "LRI1";
            this.LRI1.Size = new System.Drawing.Size(149, 41);
            this.LRI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LRI1.TabIndex = 2;
            this.LRI1.TabStop = false;
            // 
            // LRL1
            // 
            this.LRL1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LRL1.BackColor = System.Drawing.Color.Transparent;
            this.LRL1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LRL1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LRL1.Location = new System.Drawing.Point(0, 0);
            this.LRL1.Name = "LRL1";
            this.LRL1.Size = new System.Drawing.Size(149, 41);
            this.LRL1.TabIndex = 4;
            this.LRL1.Text = "New sensor ID";
            this.LRL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel11.Controls.Add(this.LRL2);
            this.panel11.Controls.Add(this.LRI2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(33, 238);
            this.panel11.Margin = new System.Windows.Forms.Padding(33, 3, 3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(148, 42);
            this.panel11.TabIndex = 5;
            // 
            // LRI2
            // 
            this.LRI2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LRI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LRI2.Dock = System.Windows.Forms.DockStyle.Right;
            this.LRI2.Image = global::SerialConnect.Properties.Resources.img_rectangle_gray;
            this.LRI2.Location = new System.Drawing.Point(-1, 0);
            this.LRI2.Name = "LRI2";
            this.LRI2.Size = new System.Drawing.Size(149, 42);
            this.LRI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LRI2.TabIndex = 2;
            this.LRI2.TabStop = false;
            // 
            // LRL2
            // 
            this.LRL2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LRL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.LRL2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LRL2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LRL2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LRL2.Location = new System.Drawing.Point(14, 10);
            this.LRL2.Name = "LRL2";
            this.LRL2.Size = new System.Drawing.Size(120, 15);
            this.LRL2.TabIndex = 4;
            this.LRL2.Tag = "LR";
            this.LRL2.Text = "Original sensor ID";
            this.LRL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel11, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.panel10, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.panel9, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(184, 283);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB TPMS";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RRI2)).EndInit();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RRI1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RRC)).EndInit();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RFI2)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RFI1)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RFC)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LFC)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LFI1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LFI2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LRC)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LRI1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LRI2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private Button button5;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button6;
        private Button numbertires;
        private ContextMenuStrip contextMenuStrip1;
        public void ChangrParent() {
            this.LFL2.Parent = LFI2;
            this.RFL2.Parent = RFI2;
            this.LRL1.Parent = LRI1;
            this.RRL1.Parent = RRI1;
        }
      
        public void ResizeTextBox(TextBox box, PictureBox pictureBox)
        {
            int size = this.Width / 800 * 124;
            if (size == 0) { return; }
            box.Width = size;
            int fsize = this.Width / 800 * 9;
            if (size == 0) { return; }
            box.Font = new Font("微軟正黑體", fsize, FontStyle.Bold);
            int y = (pictureBox.Height - box.Height) / 2;
            int x = (pictureBox.Width - box.Width) / 2;
            box.Location = new System.Drawing.Point(x, y);
        }
        public void ResizPanel(Panel panel, int re)
        {
            int size = this.Width / 800 * re;
            if (size == 0) { return; }
            panel.Width = size;
        }
        public void ResizeColume(TableLayoutPanel tb, int re, int position)
        {
            TableLayoutColumnStyleCollection styles =
   tb.ColumnStyles;
            styles[position].SizeType = SizeType.Absolute;
            styles[position].Width = this.Width / 800 * re;
        }
        public void ResizePt(PictureBox x, int re)
        {
            int size = this.Width / 800 * re;
            if (size == 0) { return; }
            x.Width = size;
        }
        public void ResizeText(Label x,int f)
        {
            int size = this.Width / 800 * f;
            if (size == 0) { return; }
            x.Font = new Font("微軟正黑體", size, FontStyle.Bold);
        }
        public void ResizeBig(Panel x,int re,int hei)
        {
            int size = this.Width / 800 * re;
            int hi = this.Width / 800 * hei;
            if (size == 0) { return; }
            x.Width = size;
            x.Height = hi;
            x.Location = new System.Drawing.Point((Width - size)/2, (Height-hi)/2);
        }
        public void repaint() {
            ResizeText(label8,10);
            ResizeText(label7, 10);
            ResizeText(label6, 10);
            ResizeText(label5, 10);
            ResizeText(label3, 10);
          
            ResizeText(LFL2, 10);
            ResizeText(RFL2, 10);
            ResizeText(LRL1, 10);
            ResizeText(RRL1, 10);
            ResizePt(RFI1, 149);
            ResizePt(RFI2, 149);
            ResizePt(RRI1, 149);
            ResizePt(RRI2, 149);
            ResizePt(LRI2, 149);
            ResizePt(LRI1, 149);
            ResizePt(LFI2, 149);
            ResizePt(LFI1, 149);
            ResizeColume(tableLayoutPanel8, 35, 0);
            ResizeColume(tableLayoutPanel7, 35, 0);
            ResizeColume(tableLayoutPanel5, 35, 1);
            ResizeColume(tableLayoutPanel4, 35, 1);
            ResizPanel(panel7, 149);
            ResizPanel(panel6, 149);
            ResizPanel(panel11, 149);
            ResizPanel(panel17, 149);
            ResizPanel(panel13, 149);
            ResizeTextBox(RFL1, RFI1);
            ResizeTextBox(LFL1, LFI1);
            ResizeTextBox(LRL2, LRI2);
            ResizeTextBox(RRL2, RRI2);
            ResizeBig(panel22, 160, 97);
            ResizeText(label4, 12);
            ResizeBig(panel20, 498, 234);
            ResizeText(label11, 11);
            label11.Location = new System.Drawing.Point((panel20.Width - label11.Width) / 2,label11.Location.Y);
        }
        public void UpdateUi(int position, int situation)
        {

            switch (position)
            {
                case LF:
                    LFC.BackgroundImage = Properties.Resources.icon_Round_normal;
                    switch (situation)
                    {
                        case UN_LINK:
                            LFL2.Text = Language.setlan(48);
                            LFL1.Text = "";
                            LFI1.Image = Properties.Resources.img_rectangle_gray;
                            LFL1.BackColor = Color.FromArgb(181, 182, 182);
                            LFI2.Image = Properties.Resources.img_rectangle_gray;
                            LFL1.Enabled = false;
                            break;
                        case PROGRAM_SUCCESS:
                            LFL2.Text = Lfid;
                            LFI2.Image = Properties.Resources.img_rectangle_Green;
                            LFC.BackgroundImage = Properties.Resources.icon_Round_OK;
                            break;
                        case PROGRAM_FAULSE:
                            LFL2.Text = Lfid;
                            LFI2.Image = Properties.Resources.img_rectangle_error;
                            LFC.BackgroundImage = Properties.Resources.icon_Round_error;
                            break;
                        case PROGRAM_WAIT:
                            LFL2.Text = Lfid;
                            LFI2.Image = Properties.Resources.img_rectangle_Blue;
                            LFI1.Image = Properties.Resources.img_rectangle_white;
                            LFL1.Enabled = true;
                            LFL1.ForeColor = Color.FromArgb(2, 56, 86);
                            LFL1.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                    }
                    break;
                case RF:
                    RFC.BackgroundImage = Properties.Resources.icon_Round_normal;
                    switch (situation)
                    {
                        case UN_LINK:
                            RFL2.Text = Language.setlan(48);
                            RFL1.Text = "";
                            RFI1.Image = Properties.Resources.img_rectangle_gray;
                            RFL1.BackColor = Color.FromArgb(181, 182, 182);
                            RFI2.Image = Properties.Resources.img_rectangle_gray;
                            RFL1.Enabled = false;
                            break;
                        case PROGRAM_SUCCESS:
                            RFL2.Text = Rfid;
                            RFI2.Image = Properties.Resources.img_rectangle_Green;
                            RFC.BackgroundImage = Properties.Resources.icon_Round_OK;
                            break;
                        case PROGRAM_FAULSE:
                            RFL2.Text = Rfid;
                            RFI2.Image = Properties.Resources.img_rectangle_error;
                            RFC.BackgroundImage = Properties.Resources.icon_Round_error;
                            break;
                        case PROGRAM_WAIT:
                            RFL2.Text = Rfid;
                            RFI2.Image = Properties.Resources.img_rectangle_Blue;
                            RFI1.Image = Properties.Resources.img_rectangle_white;
                            RFL1.Enabled = true;
                            RFL1.ForeColor = Color.FromArgb(2, 56, 86);
                            RFL1.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                    }
                    break;
                case LR:
                    LRC.BackgroundImage = Properties.Resources.icon_Round_normal;
                    switch (situation)
                    {
                        case UN_LINK:
                            LRL1.Text = Language.setlan(48);
                            LRL2.Text = "";
                            LRI2.Image = Properties.Resources.img_rectangle_gray;
                            LRL2.BackColor = Color.FromArgb(181, 182, 182);
                            LRI1.Image = Properties.Resources.img_rectangle_gray;
                            LRL2.Enabled = false;
                            break;
                        case PROGRAM_SUCCESS:
                            LRL1.Text = Lrid;
                            LRI1.Image = Properties.Resources.img_rectangle_Green;
                            LRC.BackgroundImage = Properties.Resources.icon_Round_OK;
                            break;
                        case PROGRAM_FAULSE:
                            LRL1.Text = Lrid;
                            LRI1.Image = Properties.Resources.img_rectangle_error;
                            LRC.BackgroundImage = Properties.Resources.icon_Round_error;
                            break;
                        case PROGRAM_WAIT:
                            LRL1.Text = Lrid;
                            LRI1.Image = Properties.Resources.img_rectangle_Blue;
                            LRI2.Image = Properties.Resources.img_rectangle_white;
                            LRL2.Enabled = true;
                            LRL2.ForeColor = Color.FromArgb(2, 56, 86);
                            LRL2.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                    }
                    break;
                case RR:
                    RRC.BackgroundImage = Properties.Resources.icon_Round_normal;
                    switch (situation)
                    {
                        case UN_LINK:
                            RRL1.Text = Language.setlan(48);
                            RRL2.Text = "";
                            RRI2.Image = Properties.Resources.img_rectangle_gray;
                            RRL2.BackColor = Color.FromArgb(181, 182, 182);
                            RRI1.Image = Properties.Resources.img_rectangle_gray;
                            RRL2.Enabled = false;
                            break;
                        case PROGRAM_SUCCESS:
                            RRL1.Text = Rrid;
                            RRI1.Image = Properties.Resources.img_rectangle_Green;
                            RRC.BackgroundImage = Properties.Resources.icon_Round_OK;
                            break;
                        case PROGRAM_FAULSE:
                            RRL1.Text = Rrid;
                            RRI1.Image = Properties.Resources.img_rectangle_error;
                            RRC.BackgroundImage = Properties.Resources.icon_Round_error;
                            break;
                        case PROGRAM_WAIT:
                            RRL1.Text = Rrid;
                            RRI1.Image = Properties.Resources.img_rectangle_Blue;
                            RRI2.Image = Properties.Resources.img_rectangle_white;
                            RRL2.Enabled = true;
                            RRL2.ForeColor = Color.FromArgb(2, 56, 86);
                            RRL2.BackColor = Color.FromArgb(255, 255, 255);
                            break;
                    }
                    break;
            }
        }
        public void ISid(bool a) {
            if (a) {
                panel6.Visible = true;
                panel17.Visible = true;
                panel11.Visible = true;
                panel13.Visible = true;
            } else {
                panel6.Visible = false;
                panel17.Visible = false;
                panel11.Visible = false;
                panel13.Visible = false;
            }
        }
        public void ProgramBacker(bool Condition)
        {
            ISPROGRAMMING = false;
            for (int i = 0; i < command.CHANNEL_BLE.Count; i++)
            {
                string a = command.CHANNEL_BLE[i].ToString();
                if (a.substring(0, 2).Equals("04"))
                {
                    Rrid = Getid(a);
                
                    UpdateUi(RR, PROGRAM_SUCCESS);
                }
                if (a.substring(0, 2).Equals("03"))
                {
                    Rfid = Getid(a);
                    UpdateUi(RF, PROGRAM_SUCCESS);
                }
                if (a.substring(0, 2).Equals("02"))
                {
                    Lrid = Getid(a);
                    UpdateUi(LR, PROGRAM_SUCCESS);
                }
                if (a.substring(0, 2).Equals("01"))
                {
                    Lfid = Getid(a);
                    UpdateUi(LF, PROGRAM_SUCCESS);
                }
            }
            UpdateUiCondition(PROGRAM_SUCCESS);
            if (!Condition)
            {
                foreach (string a in command.FALSE_CHANNEL)
                {
                    UpdateUiCondition(PROGRAM_FAULSE);
                    switch (a)
                    {
                        case "04":
                            Rrid = "error";
                            UpdateUi(RR, PROGRAM_FAULSE);
                            break;
                        case "03":
                            Rfid = "error";
                            UpdateUi(RF, PROGRAM_FAULSE);
                            break;
                        case "02":
                            Lrid = "error";
                            UpdateUi(LR, PROGRAM_FAULSE);
                            break;
                        case "01":
                            Lfid = "error";
                            UpdateUi(LF, PROGRAM_FAULSE);
                            break;
                    }
                }
                foreach (string a in command.BLANK_CHANNEL)
                {
                    switch (a)
                    {
                        case "04":
                            UpdateUi(RR, UN_LINK);
                            break;
                        case "03":
                            UpdateUi(RF, UN_LINK);
                            break;
                        case "02":
                            UpdateUi(LR, UN_LINK);
                            break;
                        case "01":
                            UpdateUi(LF, UN_LINK);
                            break;
                    }
                }
                if (command.FALSE_CHANNEL.Count == 0 && command.BLANK_CHANNEL.Count == 0)
                {
                    UpdateUiCondition(PROGRAM_FAULSE);
                    UpdateUi(LF, PROGRAM_FAULSE);
                    UpdateUi(LR, PROGRAM_FAULSE);
                    UpdateUi(RF, PROGRAM_FAULSE);
                    UpdateUi(RR, PROGRAM_FAULSE);
                }
            }
         
          
        }
        public string Getid(string a)
        {
            string id = a.substring(3, a.Length);
            if (mmynum == "RN1628" || mmynum == "SI2048")
            {
                string Writetmp = id.substring(0, 2) + "XX" + id.substring(4, 6) + "YY";
                id = Writetmp.Replace("XX", id.substring(6, 8)).Replace("YY", id.substring(2, 4));
            }
            id = id.substring(8 - idcount, 8);
            return id;
        }

        public void UpdateUiCondition(int position) {
            pause();
            switch (position)
            {
                case PROGRAN_INSERT:
                    label3.Text = Language.setlan(46);
                    label3.BackColor = Color.FromArgb(31, 73, 106);
                    label3.ForeColor = Color.FromArgb(255,222,0);
                    break;
                case PROGRAM_SUCCESS:
                    label3.Text = Language.setlan(26);
                    label3.BackColor = Color.FromArgb(37, 155, 36);
                    label3.ForeColor = Color.White;
                    break;
                case PROGRAM_WAIT:
                    label3.Text = Language.setlan(22);
                    label3.BackColor = Color.FromArgb(37, 73, 106);
                    label3.ForeColor = Color.FromArgb(255, 222, 0);
                    break;
                case PROGRAM_FAULSE:
                    label3.Text = Language.setlan(27);
                    label3.BackColor = Color.FromArgb(229, 28, 35);
                    label3.ForeColor = Color.White;
                    break;
                case PROGRAMMING:
                    label3.Text = Language.setlan(25);
                    label3.BackColor = Color.FromArgb(31, 73, 106);
                    label3.ForeColor = Color.FromArgb(255, 222, 0);
                    play("Programming");
                    break;
            }

        }
        public void setla()
        {
            label5.Text= Language.setlan(15);
            label6.Text = Language.setlan(14);
            label7.Text = Language.setlan(13);
            label8.Text = Language.setlan(12);
            label1.Text = Language.setlan(1);
            label2.Text = Language.setlan(6);
            label11.Text = Language.setlan(31);
            label9.Text = Language.setlan(44);
            button1.Text= Language.setlan(45);
        }
        private Panel panel21;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Panel panel1;
        private Label label10;
        private Button IDCOPY;
        private Button pro;
        private Panel panel22;
        private TableLayoutPanel tableLayoutPanel10;
        private PictureBox pictureBox4;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel9;
        private PictureBox pictureBox2;
        private Panel panel12;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel13;
        private TextBox RRL2;
        private PictureBox RRI2;
        private Panel panel14;
        private Label RRL1;
        private PictureBox RRI1;
        private Panel panel15;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label7;
        private PictureBox RRC;
        private Panel panel18;
        private Panel panel19;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label8;
        private PictureBox RFC;
        private Panel panel5;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label9;
        public TextBox textBox1;
        private Panel panel20;
        private Label label11;
        private PictureBox pictureBox5;
        private Panel panel17;
        private PictureBox RFI1;
        private TextBox RFL1;
        private Panel panel16;
        private Label RFL2;
        private PictureBox RFI2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel11;
        private TextBox LRL2;
        private PictureBox LRI2;
        private Panel panel10;
        private Label LRL1;
        private PictureBox LRI1;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox LRC;
        private Label label6;
        private Panel panel7;
        private Label LFL2;
        private PictureBox LFI2;
        private Panel panel6;
        private TextBox LFL1;
        private PictureBox LFI1;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private PictureBox LFC;
    }
 
}

