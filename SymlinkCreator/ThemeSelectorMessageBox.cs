using System;
using System.Drawing;
using System.Windows.Forms;

namespace SymlinkCreator
{
    public partial class ThemeSelectorMessageBox : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        public ThemeSelectorMessageBox( )
        {
            InitializeComponent( );

            consoleThemeSelectBtn.DialogResult = DialogResult.Yes;
            lightThemeSelectBtn.DialogResult = DialogResult.No;
            colorThemeButton.DialogResult = DialogResult.OK;
            autumnThemeButton.DialogResult = DialogResult.Cancel;
        }

        private void SwitchForeAndBackButtonColors( Button button )
        {
            Color currentBackColor = button.BackColor;
            Color currentForeColor = button.ForeColor;

            button.BackColor = currentForeColor;
            button.ForeColor = currentBackColor;
        }

        private void controlButtons_MouseEnter( object sender, EventArgs e )
        {
            Button button = sender as Button;

            if ( button != null )
            {
                SwitchForeAndBackButtonColors( button );
            }
        }

        private void controlButtons_MouseLeave( object sender, EventArgs e )
        {
            Button button = sender as Button;

            if ( button != null )
            {
                SwitchForeAndBackButtonColors( button );
            }
        }

        // Get location of window when mouse button is pushed on the form
        private void ThemeChangerForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        // if the mouse button is pushed, and the form is dragged move the form where the mouse moves
        private void ThemeChangerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if( mouseDown )
            {
                Location = new Point( ( Location.X - lastLocation.X ) + e.X, ( Location.Y - lastLocation.Y ) + e.Y );

                Update();
            }
        }

        // When mouse button is released, set the mouseDown field to false
        private void ThemeChangerForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
