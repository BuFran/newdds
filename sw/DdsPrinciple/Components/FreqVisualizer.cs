using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DdsPrinciple.Mathematics;

namespace DdsPrinciple.Components
{
    public class FreqVisualizer : UserControl
    {
        public FreqVisualizer()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            Points.Add(new FreqPoint() { Frequency = 500, Amplitude = 1 });
        }

        

        private int GetX(double freq)
        {
            double dispw = Width - _LeftSpace - _RightSpace;
            return (int)(dispw * (freq - _MinFreq) / (_MaxFreq - _MinFreq))+_LeftSpace;
        }

        private int GetY(double ampl)
        {
            ampl = 10 * Math.Log(ampl);
            double disph = Height - _BottomSpace - _TopSpace;
            return Height - _BottomSpace - (int)(disph * (ampl - _MinAmpl) / (_MaxAmpl - _MinAmpl));
        }


        private void DrawAxisLabel(Graphics g, string text, int pos, Color color)
        {
            Size s = TextRenderer.MeasureText(g, text, Font);
            TextRenderer.DrawText(g, text, Font, new Point(pos - s.Width / 2, Height - _BottomSpace), color);  
        }

        private void DrawFreqPoint(Graphics g,FreqPoint fp)
        {
            int ptx = GetX(fp.Frequency);
            int pty = GetY(fp.Amplitude);

            Color outer=Color.Red;
            Color inner=Color.Blue;

            using (Brush b =new SolidBrush(inner))
                g.FillEllipse(b, ptx - _StemSize, pty - _StemSize, _StemSize * 2, _StemSize * 2);

            using (Pen p = new Pen(outer, 1))
            {
                g.DrawEllipse(p, ptx - _StemSize, pty - _StemSize, _StemSize * 2, _StemSize * 2);
                g.DrawLine(p, ptx, Height - _BottomSpace, ptx, pty + _StemSize);
            }

            DrawAxisLabel(g, fp.Frequency.ToString("F0")+"Hz", ptx, outer);                
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int zerox = GetX(0);

            e.Graphics.DrawLine(Pens.Black, _LeftSpace, Height - _BottomSpace, Width - _RightSpace, Height - _BottomSpace); // X axis

            // Y axis
            if ((_MinFreq <= 0) && (_MaxFreq >= 0))
                e.Graphics.DrawLine(Pens.Black, zerox, Height - _BottomSpace, zerox, _TopSpace); 
            else
                e.Graphics.DrawLine(Pens.Gray, _LeftSpace, Height - _BottomSpace, _LeftSpace, _TopSpace);

            foreach (FreqPoint fp in Points)
                DrawFreqPoint(e.Graphics, fp);

            DrawAxisLabel(e.Graphics, _MinFreq.ToString("F0") + "Hz", 10, Color.Black);
            DrawAxisLabel(e.Graphics, _MaxFreq.ToString("F0") + "Hz", Width - 10, Color.Black);
            if (zerox != 0)
                DrawAxisLabel(e.Graphics, "0", zerox, Color.Black);
        }

        public void AutorangeY()
        {
            double max = double.MinValue;
            
            foreach (FreqPoint fp in Points)
                max = Math.Max(max, fp.Amplitude);

            if (max == double.MinValue)
                max = 1;

            _MinAmpl = 10 * Math.Log(max/100);
            _MaxAmpl = 10 * Math.Log(max);
        }

        private double _MinFreq = 0;
        private double _MaxFreq = 1000;

        private double _MinAmpl = 10 * Math.Log(0.01);
        private double _MaxAmpl = 10 * Math.Log(1);

        public double MaxLevel
        {
            get { return Math.Exp(_MaxAmpl/10); }
            set 
            { 
                _MaxAmpl = 10 * Math.Log(value/100);
                _MinAmpl = 10 * Math.Log(value);
                Invalidate();
            }
        }
        private int _BottomSpace = 20;
        private int _TopSpace = 10;
        private int _LeftSpace = 10;
        private int _RightSpace = 10;
        private int _StemSize = 3;

        public double MinFreq
        {
            get { return _MinFreq; }
            set { _MinFreq = value; Invalidate(); }
        }
        
        public double MaxFreq
        {
            get { return _MaxFreq; }
            set { _MaxFreq = value; Invalidate(); }
        }

        public List<FreqPoint> Points = new List<FreqPoint>();

    }
}
