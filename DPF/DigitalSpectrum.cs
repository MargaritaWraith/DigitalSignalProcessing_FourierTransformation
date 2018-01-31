using System;
using System.Collections.Generic;
using System.IO;
//(?<=\s+)//.*(?=\r\n) - найти все комментарии
namespace DPF
{
    public class DigitalSpectrum
    {
        public static DigitalSpectrum LoadFromFile(string FileName)
        {

            #region   Вариант записи
            //var file_stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);                   
            //var reader = new StreamReader(file_stream);

            //string str = reader.ReadLine();
            //var stroki = str.Split('=');
            //double df = double.Parse(stroki[1]);

            //List<ComplexNumber> Samples = new List<ComplexNumber>();

            //while (!reader.EndOfStream)
            //{
            //    stroki = reader.ReadLine().Split('(', ';', ')');
            //    double re = double.Parse(stroki[1]);
            //    double im = double.Parse(stroki[2]);
            //    Samples.Add(new ComplexNumber(re, im));
            //}

            //reader.Close();
            //file_stream.Close();
            //return new DigitalSpectrum(df, Samples.ToArray());
            #endregion

            using (var reader = File.OpenText(FileName))
            {
                string str = reader.ReadLine();
                var stroki = str.Split('=');
                double df = double.Parse(stroki[1]);

                List<ComplexNumber> Samples = new List<ComplexNumber>();

                while (!reader.EndOfStream)
                {
                    stroki = reader.ReadLine().Split('(', ';', ')');
                    double re = double.Parse(stroki[1]);
                    double im = double.Parse(stroki[2]);
                    Samples.Add(new ComplexNumber(re, im));
                }
                return new DigitalSpectrum(df, Samples.ToArray());
            }
        }


        #region Поля
        private readonly ComplexNumber[] f_Samples;
        private readonly double f_df; 
        #endregion

        #region Свойства

        public double df { get { return f_df; } }

        public int Length { get { return f_Samples.Length; } } 

        #endregion

        public ComplexNumber this[int index] { get { return f_Samples[index]; } }

        public DigitalSpectrum(double df, ComplexNumber[] samples) { f_df = df; f_Samples = samples; }

        public DigitalSignal GetSignal()
        {
            int N = f_Samples.Length;
            double[] result = new double[N];
            double k = -2 * Math.PI / N;

            for (int m = 0; m < N; m++)
            {
                ComplexNumber S = new ComplexNumber();
                for (int n = 0; n < N; n++)
                {
                    S += f_Samples[n] * ComplexNumber.Exp(k * n * m);
                }
                result[m] = S.Re;
            }
            return new DigitalSignal(1/ f_df / N , result);
        }

        public void SaveToFile(string FileName)
        {
            var file_stream = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            var writer = new StreamWriter(file_stream);

            writer.WriteLine("df=" + f_df.ToString());
            for (int i = 0; i < f_Samples.Length; i++)
            {
                writer.WriteLine(f_Samples[i]);
            }
            writer.Close();
            file_stream.Close();
        }

        public void Print()
        {
            Console.WriteLine("df={0}", f_df);
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2:0.###}\t{3:0.###}", i, i * f_df, this[i].Re, this[i].Im);

                //Console.Write(i * f_df + "\t");
                //Console.WriteLine(this[i]);
            }
        }
    }
}
