namespace mainApplicationPattern.UI.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proxyBtn = new System.Windows.Forms.Button();
            this.sourceBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.actThreadsLbl = new System.Windows.Forms.Label();
            this.goodProxyLbl = new System.Windows.Forms.Label();
            this.ppsLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.badLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.goodLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proxyLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.typeOfProxyCBOX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.threadsNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.goodTBox = new System.Windows.Forms.TextBox();
            this.GUI = new System.Windows.Forms.Timer(this.components);
            this.PPS = new System.Windows.Forms.Timer(this.components);
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.statusPBar = new System.Windows.Forms.ProgressBar();
            this.resetProxyBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNUD)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proxyBtn);
            this.groupBox1.Controls.Add(this.sourceBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // proxyBtn
            // 
            this.proxyBtn.Location = new System.Drawing.Point(10, 47);
            this.proxyBtn.Name = "proxyBtn";
            this.proxyBtn.Size = new System.Drawing.Size(93, 25);
            this.proxyBtn.TabIndex = 1;
            this.proxyBtn.Text = "Proxy";
            this.proxyBtn.UseVisualStyleBackColor = true;
            this.proxyBtn.Click += new System.EventHandler(this.proxyBtn_Click);
            // 
            // sourceBtn
            // 
            this.sourceBtn.Location = new System.Drawing.Point(10, 16);
            this.sourceBtn.Name = "sourceBtn";
            this.sourceBtn.Size = new System.Drawing.Size(93, 25);
            this.sourceBtn.TabIndex = 0;
            this.sourceBtn.Text = "Source";
            this.sourceBtn.UseVisualStyleBackColor = true;
            this.sourceBtn.Click += new System.EventHandler(this.sourceBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.actThreadsLbl);
            this.groupBox2.Controls.Add(this.goodProxyLbl);
            this.groupBox2.Controls.Add(this.ppsLbl);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.errLbl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.badLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.goodLbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.proxyLbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sourceLbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(125, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // actThreadsLbl
            // 
            this.actThreadsLbl.AutoSize = true;
            this.actThreadsLbl.Location = new System.Drawing.Point(70, 102);
            this.actThreadsLbl.Name = "actThreadsLbl";
            this.actThreadsLbl.Size = new System.Drawing.Size(13, 13);
            this.actThreadsLbl.TabIndex = 0;
            this.actThreadsLbl.Text = "0";
            // 
            // goodProxyLbl
            // 
            this.goodProxyLbl.AutoSize = true;
            this.goodProxyLbl.Location = new System.Drawing.Point(70, 89);
            this.goodProxyLbl.Name = "goodProxyLbl";
            this.goodProxyLbl.Size = new System.Drawing.Size(13, 13);
            this.goodProxyLbl.TabIndex = 0;
            this.goodProxyLbl.Text = "0";
            // 
            // ppsLbl
            // 
            this.ppsLbl.AutoSize = true;
            this.ppsLbl.Location = new System.Drawing.Point(70, 76);
            this.ppsLbl.Name = "ppsLbl";
            this.ppsLbl.Size = new System.Drawing.Size(13, 13);
            this.ppsLbl.TabIndex = 0;
            this.ppsLbl.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ActThreads";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "GoodProxy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "PPS";
            // 
            // errLbl
            // 
            this.errLbl.AutoSize = true;
            this.errLbl.Location = new System.Drawing.Point(70, 63);
            this.errLbl.Name = "errLbl";
            this.errLbl.Size = new System.Drawing.Size(13, 13);
            this.errLbl.TabIndex = 0;
            this.errLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Errors";
            // 
            // badLbl
            // 
            this.badLbl.AutoSize = true;
            this.badLbl.Location = new System.Drawing.Point(70, 50);
            this.badLbl.Name = "badLbl";
            this.badLbl.Size = new System.Drawing.Size(13, 13);
            this.badLbl.TabIndex = 0;
            this.badLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bad";
            // 
            // goodLbl
            // 
            this.goodLbl.AutoSize = true;
            this.goodLbl.Location = new System.Drawing.Point(70, 37);
            this.goodLbl.Name = "goodLbl";
            this.goodLbl.Size = new System.Drawing.Size(13, 13);
            this.goodLbl.TabIndex = 0;
            this.goodLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Good";
            // 
            // proxyLbl
            // 
            this.proxyLbl.AutoSize = true;
            this.proxyLbl.Location = new System.Drawing.Point(70, 24);
            this.proxyLbl.Name = "proxyLbl";
            this.proxyLbl.Size = new System.Drawing.Size(13, 13);
            this.proxyLbl.TabIndex = 0;
            this.proxyLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proxy";
            // 
            // sourceLbl
            // 
            this.sourceLbl.AutoSize = true;
            this.sourceLbl.Location = new System.Drawing.Point(70, 11);
            this.sourceLbl.Name = "sourceLbl";
            this.sourceLbl.Size = new System.Drawing.Size(13, 13);
            this.sourceLbl.TabIndex = 0;
            this.sourceLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.typeOfProxyCBOX);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.threadsNUD);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(3, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Sep. domains";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // typeOfProxyCBOX
            // 
            this.typeOfProxyCBOX.FormattingEnabled = true;
            this.typeOfProxyCBOX.Items.AddRange(new object[] {
            "no proxy",
            "http/https",
            "socks 4",
            "socks 5"});
            this.typeOfProxyCBOX.Location = new System.Drawing.Point(10, 51);
            this.typeOfProxyCBOX.Name = "typeOfProxyCBOX";
            this.typeOfProxyCBOX.Size = new System.Drawing.Size(93, 21);
            this.typeOfProxyCBOX.TabIndex = 3;
            this.typeOfProxyCBOX.Text = "no proxy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Type of proxy:";
            // 
            // threadsNUD
            // 
            this.threadsNUD.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.threadsNUD.Location = new System.Drawing.Point(58, 12);
            this.threadsNUD.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.threadsNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.threadsNUD.Name = "threadsNUD";
            this.threadsNUD.Size = new System.Drawing.Size(45, 20);
            this.threadsNUD.TabIndex = 1;
            this.threadsNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Threads:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stopBtn);
            this.groupBox4.Controls.Add(this.startBtn);
            this.groupBox4.Location = new System.Drawing.Point(125, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 67);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(8, 39);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(129, 25);
            this.stopBtn.TabIndex = 0;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(8, 10);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(129, 25);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.goodTBox);
            this.groupBox5.Location = new System.Drawing.Point(3, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(267, 161);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // goodTBox
            // 
            this.goodTBox.Location = new System.Drawing.Point(7, 11);
            this.goodTBox.Multiline = true;
            this.goodTBox.Name = "goodTBox";
            this.goodTBox.ReadOnly = true;
            this.goodTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.goodTBox.Size = new System.Drawing.Size(254, 144);
            this.goodTBox.TabIndex = 0;
            // 
            // GUI
            // 
            this.GUI.Tick += new System.EventHandler(this.GUI_Tick);
            // 
            // PPS
            // 
            this.PPS.Interval = 1000;
            this.PPS.Tick += new System.EventHandler(this.PPS_Tick);
            // 
            // visualStyler1
            // 
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "ConcaveD (Compact).vssf");
            // 
            // statusPBar
            // 
            this.statusPBar.Location = new System.Drawing.Point(9, 185);
            this.statusPBar.Name = "statusPBar";
            this.statusPBar.Size = new System.Drawing.Size(103, 10);
            this.statusPBar.TabIndex = 5;
            // 
            // resetProxyBtn
            // 
            this.resetProxyBtn.Location = new System.Drawing.Point(74, 364);
            this.resetProxyBtn.Name = "resetProxyBtn";
            this.resetProxyBtn.Size = new System.Drawing.Size(125, 23);
            this.resetProxyBtn.TabIndex = 6;
            this.resetProxyBtn.Text = "Reset Proxy List";
            this.resetProxyBtn.UseVisualStyleBackColor = true;
            this.resetProxyBtn.Click += new System.EventHandler(this.resetProxyBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 393);
            this.Controls.Add(this.resetProxyBtn);
            this.Controls.Add(this.statusPBar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Brute Engine by vladb9582";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsNUD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button proxyBtn;
        private System.Windows.Forms.Button sourceBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ppsLbl;
        private System.Windows.Forms.Label errLbl;
        private System.Windows.Forms.Label badLbl;
        private System.Windows.Forms.Label goodLbl;
        private System.Windows.Forms.Label proxyLbl;
        private System.Windows.Forms.Label sourceLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox typeOfProxyCBOX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown threadsNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox goodTBox;
        private System.Windows.Forms.Timer GUI;
        private System.Windows.Forms.Timer PPS;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.ProgressBar statusPBar;
        private System.Windows.Forms.Label goodProxyLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label actThreadsLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button resetProxyBtn;
    }
}