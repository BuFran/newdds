using DdsPrinciple.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DdsPrinciple
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RefShape.SelectedIndex = 0;
        }

        private void RefRange_ValueChanged(object sender, EventArgs e)
        {
            RefDisplay.MinFreq = (double)RefMin.Value;
            RefDisplay.MaxFreq = (double)RefMax.Value;
            InDisplay.MinFreq = (double)RefMin.Value;
            InDisplay.MaxFreq = (double)RefMax.Value;
            MixDisplay.MinFreq = (double)RefMin.Value;
            MixDisplay.MaxFreq = (double)RefMax.Value;
        }

        private void OutRange_ValueChanged(object sender, EventArgs e)
        {
            OutDisplay.MinFreq = (double)OutMin.Value;
            OutDisplay.MaxFreq = (double)OutMax.Value;
        }

        private void RefTune_Scroll(object sender, EventArgs e)
        {
            RegenerateRef();
        }

        private void RefFreq_ValueChanged(object sender, EventArgs e)
        {
            RegenerateRef();
        }

        private void RefShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegenerateRef();
        }

        void RegenerateRef()
        {
            RefDisplay.Points.Clear();
            switch (RefShape.SelectedIndex)
            {
                case 0: // sine
                    Dds.GenerateSine(RefDisplay.Points, (double)RefFreq.Value + RefTune.Value, 1);
                    break;
                case 1: // square
                    Dds.GenerateSquare(RefDisplay.Points, (double)RefFreq.Value + RefTune.Value, 1);
                    break;
            }
            RefDisplay.AutorangeY();
            Dds.FilterInvisible(RefDisplay.Points, RefDisplay.MinFreq, RefDisplay.MaxFreq);
            Dds.FilterUnderLevel(RefDisplay.Points, RefDisplay.MaxLevel/100);
            
            RefDisplay.Invalidate();

            RecomputeMix();
        }

        void RecomputeMix()
        {
            MixDisplay.Points.Clear();
            Dds.MixSignals(MixDisplay.Points, InDisplay.Points, RefDisplay.Points);
            MixDisplay.AutorangeY();

            Dds.FilterInvisible(MixDisplay.Points, MixDisplay.MinFreq, MixDisplay.MaxFreq);
            Dds.FilterUnderLevel(MixDisplay.Points, MixDisplay.MaxLevel / 100);

            MixDisplay.Invalidate();
        }


        

        

        
    }
}
