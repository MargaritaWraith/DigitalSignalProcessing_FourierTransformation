using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPF
{
    static class Fourier
    {
        public static void Test()
        {
            var s = DigitalSignal.Discret(0.1, 100, Function);
            var S = s.GetSpectrum();

            s.SaveToFile("Signal.txt");
            S.SaveToFile("Spectr.txt");

            s = DigitalSignal.LoadFromFile("Signal.txt");
            s.Print();
            Console.ReadLine();
            Console.Clear();
            DigitalSpectrum.LoadFromFile("Spectr.txt").Print();

        }

        private static double Function(double x) { return Math.Cos(2 * Math.PI * 1 * x); }

        public static ComplexNumber[] Transform(double[] s)
        {
            ComplexNumber[] result = new ComplexNumber[s.Length];
            double k = 2 * Math.PI / s.Length;

            for (int m = 0; m < result.Length; m++)
            {
                ComplexNumber S = new ComplexNumber();
                for (int n = 0; n < s.Length; n++)
                {
                    S += s[n] * ComplexNumber.Exp(k * n * m);
                }
                result[m] = S / s.Length;
            }
            return result;
        }

    }
}
