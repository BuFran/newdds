using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DdsPrinciple.Mathematics
{
    public struct FreqPoint
    {
        public double Frequency;
        public double Amplitude;
        public int InnerID;
        public int OuterID;
    }

    static class Dds
    {
        public static void GenerateSine(List<FreqPoint> points,double freq, double ampl)
        {
            points.Add(new FreqPoint() { Frequency = freq, Amplitude = ampl });
        }

        public static void GenerateSquare(List<FreqPoint> points, double freq, double ampl)
        {
            for (int i = 1; i < 200; i+=2)
            {
                points.Add(new FreqPoint() { Frequency = i*freq, Amplitude = ampl*2/(Math.PI*i) });
            }
        }

        public static void FilterInvisible(List<FreqPoint> points, double minf, double maxf)
        {
            for (int i = points.Count - 1; i >= 0; i--)
                if ((points[i].Frequency > maxf) || (points[i].Frequency < minf))
                    points.RemoveAt(i);
        }

        public static void FilterUnderLevel(List<FreqPoint> points, double level)
        {
            for (int i = points.Count - 1; i >= 0; i--)
                if (points[i].Amplitude < level)
                    points.RemoveAt(i);
        }

        public static void MixSignals(List<FreqPoint> outport, List<FreqPoint> inport, List<FreqPoint> refport)
        {
            foreach (FreqPoint in1 in inport)
                foreach (FreqPoint ref1 in refport)
                {
                    outport.Add(new FreqPoint() { Frequency = in1.Frequency + ref1.Frequency, Amplitude = in1.Amplitude * ref1.Amplitude });
                    outport.Add(new FreqPoint() { Frequency = in1.Frequency - ref1.Frequency, Amplitude = in1.Amplitude * ref1.Amplitude });
                    outport.Add(new FreqPoint() { Frequency = in1.Frequency, Amplitude = in1.Amplitude });
                    outport.Add(new FreqPoint() { Frequency = ref1.Frequency, Amplitude = ref1.Amplitude });
                }
        }
    }
}
