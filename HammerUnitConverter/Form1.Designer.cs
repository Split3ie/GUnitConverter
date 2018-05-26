namespace HammerUnitsConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyLabel = new System.Windows.Forms.Label();
            this.historyDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.footRadioButton = new System.Windows.Forms.RadioButton();
            this.inchesRadioButton = new System.Windows.Forms.RadioButton();
            this.mRadioButton = new System.Windows.Forms.RadioButton();
            this.cmRadioButton = new System.Windows.Forms.RadioButton();
            this.unitsRadioButton = new System.Windows.Forms.RadioButton();
            this.convertButton = new System.Windows.Forms.Button();
            this.feetLabel = new System.Windows.Forms.Label();
            this.inchLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.cmLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.footTextBox = new System.Windows.Forms.TextBox();
            this.inchesTextBox = new System.Windows.Forms.TextBox();
            this.cmTextBox = new System.Windows.Forms.TextBox();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.saveHistory = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.LinkLabel();
            this.helpLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.helpLink);
            this.panel1.Controls.Add(this.saveHistory);
            this.panel1.Controls.Add(this.historyLabel);
            this.panel1.Controls.Add(this.copyrightLabel);
            this.panel1.Controls.Add(this.historyDataGrid);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 553);
            this.panel1.TabIndex = 0;
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(17, 164);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(39, 13);
            this.historyLabel.TabIndex = 2;
            this.historyLabel.Text = "History";
            // 
            // historyDataGrid
            // 
            this.historyDataGrid.AllowUserToAddRows = false;
            this.historyDataGrid.AllowUserToDeleteRows = false;
            this.historyDataGrid.AllowUserToResizeRows = false;
            this.historyDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.historyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGrid.Location = new System.Drawing.Point(14, 185);
            this.historyDataGrid.Name = "historyDataGrid";
            this.historyDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.historyDataGrid.RowHeadersVisible = false;
            this.historyDataGrid.RowTemplate.ReadOnly = true;
            this.historyDataGrid.ShowEditingIcon = false;
            this.historyDataGrid.Size = new System.Drawing.Size(545, 332);
            this.historyDataGrid.TabIndex = 1;
            this.historyDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedFromHistory);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.footRadioButton);
            this.groupBox1.Controls.Add(this.inchesRadioButton);
            this.groupBox1.Controls.Add(this.mRadioButton);
            this.groupBox1.Controls.Add(this.cmRadioButton);
            this.groupBox1.Controls.Add(this.unitsRadioButton);
            this.groupBox1.Controls.Add(this.convertButton);
            this.groupBox1.Controls.Add(this.feetLabel);
            this.groupBox1.Controls.Add(this.inchLabel);
            this.groupBox1.Controls.Add(this.mLabel);
            this.groupBox1.Controls.Add(this.cmLabel);
            this.groupBox1.Controls.Add(this.unitLabel);
            this.groupBox1.Controls.Add(this.mTextBox);
            this.groupBox1.Controls.Add(this.footTextBox);
            this.groupBox1.Controls.Add(this.inchesTextBox);
            this.groupBox1.Controls.Add(this.cmTextBox);
            this.groupBox1.Controls.Add(this.unitsTextBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert";
            // 
            // footRadioButton
            // 
            this.footRadioButton.AutoSize = true;
            this.footRadioButton.Location = new System.Drawing.Point(430, 19);
            this.footRadioButton.Name = "footRadioButton";
            this.footRadioButton.Size = new System.Drawing.Size(46, 17);
            this.footRadioButton.TabIndex = 20;
            this.footRadioButton.TabStop = true;
            this.footRadioButton.Text = "Feet";
            this.footRadioButton.UseVisualStyleBackColor = true;
            // 
            // inchesRadioButton
            // 
            this.inchesRadioButton.AutoSize = true;
            this.inchesRadioButton.Location = new System.Drawing.Point(324, 19);
            this.inchesRadioButton.Name = "inchesRadioButton";
            this.inchesRadioButton.Size = new System.Drawing.Size(57, 17);
            this.inchesRadioButton.TabIndex = 19;
            this.inchesRadioButton.TabStop = true;
            this.inchesRadioButton.Text = "Inches";
            this.inchesRadioButton.UseVisualStyleBackColor = true;
            // 
            // mRadioButton
            // 
            this.mRadioButton.AutoSize = true;
            this.mRadioButton.Location = new System.Drawing.Point(218, 19);
            this.mRadioButton.Name = "mRadioButton";
            this.mRadioButton.Size = new System.Drawing.Size(34, 17);
            this.mRadioButton.TabIndex = 18;
            this.mRadioButton.TabStop = true;
            this.mRadioButton.Text = "M";
            this.mRadioButton.UseVisualStyleBackColor = true;
            // 
            // cmRadioButton
            // 
            this.cmRadioButton.AutoSize = true;
            this.cmRadioButton.Location = new System.Drawing.Point(112, 19);
            this.cmRadioButton.Name = "cmRadioButton";
            this.cmRadioButton.Size = new System.Drawing.Size(40, 17);
            this.cmRadioButton.TabIndex = 17;
            this.cmRadioButton.TabStop = true;
            this.cmRadioButton.Text = "Cm";
            this.cmRadioButton.UseVisualStyleBackColor = true;
            // 
            // unitsRadioButton
            // 
            this.unitsRadioButton.AutoSize = true;
            this.unitsRadioButton.Location = new System.Drawing.Point(6, 19);
            this.unitsRadioButton.Name = "unitsRadioButton";
            this.unitsRadioButton.Size = new System.Drawing.Size(49, 17);
            this.unitsRadioButton.TabIndex = 16;
            this.unitsRadioButton.TabStop = true;
            this.unitsRadioButton.Text = "Units";
            this.unitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(464, 118);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 15;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLabel.Location = new System.Drawing.Point(442, 86);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(54, 21);
            this.feetLabel.TabIndex = 14;
            this.feetLabel.Text = "Feet";
            // 
            // inchLabel
            // 
            this.inchLabel.AutoSize = true;
            this.inchLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchLabel.Location = new System.Drawing.Point(338, 86);
            this.inchLabel.Name = "inchLabel";
            this.inchLabel.Size = new System.Drawing.Size(76, 21);
            this.inchLabel.TabIndex = 13;
            this.inchLabel.Text = "Inches";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel.Location = new System.Drawing.Point(243, 86);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(21, 21);
            this.mLabel.TabIndex = 12;
            this.mLabel.Text = "M";
            // 
            // cmLabel
            // 
            this.cmLabel.AutoSize = true;
            this.cmLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmLabel.Location = new System.Drawing.Point(139, 86);
            this.cmLabel.Name = "cmLabel";
            this.cmLabel.Size = new System.Drawing.Size(32, 21);
            this.cmLabel.TabIndex = 11;
            this.cmLabel.Text = "Cm";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(21, 86);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(65, 21);
            this.unitLabel.TabIndex = 10;
            this.unitLabel.Text = "Units";
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(218, 42);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(100, 20);
            this.mTextBox.TabIndex = 9;
            this.mTextBox.Enter += new System.EventHandler(this.mTextBox_Enter);
            this.mTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKey);
            // 
            // footTextBox
            // 
            this.footTextBox.Location = new System.Drawing.Point(430, 42);
            this.footTextBox.Name = "footTextBox";
            this.footTextBox.Size = new System.Drawing.Size(100, 20);
            this.footTextBox.TabIndex = 7;
            this.footTextBox.Enter += new System.EventHandler(this.footTextBox_Enter);
            this.footTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKey);
            // 
            // inchesTextBox
            // 
            this.inchesTextBox.Location = new System.Drawing.Point(324, 42);
            this.inchesTextBox.Name = "inchesTextBox";
            this.inchesTextBox.Size = new System.Drawing.Size(100, 20);
            this.inchesTextBox.TabIndex = 5;
            this.inchesTextBox.Enter += new System.EventHandler(this.inchesTextBox_Enter);
            this.inchesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKey);
            // 
            // cmTextBox
            // 
            this.cmTextBox.Location = new System.Drawing.Point(112, 42);
            this.cmTextBox.Name = "cmTextBox";
            this.cmTextBox.Size = new System.Drawing.Size(100, 20);
            this.cmTextBox.TabIndex = 3;
            this.cmTextBox.Enter += new System.EventHandler(this.cmTextBox_Enter);
            this.cmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKey);
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.Location = new System.Drawing.Point(6, 42);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitsTextBox.TabIndex = 1;
            this.unitsTextBox.Enter += new System.EventHandler(this.unitsTextBox_Enter);
            this.unitsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKey);
            // 
            // saveHistory
            // 
            this.saveHistory.Location = new System.Drawing.Point(478, 524);
            this.saveHistory.Name = "saveHistory";
            this.saveHistory.Size = new System.Drawing.Size(75, 23);
            this.saveHistory.TabIndex = 3;
            this.saveHistory.Text = "Save as file";
            this.saveHistory.UseVisualStyleBackColor = true;
            this.saveHistory.Click += new System.EventHandler(this.saveHistory_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.LinkArea = new System.Windows.Forms.LinkArea(12, 5);
            this.copyrightLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.copyrightLabel.Location = new System.Drawing.Point(237, 530);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(95, 17);
            this.copyrightLabel.TabIndex = 1;
            this.copyrightLabel.TabStop = true;
            this.copyrightLabel.Text = "2016-2018 © Split";
            this.copyrightLabel.UseCompatibleTextRendering = true;
            this.copyrightLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.copyrightLabel_LinkClicked);
            // 
            // helpLink
            // 
            this.helpLink.AutoSize = true;
            this.helpLink.Location = new System.Drawing.Point(17, 529);
            this.helpLink.Name = "helpLink";
            this.helpLink.Size = new System.Drawing.Size(29, 13);
            this.helpLink.TabIndex = 4;
            this.helpLink.TabStop = true;
            this.helpLink.Text = "Help";
            this.helpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 561);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(590, 600);
            this.MinimumSize = new System.Drawing.Size(590, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Hammer Unit Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.DataGridView historyDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox footTextBox;
        private System.Windows.Forms.TextBox inchesTextBox;
        private System.Windows.Forms.TextBox cmTextBox;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label inchLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label cmLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.RadioButton unitsRadioButton;
        private System.Windows.Forms.RadioButton cmRadioButton;
        private System.Windows.Forms.RadioButton footRadioButton;
        private System.Windows.Forms.RadioButton inchesRadioButton;
        private System.Windows.Forms.RadioButton mRadioButton;
        private System.Windows.Forms.Button saveHistory;
        private System.Windows.Forms.LinkLabel copyrightLabel;
        private System.Windows.Forms.LinkLabel helpLink;
    }
}

