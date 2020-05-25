namespace wmp_19
{
    public partial class AsraMP
    {


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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsraMP));
            this.anamenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutASRAMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.secbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ta7it = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Openbtn1 = new System.Windows.Forms.PictureBox();
            this.Playbtn1 = new System.Windows.Forms.PictureBox();
            this.Pausebtn1 = new System.Windows.Forms.PictureBox();
            this.Stopbtn1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.MyWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.anamenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ta7it.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Openbtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playbtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausebtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stopbtn1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // anamenu
            // 
            this.anamenu.BackColor = System.Drawing.SystemColors.Control;
            this.anamenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.anamenu.Location = new System.Drawing.Point(0, 0);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(800, 24);
            this.anamenu.TabIndex = 1;
            this.anamenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutASRAMPToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutASRAMPToolStripMenuItem
            // 
            this.aboutASRAMPToolStripMenuItem.Name = "aboutASRAMPToolStripMenuItem";
            this.aboutASRAMPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutASRAMPToolStripMenuItem.Text = "About ASRA-MP";
            this.aboutASRAMPToolStripMenuItem.Click += new System.EventHandler(this.aboutASRAMPToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "bir dosya seç";
            this.openFileDialog1.Filter = "All Supported Audio | *.mp3; *.wma |Mp3 files (*.mp3)|*.mp3|Wma files (*.wma)|*.w" +
    "ma|M4a files (*.m4a)|*.m4a|All files (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.ta7it);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.secbtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(206, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 25);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // secbtn
            // 
            this.secbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secbtn.Location = new System.Drawing.Point(458, 3);
            this.secbtn.Name = "secbtn";
            this.secbtn.Size = new System.Drawing.Size(133, 19);
            this.secbtn.TabIndex = 0;
            this.secbtn.Text = "Select";
            this.secbtn.UseVisualStyleBackColor = true;
            this.secbtn.Click += new System.EventHandler(this.secbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(418, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "__:__";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "__:__";
            // 
            // ta7it
            // 
            this.ta7it.BackColor = System.Drawing.SystemColors.Control;
            this.ta7it.ColumnCount = 2;
            this.ta7it.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.166667F));
            this.ta7it.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.83334F));
            this.ta7it.Controls.Add(this.label1, 0, 0);
            this.ta7it.Controls.Add(this.label2, 1, 0);
            this.ta7it.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ta7it.Location = new System.Drawing.Point(200, 25);
            this.ta7it.Margin = new System.Windows.Forms.Padding(1);
            this.ta7it.Name = "ta7it";
            this.ta7it.RowCount = 1;
            this.ta7it.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ta7it.Size = new System.Drawing.Size(600, 19);
            this.ta7it.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "©";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(28, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "2020 Asım Rahal.  All rights reserved.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Openbtn1);
            this.panel2.Controls.Add(this.Playbtn1);
            this.panel2.Controls.Add(this.Pausebtn1);
            this.panel2.Controls.Add(this.Stopbtn1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 44);
            this.panel2.TabIndex = 42;
            // 
            // Openbtn1
            // 
            this.Openbtn1.Image = ((System.Drawing.Image)(resources.GetObject("Openbtn1.Image")));
            this.Openbtn1.Location = new System.Drawing.Point(120, 7);
            this.Openbtn1.Name = "Openbtn1";
            this.Openbtn1.Size = new System.Drawing.Size(32, 32);
            this.Openbtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Openbtn1.TabIndex = 41;
            this.Openbtn1.TabStop = false;
            this.Openbtn1.Click += new System.EventHandler(this.Openbtn1_Click);
            // 
            // Playbtn1
            // 
            this.Playbtn1.Image = ((System.Drawing.Image)(resources.GetObject("Playbtn1.Image")));
            this.Playbtn1.Location = new System.Drawing.Point(6, 7);
            this.Playbtn1.Name = "Playbtn1";
            this.Playbtn1.Size = new System.Drawing.Size(32, 32);
            this.Playbtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playbtn1.TabIndex = 38;
            this.Playbtn1.TabStop = false;
            this.Playbtn1.Click += new System.EventHandler(this.Playbtn1_Click);
            // 
            // Pausebtn1
            // 
            this.Pausebtn1.Image = ((System.Drawing.Image)(resources.GetObject("Pausebtn1.Image")));
            this.Pausebtn1.Location = new System.Drawing.Point(44, 7);
            this.Pausebtn1.Name = "Pausebtn1";
            this.Pausebtn1.Size = new System.Drawing.Size(32, 32);
            this.Pausebtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pausebtn1.TabIndex = 39;
            this.Pausebtn1.TabStop = false;
            this.Pausebtn1.Click += new System.EventHandler(this.Pausebtn1_Click);
            // 
            // Stopbtn1
            // 
            this.Stopbtn1.Image = ((System.Drawing.Image)(resources.GetObject("Stopbtn1.Image")));
            this.Stopbtn1.Location = new System.Drawing.Point(82, 7);
            this.Stopbtn1.Name = "Stopbtn1";
            this.Stopbtn1.Size = new System.Drawing.Size(32, 32);
            this.Stopbtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stopbtn1.TabIndex = 40;
            this.Stopbtn1.TabStop = false;
            this.Stopbtn1.Click += new System.EventHandler(this.Stopbtn1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel3.Controls.Add(this.progressBar1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.listBoxSongs, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.MyWMP, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.98691F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.013092F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 350);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 346);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(661, 4);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 30;
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(664, 3);
            this.listBoxSongs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(133, 343);
            this.listBoxSongs.TabIndex = 7;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBoxSongs.SelectedValueChanged += new System.EventHandler(this.listBoxSongs_SelectedValueChanged);
            // 
            // MyWMP
            // 
            this.MyWMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyWMP.Enabled = true;
            this.MyWMP.Location = new System.Drawing.Point(3, 3);
            this.MyWMP.Name = "MyWMP";
            this.MyWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MyWMP.OcxState")));
            this.MyWMP.Size = new System.Drawing.Size(655, 340);
            this.MyWMP.TabIndex = 8;
            // 
            // AsraMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.anamenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.anamenu;
            this.Name = "AsraMP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASRA-MP";
            this.Load += new System.EventHandler(this.AsraMP_Load);
            this.anamenu.ResumeLayout(false);
            this.anamenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ta7it.ResumeLayout(false);
            this.ta7it.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Openbtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playbtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausebtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stopbtn1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutASRAMPToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TableLayoutPanel ta7it;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.PictureBox Openbtn1;
        public System.Windows.Forms.PictureBox Stopbtn1;
        public System.Windows.Forms.PictureBox Pausebtn1;
        public System.Windows.Forms.PictureBox Playbtn1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox listBoxSongs;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.MenuStrip anamenu;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button secbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public AxWMPLib.AxWindowsMediaPlayer MyWMP;
    }
}

