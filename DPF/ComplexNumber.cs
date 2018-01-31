using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPF
{
    public struct ComplexNumber
    {
        public static ComplexNumber Exp(double arg) { return new ComplexNumber(Math.Cos(arg), Math.Sin(arg)); }
        public static ComplexNumber Exp(double abs, double arg) { return new ComplexNumber(abs * Math.Cos(arg), abs * Math.Sin(arg)); }



        private readonly double f_Re, f_Im;
        public double Re { get { return f_Re; } }
        public double Im { get { return f_Im; } }
        public double Abs { get { return Math.Sqrt(f_Re * f_Re + f_Im * f_Im); } }
        public double Arg { get { return Math.Atan2(Im, Re); } }



        //   public ComplexNumber() { }
        public ComplexNumber(double Re, double Im) { f_Re = Re; f_Im = Im; }

        public override string ToString()
        {
            return "(" + f_Re.ToString() + ";" + f_Im.ToString() + ")";
        }



        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Re + b.Re, a.Im + b.Im);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Re - b.Re, a.Im - b.Im);
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Re * b.Re - a.Im * b.Im, a.Re * b.Im + a.Im * b.Re);
        }
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double znam = b.Re * b.Re + b.Im * b.Im;
            return new ComplexNumber((a.Re * b.Re + a.Im * b.Im) / znam, (a.Im * b.Re - a.Re * b.Im) / znam);
        }
        public static ComplexNumber operator *(double a, ComplexNumber b)
        {
            return new ComplexNumber(a * b.Re, a * b.Im);
        }
        public static ComplexNumber operator /(ComplexNumber a, double b)
        {
            return new ComplexNumber(a.Re / b, a.Im / b);
        }
    }
}
