namespace SymlinkCreator
{
    partial class ThemeSelectorMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.label1 = new System.Windows.Forms.Label();
            this.consoleThemeSelectBtn = new System.Windows.Forms.Button();
            this.lightThemeSelectBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorThemeButton = new System.Windows.Forms.Button();
            this.autumnThemeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Theme:";
            // 
            // consoleThemeSelectBtn
            // 
            this.consoleThemeSelectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.consoleThemeSelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consoleThemeSelectBtn.FlatAppearance.BorderSize = 2;
            this.consoleThemeSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consoleThemeSelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.consoleThemeSelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(182)))), ((int)(((byte)(16)))));
            this.consoleThemeSelectBtn.Location = new System.Drawing.Point(55, 100);
            this.consoleThemeSelectBtn.Name = "consoleThemeSelectBtn";
            this.consoleThemeSelectBtn.Size = new System.Drawing.Size(75, 50);
            this.consoleThemeSelectBtn.TabIndex = 1;
            this.consoleThemeSelectBtn.Text = "Console";
            this.consoleThemeSelectBtn.UseVisualStyleBackColor = false;
            this.consoleThemeSelectBtn.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.consoleThemeSelectBtn.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // lightThemeSelectBtn
            // 
            this.lightThemeSelectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lightThemeSelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightThemeSelectBtn.FlatAppearance.BorderSize = 2;
            this.lightThemeSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightThemeSelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lightThemeSelectBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lightThemeSelectBtn.Location = new System.Drawing.Point(150, 100);
            this.lightThemeSelectBtn.Name = "lightThemeSelectBtn";
            this.lightThemeSelectBtn.Size = new System.Drawing.Size(75, 50);
            this.lightThemeSelectBtn.TabIndex = 2;
            this.lightThemeSelectBtn.Text = "Light";
            this.lightThemeSelectBtn.UseVisualStyleBackColor = false;
            this.lightThemeSelectBtn.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.lightThemeSelectBtn.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.autumnThemeButton);
            this.panel1.Controls.Add(this.colorThemeButton);
            this.panel1.Controls.Add(this.consoleThemeSelectBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lightThemeSelectBtn);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 290);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThemeChangerForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThemeChangerForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThemeChangerForm_MouseUp);
            // 
            // colorThemeButton
            // 
            this.colorThemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(118)))));
            this.colorThemeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorThemeButton.FlatAppearance.BorderSize = 2;
            this.colorThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorThemeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.colorThemeButton.Location = new System.Drawing.Point(55, 180);
            this.colorThemeButton.Name = "colorThemeButton";
            this.colorThemeButton.Size = new System.Drawing.Size(75, 50);
            this.colorThemeButton.TabIndex = 3;
            this.colorThemeButton.Text = "Colorful";
            this.colorThemeButton.UseVisualStyleBackColor = false;
            this.colorThemeButton.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.colorThemeButton.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // autumnThemeButton
            // 
            this.autumnThemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(6)))));
            this.autumnThemeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autumnThemeButton.FlatAppearance.BorderSize = 2;
            this.autumnThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autumnThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autumnThemeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.autumnThemeButton.Location = new System.Drawing.Point(150, 180);
            this.autumnThemeButton.Name = "autumnThemeButton";
            this.autumnThemeButton.Size = new System.Drawing.Size(75, 50);
            this.autumnThemeButton.TabIndex = 4;
            this.autumnThemeButton.Text = "Autumn";
            this.autumnThemeButton.UseVisualStyleBackColor = false;
            this.autumnThemeButton.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.autumnThemeButton.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // ThemeSelectorMessageBox
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeSelectorMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button consoleThemeSelectBtn;
        private System.Windows.Forms.Button lightThemeSelectBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button colorThemeButton;
        private System.Windows.Forms.Button autumnThemeButton;
    }
}
