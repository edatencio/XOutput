using System.Drawing;
using System.Windows.Forms;

namespace XOutput.Forms
{
     public partial class NewXOut : Form
     {
          /*************************************************************************************************
          *** Variables
          *************************************************************************************************/
          private Point previousMousePosition;

          /*************************************************************************************************
          *** Constructor
          *************************************************************************************************/
          public NewXOut()
          {
               InitializeComponent();

               //ControllerComboBox1.SelectedIndex = 1;
          }

          /*************************************************************************************************
          *** Events
          *************************************************************************************************/
          private void TitleBar_MouseMove(object sender, MouseEventArgs e)
          {
               if (e.Button == MouseButtons.Left)
               {
                    Point newPosition = Location;
                    newPosition.X += MousePosition.X - previousMousePosition.X;
                    newPosition.Y += MousePosition.Y - previousMousePosition.Y;
                    Location = newPosition;
               }

               previousMousePosition = Control.MousePosition;
          }

          private void CloseButton_MouseClick(object sender, MouseEventArgs e)
          {
               Application.Exit();
          }

          private void MinimizeButton_MouseClick(object sender, MouseEventArgs e)
          {
               WindowState = FormWindowState.Minimized;
          }

          protected override CreateParams CreateParams
          {
               get
               {
                    CreateParams handleParam = base.CreateParams;
                    handleParam.ExStyle |= 0x02000000;
                    return handleParam;
               }
          }

          private void customComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
          {
          }
     }
}
