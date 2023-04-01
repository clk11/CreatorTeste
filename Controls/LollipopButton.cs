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
public class LollipopButton : Button
{
    #region Variables
    Timer AnimationTimer = new Timer { Interval = 1 };
    FontManager font = new FontManager();
    StringFormat SF = new StringFormat();
    Rectangle R;
    bool done = false;
    bool reverse = false;
    bool AnimationStatusActive = false;
    float SizeAnimation = 0;
    Graphics G;
    Color StringColor;
    #endregion
    #region Events
    [Category("Custom")]
    [Browsable(true)]
    [Description("Here you can change the color for the button back color .")]
    public Color RobitaBackColor { get; set; }
    [Category("Custom")]
    [Browsable(true)]
    [Description("Here you can change the color for the button animation .")]
    public Color RobitaAniamtionColor{ get; set; }
    [Browsable(false)]
    public override Color BackColor
{
	  get 
	{ 
		 return base.BackColor;
	}
	  set 
	{ 
		base.BackColor = value;
	}
}
    [Browsable(false)]
    public override Color ForeColor
{
	  get 
	{ 
		 return base.ForeColor;
	}
	  set 
	{ 
		base.ForeColor = value;
	}
}
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);  
        this.AnimationStatusActive = true;
        AnimationTimer.Start();
        Invalidate();
        this.Invalidate();
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        this.AnimationStatusActive = false;
        this.reverse = true;
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

        var BG = DrawHelper.CreateRoundRect(1, 1, Width , Height , 1);
        G.FillPath(new SolidBrush(Enabled ? this.RobitaBackColor : Color.Brown), BG);
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
            G.FillRectangle(new SolidBrush(Color.FromArgb(100, this.RobitaAniamtionColor)), (this.Width-this.Width), this.Height - this.Height, SizeAnimation - 34, SizeAnimation - 34);
        }
        else
        {
            G.FillRectangle(new SolidBrush(Color.FromArgb(100, this.RobitaAniamtionColor)), (this.Width - this.Width), this.Height - this.Height, SizeAnimation, SizeAnimation);
        }        
    }   
    protected void AnimationTick(object sender, EventArgs e)
    {
        if (AnimationStatusActive)
        {
            if (SizeAnimation < Width + 300)
            {
                SizeAnimation += Width / 34;
                this.Invalidate();
            }
            else
            {
                this.AnimationStatusActive = false;
            }
        }
        if (reverse == true) 
        {
            if (SizeAnimation!=0)
            {
                SizeAnimation -= Width / 34;
                this.Invalidate();
            }
            else
            {
                this.reverse = false;
            }
        }
    }
    #endregion
    #region Contructor
    public LollipopButton()
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

