namespace WinFormProperties
{
    partial class mainForm
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
            this.targetButton = new System.Windows.Forms.Button();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borderStyleComboBox = new System.Windows.Forms.ComboBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.centerButton = new System.Windows.Forms.Button();
            this.enabledButton = new System.Windows.Forms.Button();
            this.visibleButton = new System.Windows.Forms.Button();
            this.formSizeLabel = new System.Windows.Forms.Label();
            this.controlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(0, 0);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(100, 100);
            this.targetButton.TabIndex = 0;
            this.targetButton.Text = "Target\r\nX=0\r\nY=0\r\n";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.LocationChanged += new System.EventHandler(this.posicionTargetButton);
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsGroupBox.Controls.Add(this.label1);
            this.controlsGroupBox.Controls.Add(this.borderStyleComboBox);
            this.controlsGroupBox.Controls.Add(this.leftButton);
            this.controlsGroupBox.Controls.Add(this.rightButton);
            this.controlsGroupBox.Controls.Add(this.downButton);
            this.controlsGroupBox.Controls.Add(this.upButton);
            this.controlsGroupBox.Controls.Add(this.centerButton);
            this.controlsGroupBox.Controls.Add(this.enabledButton);
            this.controlsGroupBox.Controls.Add(this.visibleButton);
            this.controlsGroupBox.Location = new System.Drawing.Point(575, 15);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(200, 500);
            this.controlsGroupBox.TabIndex = 1;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FormBorderStyle";
            // 
            // borderStyleComboBox
            // 
            this.borderStyleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderStyleComboBox.FormattingEnabled = true;
            this.borderStyleComboBox.Location = new System.Drawing.Point(33, 40);
            this.borderStyleComboBox.Name = "borderStyleComboBox";
            this.borderStyleComboBox.Size = new System.Drawing.Size(135, 32);
            this.borderStyleComboBox.TabIndex = 7;
            this.borderStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.borderStyleComboBox_SelectedIndexChanged);
            // 
            // leftButton
            // 
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(30, 268);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(46, 42);
            this.leftButton.TabIndex = 6;
            this.leftButton.Text = "◀";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(134, 268);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(46, 42);
            this.rightButton.TabIndex = 6;
            this.rightButton.Text = "▶";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // downButton
            // 
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(82, 290);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(46, 42);
            this.downButton.TabIndex = 6;
            this.downButton.Text = "▼";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(82, 242);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(46, 42);
            this.upButton.TabIndex = 5;
            this.upButton.Text = "▲";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // centerButton
            // 
            this.centerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerButton.Location = new System.Drawing.Point(33, 185);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(135, 30);
            this.centerButton.TabIndex = 4;
            this.centerButton.Text = "Center Target";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // enabledButton
            // 
            this.enabledButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabledButton.Location = new System.Drawing.Point(33, 140);
            this.enabledButton.Name = "enabledButton";
            this.enabledButton.Size = new System.Drawing.Size(135, 30);
            this.enabledButton.TabIndex = 3;
            this.enabledButton.Text = "Enabled = True";
            this.enabledButton.UseVisualStyleBackColor = true;
            this.enabledButton.Click += new System.EventHandler(this.enabledButton_Click);
            // 
            // visibleButton
            // 
            this.visibleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibleButton.Location = new System.Drawing.Point(33, 92);
            this.visibleButton.Name = "visibleButton";
            this.visibleButton.Size = new System.Drawing.Size(135, 30);
            this.visibleButton.TabIndex = 0;
            this.visibleButton.Text = "Visible = True";
            this.visibleButton.UseVisualStyleBackColor = true;
            this.visibleButton.Click += new System.EventHandler(this.visibleButton_Click);
            // 
            // formSizeLabel
            // 
            this.formSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formSizeLabel.AutoSize = true;
            this.formSizeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formSizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formSizeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formSizeLabel.Location = new System.Drawing.Point(20, 530);
            this.formSizeLabel.Name = "formSizeLabel";
            this.formSizeLabel.Size = new System.Drawing.Size(103, 15);
            this.formSizeLabel.TabIndex = 3;
            this.formSizeLabel.Text = "Form Size : 800,600";
            this.formSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.formSizeLabel);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.targetButton);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Winforms Components - Common Controls";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.LocationChanged += new System.EventHandler(this.formMovido);
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox borderStyleComboBox;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Button enabledButton;
        private System.Windows.Forms.Button visibleButton;
        private System.Windows.Forms.Label formSizeLabel;
    }
}

