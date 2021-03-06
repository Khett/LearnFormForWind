﻿namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnCreatePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPassLenght = new System.Windows.Forms.NumericUpDown();
            this.clbPassTypeCheck = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnRandomCopy = new System.Windows.Forms.Button();
            this.btnRandomClear = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudto = new System.Windows.Forms.NumericUpDown();
            this.nudfrom = new System.Windows.Forms.NumericUpDown();
            this.lblrandom = new System.Windows.Forms.Label();
            this.btngo = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.cbMetric = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLenght)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfrom)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.notepadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(173, 22);
            this.tsmiAbout.Text = "About MyProgram";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiInsertDate.Size = new System.Drawing.Size(152, 22);
            this.tsmiInsertDate.Text = "Insert Date";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiInsertTime
            // 
            this.tsmiInsertTime.Name = "tsmiInsertTime";
            this.tsmiInsertTime.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsmiInsertTime.Size = new System.Drawing.Size(152, 22);
            this.tsmiInsertTime.Text = "Insert Time";
            this.tsmiInsertTime.Click += new System.EventHandler(this.tsmiInsertTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(152, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.Size = new System.Drawing.Size(152, 22);
            this.tsmiLoad.Text = "Load";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 415);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbPass);
            this.tabPage4.Controls.Add(this.btnCreatePass);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.nudPassLenght);
            this.tabPage4.Controls.Add(this.clbPassTypeCheck);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(530, 389);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PasswordGenerator";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(19, 129);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(299, 20);
            this.tbPass.TabIndex = 4;
            // 
            // btnCreatePass
            // 
            this.btnCreatePass.Location = new System.Drawing.Point(188, 91);
            this.btnCreatePass.Name = "btnCreatePass";
            this.btnCreatePass.Size = new System.Drawing.Size(130, 20);
            this.btnCreatePass.TabIndex = 3;
            this.btnCreatePass.Text = "Generate now";
            this.btnCreatePass.UseVisualStyleBackColor = true;
            this.btnCreatePass.Click += new System.EventHandler(this.btnCreatePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lenght Pass";
            // 
            // nudPassLenght
            // 
            this.nudPassLenght.Location = new System.Drawing.Point(91, 91);
            this.nudPassLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPassLenght.Name = "nudPassLenght";
            this.nudPassLenght.Size = new System.Drawing.Size(86, 20);
            this.nudPassLenght.TabIndex = 1;
            this.nudPassLenght.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // clbPassTypeCheck
            // 
            this.clbPassTypeCheck.CheckOnClick = true;
            this.clbPassTypeCheck.FormattingEnabled = true;
            this.clbPassTypeCheck.Items.AddRange(new object[] {
            "Numbers",
            "Upper case",
            "Lower case",
            "Special symbol: %, *, ), ?, #, $, ^, &, ~"});
            this.clbPassTypeCheck.Location = new System.Drawing.Point(19, 22);
            this.clbPassTypeCheck.Name = "clbPassTypeCheck";
            this.clbPassTypeCheck.Size = new System.Drawing.Size(299, 64);
            this.clbPassTypeCheck.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(530, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notepad";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(0, 0);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(530, 389);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbRandom);
            this.tabPage2.Controls.Add(this.btnRandomCopy);
            this.tabPage2.Controls.Add(this.btnRandomClear);
            this.tabPage2.Controls.Add(this.tbRandom);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nudto);
            this.tabPage2.Controls.Add(this.nudfrom);
            this.tabPage2.Controls.Add(this.lblrandom);
            this.tabPage2.Controls.Add(this.btngo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Randomizer";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(356, 210);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(60, 17);
            this.cbRandom.TabIndex = 9;
            this.cbRandom.Text = "Unique";
            this.cbRandom.UseVisualStyleBackColor = true;
            this.cbRandom.CheckedChanged += new System.EventHandler(this.cbRandom_CheckedChanged);
            // 
            // btnRandomCopy
            // 
            this.btnRandomCopy.Location = new System.Drawing.Point(355, 360);
            this.btnRandomCopy.Name = "btnRandomCopy";
            this.btnRandomCopy.Size = new System.Drawing.Size(129, 23);
            this.btnRandomCopy.TabIndex = 8;
            this.btnRandomCopy.Text = "Copy";
            this.btnRandomCopy.UseVisualStyleBackColor = true;
            this.btnRandomCopy.Click += new System.EventHandler(this.btnRandomCopy_Click);
            // 
            // btnRandomClear
            // 
            this.btnRandomClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandomClear.Location = new System.Drawing.Point(261, 231);
            this.btnRandomClear.Name = "btnRandomClear";
            this.btnRandomClear.Size = new System.Drawing.Size(88, 132);
            this.btnRandomClear.TabIndex = 7;
            this.btnRandomClear.Text = "Clear it ->";
            this.btnRandomClear.UseVisualStyleBackColor = true;
            this.btnRandomClear.Click += new System.EventHandler(this.btnRandomClear_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(355, 231);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(129, 132);
            this.tbRandom.TabIndex = 6;
            this.tbRandom.TextChanged += new System.EventHandler(this.tbRandom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(245, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // nudto
            // 
            this.nudto.Location = new System.Drawing.Point(317, 83);
            this.nudto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudto.Name = "nudto";
            this.nudto.Size = new System.Drawing.Size(129, 20);
            this.nudto.TabIndex = 3;
            this.nudto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudfrom
            // 
            this.nudfrom.Location = new System.Drawing.Point(90, 83);
            this.nudfrom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudfrom.Name = "nudfrom";
            this.nudfrom.Size = new System.Drawing.Size(115, 20);
            this.nudfrom.TabIndex = 2;
            // 
            // lblrandom
            // 
            this.lblrandom.AutoSize = true;
            this.lblrandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblrandom.Location = new System.Drawing.Point(208, 273);
            this.lblrandom.Name = "lblrandom";
            this.lblrandom.Size = new System.Drawing.Size(0, 37);
            this.lblrandom.TabIndex = 1;
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btngo.Location = new System.Drawing.Point(181, 154);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(168, 74);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "GO!";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnMinus);
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Counter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(216, 167);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(30, 31);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(313, 154);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 52);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(77, 208);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(113, 60);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(77, 94);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(113, 60);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbMetric);
            this.tabPage5.Controls.Add(this.btnSwap);
            this.tabPage5.Controls.Add(this.tbTo);
            this.tabPage5.Controls.Add(this.tbFrom);
            this.tabPage5.Controls.Add(this.btnConvert);
            this.tabPage5.Controls.Add(this.cbTo);
            this.tabPage5.Controls.Add(this.cbFrom);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(530, 389);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Converter";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbFrom
            // 
            this.cbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(44, 90);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(155, 28);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "mm";
            // 
            // cbTo
            // 
            this.cbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbTo.Location = new System.Drawing.Point(332, 90);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(155, 28);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "mm";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConvert.Location = new System.Drawing.Point(205, 119);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(121, 30);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tbFrom
            // 
            this.tbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFrom.Location = new System.Drawing.Point(44, 118);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(155, 26);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "1";
            // 
            // tbTo
            // 
            this.tbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTo.Location = new System.Drawing.Point(332, 118);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(155, 26);
            this.tbTo.TabIndex = 4;
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSwap.Location = new System.Drawing.Point(205, 90);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(121, 30);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "< --- >";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // cbMetric
            // 
            this.cbMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMetric.FormattingEnabled = true;
            this.cbMetric.Items.AddRange(new object[] {
            "length",
            "weight"});
            this.cbMetric.Location = new System.Drawing.Point(187, 45);
            this.cbMetric.Name = "cbMetric";
            this.cbMetric.Size = new System.Drawing.Size(155, 28);
            this.cbMetric.TabIndex = 6;
            this.cbMetric.Text = "length";
            this.cbMetric.SelectedIndexChanged += new System.EventHandler(this.cbMetric_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 439);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My Utilites";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLenght)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudfrom)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudto;
        private System.Windows.Forms.NumericUpDown nudfrom;
        private System.Windows.Forms.Label lblrandom;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button btnRandomClear;
        private System.Windows.Forms.Button btnRandomCopy;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPassLenght;
        private System.Windows.Forms.CheckedListBox clbPassTypeCheck;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnCreatePass;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ComboBox cbMetric;
    }
}

