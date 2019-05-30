using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XOutput
{
     public class CustomComboBox : ComboBox
     {
          private const int WM_PAINT = 0xF;
          private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;

          public CustomComboBox()
          {
               BorderColor = Color.DimGray;
               FlatStyle = FlatStyle.Flat;
               BorderWidth = 1;
          }

          protected override void WndProc(ref Message m)
          {
               base.WndProc(ref m);

               if (m.Msg == WM_PAINT)
               {
                    using (Graphics g = Graphics.FromHwnd(Handle))
                    {
                         // Uncomment this if you don't want the 'highlight border'
                         using (Pen p = new Pen(BorderColor, BorderWidth))
                              g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);

                         //using (Pen p = new Pen(BorderColor, 2))
                         //     g.DrawRectangle(p, 2, 2, Width - buttonWidth - 4, Height - 4);

                         // Draw an image on dropdown button
                         g.DrawImageUnscaled(Properties.Resources.dropdown, Width - buttonWidth - 1, 1);
                    }
               }
          }

          [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "DimGray")]
          public Color BorderColor { get; set; }

          [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "1")]
          public int BorderWidth { get; set; }
     }
}
