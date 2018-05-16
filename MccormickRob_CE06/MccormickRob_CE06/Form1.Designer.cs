namespace TreeListApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLeg = new System.Windows.Forms.TabPage();
            this.tpTotal = new System.Windows.Forms.TabPage();
            this.trvResult = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalMiles = new System.Windows.Forms.TextBox();
            this.txtTotalHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalLegs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDirection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numMiles = new System.Windows.Forms.NumericUpDown();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ilTreeview = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpLeg.SuspendLayout();
            this.tpTotal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLeg);
            this.tabControl1.Controls.Add(this.tpTotal);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 241);
            this.tabControl1.TabIndex = 1;
            // 
            // tpLeg
            // 
            this.tpLeg.Controls.Add(this.btnAdd);
            this.tpLeg.Controls.Add(this.groupBox1);
            this.tpLeg.Location = new System.Drawing.Point(4, 22);
            this.tpLeg.Name = "tpLeg";
            this.tpLeg.Padding = new System.Windows.Forms.Padding(3);
            this.tpLeg.Size = new System.Drawing.Size(192, 215);
            this.tpLeg.TabIndex = 0;
            this.tpLeg.Text = "Leg";
            this.tpLeg.UseVisualStyleBackColor = true;
            // 
            // tpTotal
            // 
            this.tpTotal.Controls.Add(this.txtTotalLegs);
            this.tpTotal.Controls.Add(this.label3);
            this.tpTotal.Controls.Add(this.txtTotalHours);
            this.tpTotal.Controls.Add(this.label2);
            this.tpTotal.Controls.Add(this.txtTotalMiles);
            this.tpTotal.Controls.Add(this.label1);
            this.tpTotal.Location = new System.Drawing.Point(4, 22);
            this.tpTotal.Name = "tpTotal";
            this.tpTotal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTotal.Size = new System.Drawing.Size(192, 215);
            this.tpTotal.TabIndex = 1;
            this.tpTotal.Text = "Total";
            this.tpTotal.UseVisualStyleBackColor = true;
            // 
            // trvResult
            // 
            this.trvResult.ImageIndex = 0;
            this.trvResult.ImageList = this.ilTreeview;
            this.trvResult.Location = new System.Drawing.Point(202, 27);
            this.trvResult.Name = "trvResult";
            this.trvResult.SelectedImageIndex = 0;
            this.trvResult.Size = new System.Drawing.Size(271, 237);
            this.trvResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miles";
            // 
            // txtTotalMiles
            // 
            this.txtTotalMiles.Enabled = false;
            this.txtTotalMiles.Location = new System.Drawing.Point(45, 9);
            this.txtTotalMiles.Name = "txtTotalMiles";
            this.txtTotalMiles.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMiles.TabIndex = 1;
            // 
            // txtTotalHours
            // 
            this.txtTotalHours.Enabled = false;
            this.txtTotalHours.Location = new System.Drawing.Point(45, 35);
            this.txtTotalHours.Name = "txtTotalHours";
            this.txtTotalHours.Size = new System.Drawing.Size(100, 20);
            this.txtTotalHours.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hours";
            // 
            // txtTotalLegs
            // 
            this.txtTotalLegs.Enabled = false;
            this.txtTotalLegs.Location = new System.Drawing.Point(45, 61);
            this.txtTotalLegs.Name = "txtTotalLegs";
            this.txtTotalLegs.Size = new System.Drawing.Size(100, 20);
            this.txtTotalLegs.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Legs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numHours);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numMiles);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbDirection);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Direction";
            // 
            // cbbDirection
            // 
            this.cbbDirection.FormattingEnabled = true;
            this.cbbDirection.Location = new System.Drawing.Point(57, 13);
            this.cbbDirection.Name = "cbbDirection";
            this.cbbDirection.Size = new System.Drawing.Size(115, 21);
            this.cbbDirection.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Miles";
            // 
            // numMiles
            // 
            this.numMiles.DecimalPlaces = 2;
            this.numMiles.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numMiles.Location = new System.Drawing.Point(57, 40);
            this.numMiles.Name = "numMiles";
            this.numMiles.Size = new System.Drawing.Size(115, 20);
            this.numMiles.TabIndex = 3;
            this.numMiles.ThousandsSeparator = true;
            // 
            // numHours
            // 
            this.numHours.DecimalPlaces = 2;
            this.numHours.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numHours.Location = new System.Drawing.Point(57, 66);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(115, 20);
            this.numHours.TabIndex = 5;
            this.numHours.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mode";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(57, 91);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(115, 20);
            this.txtMode.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ilTreeview
            // 
            this.ilTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTreeview.ImageStream")));
            this.ilTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTreeview.Images.SetKeyName(0, "gearIcon.png");
            this.ilTreeview.Images.SetKeyName(1, "rightArrow.jpg");
            this.ilTreeview.Images.SetKeyName(2, "leftArrow.jpg");
            this.ilTreeview.Images.SetKeyName(3, "upArrow.jpg");
            this.ilTreeview.Images.SetKeyName(4, "downArrow.jpg");
            this.ilTreeview.Images.SetKeyName(5, "document.png");
            this.ilTreeview.Images.SetKeyName(6, "plusSign.png");
            this.ilTreeview.Images.SetKeyName(7, "xIcon.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 272);
            this.Controls.Add(this.trvResult);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpLeg.ResumeLayout(false);
            this.tpTotal.ResumeLayout(false);
            this.tpTotal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLeg;
        private System.Windows.Forms.TabPage tpTotal;
        private System.Windows.Forms.TreeView trvResult;
        private System.Windows.Forms.TextBox txtTotalLegs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalMiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbDirection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList ilTreeview;
    }
}

