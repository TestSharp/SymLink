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
            this.darkThemeSelectBtn = new System.Windows.Forms.Button();
            this.lightThemeSelectBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Theme:";
            // 
            // darkThemeSelectBtn
            // 
            this.darkThemeSelectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.darkThemeSelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.darkThemeSelectBtn.FlatAppearance.BorderSize = 2;
            this.darkThemeSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkThemeSelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.darkThemeSelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.darkThemeSelectBtn.Location = new System.Drawing.Point(40, 85);
            this.darkThemeSelectBtn.Name = "darkThemeSelectBtn";
            this.darkThemeSelectBtn.Size = new System.Drawing.Size(75, 50);
            this.darkThemeSelectBtn.TabIndex = 1;
            this.darkThemeSelectBtn.Text = "Dark";
            this.darkThemeSelectBtn.UseVisualStyleBackColor = false;
            this.darkThemeSelectBtn.MouseEnter += new System.EventHandler(this.controlButtons_MouseEnter);
            this.darkThemeSelectBtn.MouseLeave += new System.EventHandler(this.controlButtons_MouseLeave);
            // 
            // lightThemeSelectBtn
            // 
            this.lightThemeSelectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lightThemeSelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightThemeSelectBtn.FlatAppearance.BorderSize = 2;
            this.lightThemeSelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightThemeSelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lightThemeSelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lightThemeSelectBtn.Location = new System.Drawing.Point(135, 85);
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
            this.panel1.Controls.Add(this.darkThemeSelectBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lightThemeSelectBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 194);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThemeChangerForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThemeChangerForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThemeChangerForm_MouseUp);
            // 
            // ThemeSelectorMessageBox
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 200);
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
        private System.Windows.Forms.Button darkThemeSelectBtn;
        private System.Windows.Forms.Button lightThemeSelectBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
