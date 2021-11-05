using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem3_lab1.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox : UserControl
    {
        #region -> Fields
        
        private Color borderColor = Color.LightSeaGreen;
        private Color borderFocusColor = Color.Goldenrod;
        private int borderSize = 2;
        private int borderFocusedSize = 3;
        private int borderRadius = 0;
        private bool underlinedStyle = false;
        private bool isFocused = false;

        #endregion


        #region -> Events

        public event EventHandler _TextChanged;
        
        #endregion


        #region -> Constructor
        
        public CustomTextBox()
        {
            InitializeComponent();
        }

        #endregion


        #region -> Properties

        [Category("Custom Advance")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Advance")]
        public Color BorderFocusColor 
        {
            get => borderFocusColor;
            set => borderFocusColor = value;
        }

        [Category("Custom Advance")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom Advance")]
        public int BorderFocusedSize
        {
            get => borderFocusedSize;
            set
            {
                borderFocusedSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom Advance")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Custom Advance")]
        public bool PasswordChar
        {
            get => textBox1.UseSystemPasswordChar;
            set => textBox1.UseSystemPasswordChar = value;
        }

        [Category("Custom Advance")]
        public bool Multiline
        {
            get => textBox1.Multiline;
            set => textBox1.Multiline = value;
        }

        [Category("Custom Advance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("Custom Advance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Custom Advance")]
        public override Font Font 
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Custom Advance")]
        public string Texts
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        [Category("Custom Advance")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
                
            }
        }

        #endregion


        #region -> Overridden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1 && !isFocused)  // Rounded TextBox
            {
                // Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -BorderSize, -BorderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    // Drawing
                    this.Region = new Region(pathBorderSmooth);  // Set the rounded region UserControl
                    
                    if (borderRadius > 15)
                        SetTextBoxRoundedRegion();  //Set the rounded region of TextBox componet

                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = PenAlignment.Inset;
                    
                    if (isFocused)
                        penBorder.Color = borderFocusColor;

                    if (underlinedStyle)  // Line Style
                    {
                        // Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        // Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else  // Normal Style
                    {
                        // Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        // Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else  // Square/Normal TextBox
            {
                // Draw border
                using (Pen penBorder = new Pen(borderColor, isFocused ? borderFocusedSize : borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;
                    if (isFocused)
                        penBorder.Color = borderFocusColor;

                    if (underlinedStyle)  // Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else  // Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);

                }
            }

            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        #endregion


        #region -> Private methods

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathText;
            if (Multiline)
            {
                pathText = GetFigurePath(textBox1.ClientRectangle, BorderRadius - borderSize);
                textBox1.Region = new Region(pathText);
            }
            else
            {
                pathText = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathText);
            }
        }

        #endregion


        #region TextBox events

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        #endregion
    }
}
