namespace TitanEmulator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.labelV = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.tbPC = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbRF = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbRE = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbRD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbRC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbR9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbR8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbR7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbR6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbR5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbR4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbR3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbR2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbR1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbR0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stackHeightLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.callStackLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentInstructionLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.SizeChanged += new System.EventHandler(this.menuStrip1_SizeChanged);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.loadToolStripMenuItem.Text = "Load assembly...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoryViewerToolStripMenuItem,
            this.stackViewerToolStripMenuItem,
            this.toolStripComboBox1});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // memoryViewerToolStripMenuItem
            // 
            this.memoryViewerToolStripMenuItem.Name = "memoryViewerToolStripMenuItem";
            this.memoryViewerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.memoryViewerToolStripMenuItem.Text = "Memory viewer";
            this.memoryViewerToolStripMenuItem.Click += new System.EventHandler(this.memoryViewerToolStripMenuItem_Click);
            // 
            // stackViewerToolStripMenuItem
            // 
            this.stackViewerToolStripMenuItem.Name = "stackViewerToolStripMenuItem";
            this.stackViewerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.stackViewerToolStripMenuItem.Text = "Stack viewer";
            this.stackViewerToolStripMenuItem.Click += new System.EventHandler(this.stackViewerToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(161, 22);
            this.toolStripComboBox1.Text = "Call stack viewer";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(630, 464);
            this.splitContainer1.SplitterDistance = 415;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(415, 464);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Step";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbZ);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.tbS);
            this.groupBox1.Controls.Add(this.labelV);
            this.groupBox1.Controls.Add(this.tbC);
            this.groupBox1.Controls.Add(this.labelC);
            this.groupBox1.Controls.Add(this.tbPC);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbRF);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbRE);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbRD);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbRC);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbRB);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbRA);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbR9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbR8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbR7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbR6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbR5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbR4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbR3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbR2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbR1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbR0);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register View";
            // 
            // tbZ
            // 
            this.tbZ.Enabled = false;
            this.tbZ.Location = new System.Drawing.Point(150, 276);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(44, 20);
            this.tbZ.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(108, 278);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Z";
            // 
            // tbS
            // 
            this.tbS.Enabled = false;
            this.tbS.Location = new System.Drawing.Point(150, 252);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(44, 20);
            this.tbS.TabIndex = 37;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(108, 256);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(14, 13);
            this.labelV.TabIndex = 36;
            this.labelV.Text = "S";
            // 
            // tbC
            // 
            this.tbC.Enabled = false;
            this.tbC.Location = new System.Drawing.Point(49, 276);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(44, 20);
            this.tbC.TabIndex = 35;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(7, 278);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(14, 13);
            this.labelC.TabIndex = 34;
            this.labelC.Text = "C";
            // 
            // tbPC
            // 
            this.tbPC.Enabled = false;
            this.tbPC.Location = new System.Drawing.Point(49, 252);
            this.tbPC.Name = "tbPC";
            this.tbPC.Size = new System.Drawing.Size(44, 20);
            this.tbPC.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "PC";
            // 
            // tbRF
            // 
            this.tbRF.Enabled = false;
            this.tbRF.Location = new System.Drawing.Point(150, 188);
            this.tbRF.Name = "tbRF";
            this.tbRF.Size = new System.Drawing.Size(44, 20);
            this.tbRF.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(108, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "RF";
            // 
            // tbRE
            // 
            this.tbRE.Enabled = false;
            this.tbRE.Location = new System.Drawing.Point(150, 162);
            this.tbRE.Name = "tbRE";
            this.tbRE.Size = new System.Drawing.Size(44, 20);
            this.tbRE.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(108, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "RE";
            // 
            // tbRD
            // 
            this.tbRD.Enabled = false;
            this.tbRD.Location = new System.Drawing.Point(150, 138);
            this.tbRD.Name = "tbRD";
            this.tbRD.Size = new System.Drawing.Size(44, 20);
            this.tbRD.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(108, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "RD";
            // 
            // tbRC
            // 
            this.tbRC.Enabled = false;
            this.tbRC.Location = new System.Drawing.Point(150, 113);
            this.tbRC.Name = "tbRC";
            this.tbRC.Size = new System.Drawing.Size(44, 20);
            this.tbRC.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(108, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "RC";
            // 
            // tbRB
            // 
            this.tbRB.Enabled = false;
            this.tbRB.Location = new System.Drawing.Point(150, 89);
            this.tbRB.Name = "tbRB";
            this.tbRB.Size = new System.Drawing.Size(44, 20);
            this.tbRB.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "RB";
            // 
            // tbRA
            // 
            this.tbRA.Enabled = false;
            this.tbRA.Location = new System.Drawing.Point(150, 66);
            this.tbRA.Name = "tbRA";
            this.tbRA.Size = new System.Drawing.Size(44, 20);
            this.tbRA.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "RA";
            // 
            // tbR9
            // 
            this.tbR9.Enabled = false;
            this.tbR9.Location = new System.Drawing.Point(150, 42);
            this.tbR9.Name = "tbR9";
            this.tbR9.Size = new System.Drawing.Size(44, 20);
            this.tbR9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "R9";
            // 
            // tbR8
            // 
            this.tbR8.Enabled = false;
            this.tbR8.Location = new System.Drawing.Point(150, 19);
            this.tbR8.Name = "tbR8";
            this.tbR8.Size = new System.Drawing.Size(44, 20);
            this.tbR8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "R8";
            // 
            // tbR7
            // 
            this.tbR7.Enabled = false;
            this.tbR7.Location = new System.Drawing.Point(49, 186);
            this.tbR7.Name = "tbR7";
            this.tbR7.Size = new System.Drawing.Size(44, 20);
            this.tbR7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "R7";
            // 
            // tbR6
            // 
            this.tbR6.Enabled = false;
            this.tbR6.Location = new System.Drawing.Point(49, 162);
            this.tbR6.Name = "tbR6";
            this.tbR6.Size = new System.Drawing.Size(44, 20);
            this.tbR6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "R6";
            // 
            // tbR5
            // 
            this.tbR5.Enabled = false;
            this.tbR5.Location = new System.Drawing.Point(49, 138);
            this.tbR5.Name = "tbR5";
            this.tbR5.Size = new System.Drawing.Size(44, 20);
            this.tbR5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "R5";
            // 
            // tbR4
            // 
            this.tbR4.Enabled = false;
            this.tbR4.Location = new System.Drawing.Point(49, 114);
            this.tbR4.Name = "tbR4";
            this.tbR4.Size = new System.Drawing.Size(44, 20);
            this.tbR4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "R4";
            // 
            // tbR3
            // 
            this.tbR3.Enabled = false;
            this.tbR3.Location = new System.Drawing.Point(49, 90);
            this.tbR3.Name = "tbR3";
            this.tbR3.Size = new System.Drawing.Size(44, 20);
            this.tbR3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "R3";
            // 
            // tbR2
            // 
            this.tbR2.Enabled = false;
            this.tbR2.Location = new System.Drawing.Point(49, 66);
            this.tbR2.Name = "tbR2";
            this.tbR2.Size = new System.Drawing.Size(44, 20);
            this.tbR2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "R2";
            // 
            // tbR1
            // 
            this.tbR1.Enabled = false;
            this.tbR1.Location = new System.Drawing.Point(49, 42);
            this.tbR1.Name = "tbR1";
            this.tbR1.Size = new System.Drawing.Size(44, 20);
            this.tbR1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "R1";
            // 
            // tbR0
            // 
            this.tbR0.Enabled = false;
            this.tbR0.Location = new System.Drawing.Point(49, 18);
            this.tbR0.Name = "tbR0";
            this.tbR0.Size = new System.Drawing.Size(44, 20);
            this.tbR0.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "R0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stackHeightLbl,
            this.toolStripStatusLabel3,
            this.callStackLbl,
            this.toolStripStatusLabel4,
            this.currentInstructionLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stackHeightLbl
            // 
            this.stackHeightLbl.Name = "stackHeightLbl";
            this.stackHeightLbl.Size = new System.Drawing.Size(118, 17);
            this.stackHeightLbl.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 19);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // callStackLbl
            // 
            this.callStackLbl.Name = "callStackLbl";
            this.callStackLbl.Size = new System.Drawing.Size(118, 17);
            this.callStackLbl.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 19);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // currentInstructionLbl
            // 
            this.currentInstructionLbl.Name = "currentInstructionLbl";
            this.currentInstructionLbl.Size = new System.Drawing.Size(118, 17);
            this.currentInstructionLbl.Text = "toolStripStatusLabel5";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 510);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox tbPC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbRF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbRD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbRC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbRB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbR9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbR8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbR7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbR6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbR5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbR4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbR3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbR2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbR1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbR0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stackHeightLbl;
        private System.Windows.Forms.ToolStripStatusLabel callStackLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel currentInstructionLbl;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoryViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackViewerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
    }
}

