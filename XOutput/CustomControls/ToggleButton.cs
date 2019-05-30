using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ToggleButton : CheckBox
{
    /*************************************************************************************************
    *** Variables
    *************************************************************************************************/
    private bool setAutoSize;

    /*************************************************************************************************
    *** Constructor
    *************************************************************************************************/
    public ToggleButton()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        Padding = new Padding(6);
        FillColor = Color.DarkGray;
        KnobOnColor = Color.DodgerBlue;
        KnobOffColor = Color.DimGray;
    }

    /*************************************************************************************************
    *** OnPaint
    *************************************************************************************************/
    protected override void OnPaint(PaintEventArgs e)
    {
        OnPaintBackground(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = new GraphicsPath())
        {
            int padding = Padding.All;
            int r = Height - 2 * padding;

            path.AddArc(padding, padding, r, r, 90, 180);
            path.AddArc(Width - r - padding, padding, r, r, -90, 180);
            path.CloseFigure();

            e.Graphics.FillPath(new SolidBrush(FillColor), path);
            r = Height - 1;

            Rectangle rectangle = Checked ? new Rectangle(Width - r - 1, 0, r, r) : new Rectangle(0, 0, r, r);

            e.Graphics.FillEllipse(Checked ? new SolidBrush(KnobOnColor) : new SolidBrush(KnobOffColor), rectangle);
        }
    }

    /*************************************************************************************************
    *** Properties
    *************************************************************************************************/
    public override bool AutoSize
    {
        get => base.AutoSize;

        set
        {
            // This is to default to false, if you do it in the constructor it will be overwritten
            if (!setAutoSize)
                setAutoSize = true;
            else
                base.AutoSize = value;
        }
    }

    [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "DarkGray")]
    public Color FillColor { get; set; }

    [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "DodgerBlue")]
    public Color KnobOnColor { get; set; }

    [Browsable(true), Category("Appearance"), DefaultValue(typeof(Color), "DimGray")]
    public Color KnobOffColor { get; set; }
}
