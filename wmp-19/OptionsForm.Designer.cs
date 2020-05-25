namespace wmp_19
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.okButton = new System.Windows.Forms.Button();
            this.labelProductName = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.radiobtnLight = new System.Windows.Forms.RadioButton();
            this.radiobtnDark = new System.Windows.Forms.RadioButton();
            this.radiobtnMavi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(339, 240);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 22);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(143, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(271, 17);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Select A Mood : ";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(131, 259);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.radiobtnLight, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.radiobtnDark, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.radiobtnMavi, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60377F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07547F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.56604F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9434F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.24528F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(417, 265);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // radiobtnLight
            // 
            this.radiobtnLight.AutoSize = true;
            this.radiobtnLight.Location = new System.Drawing.Point(140, 47);
            this.radiobtnLight.Name = "radiobtnLight";
            this.radiobtnLight.Size = new System.Drawing.Size(48, 17);
            this.radiobtnLight.TabIndex = 25;
            this.radiobtnLight.TabStop = true;
            this.radiobtnLight.Text = "Light";
            this.radiobtnLight.UseVisualStyleBackColor = true;
            this.radiobtnLight.CheckedChanged += new System.EventHandler(this.radiobtnLight_CheckedChanged);
            // 
            // radiobtnDark
            // 
            this.radiobtnDark.AutoSize = true;
            this.radiobtnDark.Location = new System.Drawing.Point(140, 79);
            this.radiobtnDark.Name = "radiobtnDark";
            this.radiobtnDark.Size = new System.Drawing.Size(48, 17);
            this.radiobtnDark.TabIndex = 26;
            this.radiobtnDark.TabStop = true;
            this.radiobtnDark.Text = "Dark";
            this.radiobtnDark.UseVisualStyleBackColor = true;
            this.radiobtnDark.CheckedChanged += new System.EventHandler(this.radiobtnDark_CheckedChanged);
            // 
            // radiobtnMavi
            // 
            this.radiobtnMavi.AutoSize = true;
            this.radiobtnMavi.Location = new System.Drawing.Point(140, 107);
            this.radiobtnMavi.Name = "radiobtnMavi";
            this.radiobtnMavi.Size = new System.Drawing.Size(48, 17);
            this.radiobtnMavi.TabIndex = 27;
            this.radiobtnMavi.TabStop = true;
            this.radiobtnMavi.Text = "Mavi";
            this.radiobtnMavi.UseVisualStyleBackColor = true;
            this.radiobtnMavi.CheckedChanged += new System.EventHandler(this.radiobtnMavi_CheckedChanged);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button okButton;
        public System.Windows.Forms.Label labelProductName;
        public System.Windows.Forms.PictureBox logoPictureBox;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        public System.Windows.Forms.RadioButton radiobtnLight;
        public System.Windows.Forms.RadioButton radiobtnDark;
        public System.Windows.Forms.RadioButton radiobtnMavi;
    }
}
