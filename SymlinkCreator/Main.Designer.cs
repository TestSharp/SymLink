namespace SymlinkCreator
{
    partial class Main
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_Link = new System.Windows.Forms.TextBox();
            this.button_BrowseLink = new System.Windows.Forms.Button();
            this.label_Type = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label_Link = new System.Windows.Forms.Label();
            this.label_Source = new System.Windows.Forms.Label();
            this.textBox_Target = new System.Windows.Forms.TextBox();
            this.button_BrowseTarget = new System.Windows.Forms.Button();
            this.textBox_CMDCommand = new System.Windows.Forms.TextBox();
            this.label_CMDCommand = new System.Windows.Forms.Label();
            this.button_CreateLink = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.closeButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Link
            // 
            this.textBox_Link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.textBox_Link.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Link.ForeColor = System.Drawing.Color.Black;
            this.textBox_Link.Location = new System.Drawing.Point(165, 139);
            this.textBox_Link.Name = "textBox_Link";
            this.textBox_Link.Size = new System.Drawing.Size(263, 20);
            this.textBox_Link.TabIndex = 0;
            // 
            // button_BrowseLink
            // 
            this.button_BrowseLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_BrowseLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BrowseLink.FlatAppearance.BorderSize = 0;
            this.button_BrowseLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BrowseLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_BrowseLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_BrowseLink.Location = new System.Drawing.Point(449, 133);
            this.button_BrowseLink.Name = "button_BrowseLink";
            this.button_BrowseLink.Size = new System.Drawing.Size(60, 30);
            this.button_BrowseLink.TabIndex = 1;
            this.button_BrowseLink.Tag = "Link";
            this.button_BrowseLink.Text = "Browse";
            this.button_BrowseLink.UseVisualStyleBackColor = false;
            this.button_BrowseLink.Click += new System.EventHandler(this.button_Browse_Click);
            this.button_BrowseLink.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.button_BrowseLink.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Type.Location = new System.Drawing.Point(32, 104);
            this.label_Type.Margin = new System.Windows.Forms.Padding(3);
            this.label_Type.Name = "label_Type";
            this.label_Type.Padding = new System.Windows.Forms.Padding(3);
            this.label_Type.Size = new System.Drawing.Size(88, 19);
            this.label_Type.TabIndex = 2;
            this.label_Type.Text = "Type of Link:";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(165, 101);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(263, 21);
            this.comboBox_Type.TabIndex = 3;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // label_Link
            // 
            this.label_Link.AutoSize = true;
            this.label_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Link.Location = new System.Drawing.Point(32, 142);
            this.label_Link.Name = "label_Link";
            this.label_Link.Padding = new System.Windows.Forms.Padding(3);
            this.label_Link.Size = new System.Drawing.Size(117, 19);
            this.label_Link.TabIndex = 4;
            this.label_Link.Text = "Destination (Link):";
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Source.Location = new System.Drawing.Point(32, 184);
            this.label_Source.Name = "label_Source";
            this.label_Source.Padding = new System.Windows.Forms.Padding(3);
            this.label_Source.Size = new System.Drawing.Size(106, 19);
            this.label_Source.TabIndex = 5;
            this.label_Source.Text = "Source (Target):";
            // 
            // textBox_Target
            // 
            this.textBox_Target.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.textBox_Target.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Target.ForeColor = System.Drawing.Color.Black;
            this.textBox_Target.Location = new System.Drawing.Point(165, 181);
            this.textBox_Target.Name = "textBox_Target";
            this.textBox_Target.Size = new System.Drawing.Size(263, 20);
            this.textBox_Target.TabIndex = 6;
            // 
            // button_BrowseTarget
            // 
            this.button_BrowseTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_BrowseTarget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BrowseTarget.FlatAppearance.BorderSize = 0;
            this.button_BrowseTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BrowseTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_BrowseTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_BrowseTarget.Location = new System.Drawing.Point(449, 175);
            this.button_BrowseTarget.Name = "button_BrowseTarget";
            this.button_BrowseTarget.Size = new System.Drawing.Size(60, 30);
            this.button_BrowseTarget.TabIndex = 7;
            this.button_BrowseTarget.Tag = "Target";
            this.button_BrowseTarget.Text = "Browse";
            this.button_BrowseTarget.UseVisualStyleBackColor = false;
            this.button_BrowseTarget.Click += new System.EventHandler(this.button_Browse_Click);
            this.button_BrowseTarget.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.button_BrowseTarget.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // textBox_CMDCommand
            // 
            this.textBox_CMDCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.textBox_CMDCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CMDCommand.ForeColor = System.Drawing.Color.Black;
            this.textBox_CMDCommand.Location = new System.Drawing.Point(165, 234);
            this.textBox_CMDCommand.Multiline = true;
            this.textBox_CMDCommand.Name = "textBox_CMDCommand";
            this.textBox_CMDCommand.Size = new System.Drawing.Size(284, 138);
            this.textBox_CMDCommand.TabIndex = 8;
            this.textBox_CMDCommand.Click += new System.EventHandler(this.textBox_CMDCommand_Click);
            // 
            // label_CMDCommand
            // 
            this.label_CMDCommand.AutoSize = true;
            this.label_CMDCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CMDCommand.Location = new System.Drawing.Point(32, 237);
            this.label_CMDCommand.Name = "label_CMDCommand";
            this.label_CMDCommand.Padding = new System.Windows.Forms.Padding(3);
            this.label_CMDCommand.Size = new System.Drawing.Size(102, 19);
            this.label_CMDCommand.TabIndex = 9;
            this.label_CMDCommand.Text = "CMD Command:";
            // 
            // button_CreateLink
            // 
            this.button_CreateLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_CreateLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CreateLink.FlatAppearance.BorderSize = 0;
            this.button_CreateLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_CreateLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_CreateLink.Location = new System.Drawing.Point(35, 312);
            this.button_CreateLink.Name = "button_CreateLink";
            this.button_CreateLink.Size = new System.Drawing.Size(90, 60);
            this.button_CreateLink.TabIndex = 10;
            this.button_CreateLink.Text = "Create Link";
            this.button_CreateLink.UseVisualStyleBackColor = false;
            this.button_CreateLink.Click += new System.EventHandler(this.button_CreateLink_Click);
            this.button_CreateLink.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.button_CreateLink.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeButton.Location = new System.Drawing.Point(510, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 13;
            this.closeButton.Tag = "Link";
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.helpButton.Location = new System.Drawing.Point(440, 0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(30, 30);
            this.helpButton.TabIndex = 14;
            this.helpButton.Tag = "Link";
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.button_Help_Click);
            this.helpButton.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.helpButton.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "SymLink Creator";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonMinimize.Location = new System.Drawing.Point(475, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(30, 30);
            this.buttonMinimize.TabIndex = 16;
            this.buttonMinimize.Tag = "Link";
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.settingsButton.Location = new System.Drawing.Point(370, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(65, 30);
            this.settingsButton.TabIndex = 17;
            this.settingsButton.Tag = "Link";
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.buttonSettings_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(540, 396);
            this.ControlBox = false;
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label_CMDCommand);
            this.Controls.Add(this.label_Source);
            this.Controls.Add(this.label_Link);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.button_CreateLink);
            this.Controls.Add(this.textBox_Target);
            this.Controls.Add(this.textBox_Link);
            this.Controls.Add(this.textBox_CMDCommand);
            this.Controls.Add(this.button_BrowseLink);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.button_BrowseTarget);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Symlink Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox textBox_Link;
        public System.Windows.Forms.Button button_BrowseLink;
        public System.Windows.Forms.Label label_Type;
        public System.Windows.Forms.ComboBox comboBox_Type;
        public System.Windows.Forms.Label label_Link;
        public System.Windows.Forms.Label label_Source;
        public System.Windows.Forms.TextBox textBox_Target;
        public System.Windows.Forms.Button button_BrowseTarget;
        public System.Windows.Forms.TextBox textBox_CMDCommand;
        public System.Windows.Forms.Label label_CMDCommand;
        public System.Windows.Forms.Button button_CreateLink;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Button helpButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonMinimize;
        public System.Windows.Forms.Button settingsButton;
    }
}

