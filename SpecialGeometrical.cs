using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class SpecialGeometrical : Panel
{
    #region Variables
    Timer AnimationTimer = new Timer { Interval = 1 };
    FontManager font = new FontManager();
    StringFormat SF = new StringFormat();
    Rectangle R;
    bool done = false;
    bool reverse = false;
    public bool specialPropr = false;
    public bool AnimationStatusActive = false;
    float SizeAnimation = 0;
    Color EnabledBGColor = ColorTranslator.FromHtml("#fafafa");//#0c0007
    Graphics G;
    Color StringColor;
    #endregion
    #region Events
    [Category("Custom")]
    [Browsable(true)]
    [Description("Help you to create a transition effect on the current form .")]
    public Color AnimationColor { get; set; }
    public void StartTheAnimation()
    {
        this.BringToFront();
        this.AnimationStatusActive = true;
        AnimationTimer.Start();
        this.Invalidate();
    }    
    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        R = new Rectangle(0, 0, Width, Height);
    }
    public void MaintainTheGraphics()
    {
        G.SmoothingMode = SmoothingMode.AntiAlias;
        G.TextRenderingHint = TextRenderingHint.AntiAlias;
        G.InterpolationMode = InterpolationMode.HighQualityBilinear;

        var BG = DrawHelper.CreateRoundRect(1, 1, Width, Height, 1);
        G.FillPath(new SolidBrush(Enabled ? EnabledBGColor : Color.Brown), BG);
        G.DrawPath(new Pen(Enabled ? Color.Ivory : Color.Brown), BG);
        Region region = new Region(BG);

        G.SetClip(region, CombineMode.Replace);
        G.DrawString(Text, base.Font, new SolidBrush(Color.White), R, SF);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        G = e.Graphics;
        if (done == false)
        {
            done = true;
            StringColor = Color.Black;
        }
        this.MaintainTheGraphics();
        if (this.reverse == true)
        {
            G.FillEllipse(new SolidBrush(Color.FromArgb(255, this.AnimationColor)), 0, 0, SizeAnimation - 34, SizeAnimation - 34);
        }
        else
        {
            G.FillRectangle(new SolidBrush(Color.FromArgb(255, this.AnimationColor)), 0, 0, SizeAnimation, SizeAnimation);
        }
    }
    protected void AnimationTick(object sender, EventArgs e)
    {
        if (AnimationStatusActive)
        {
            if (SizeAnimation < Width + 300)
            {
                SizeAnimation += Width / 10;
                this.Invalidate();
            }
            else
            {
                this.AnimationStatusActive = false;
                this.reverse = true;
            }
        }
        if (reverse == true)
        {
            if (SizeAnimation != 0)
            {
                SizeAnimation -= Width / 10;
                this.Invalidate();
            }
            else
            {
                this.reverse = false;
                if (this.specialPropr)
                {
                    this.Dispose();
                }
                this.SendToBack();
            }
        }
    }
    #endregion
    #region Contructor
    public SpecialGeometrical()
    {
        SetStyle((ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint), true);
        DoubleBuffered = true;
        Size = new Size(143, 41);

        //String format variable is populated with the align and linealign 
        SF.Alignment = StringAlignment.Center;
        SF.LineAlignment = StringAlignment.Center;
        //-end of the cometary
        AnimationTimer.Tick += new EventHandler(AnimationTick);
    }
    #endregion
}

