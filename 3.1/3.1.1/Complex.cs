using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1 {
    public class Complex : IFormattable {

        public readonly decimal real;
        public readonly decimal imaginary;

        public Complex(int real, int imaginary) {
            this.real = (decimal) real;
            this.imaginary = (decimal) imaginary;
        }
        public Complex(float real, float imaginary) {
            this.real = (decimal) real;
            this.imaginary = (decimal) imaginary;
        }
        public Complex(double real, double imaginary) {
            this.real = (decimal) real;
            this.imaginary = (decimal) imaginary;
        }

        public Complex(decimal real, decimal imaginary) {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2) {
            return new Complex( c1.real + c2.real, c1.imaginary + c2.imaginary );
        }

        public static Complex operator -(Complex c1, Complex c2) {
            return new Complex( c1.real - c2.real, c1.imaginary - c2.imaginary );
        }

        public static Complex operator *(Complex c1, Complex c2) {
            decimal real = (c1.real * c2.real) - (c1.imaginary * c2.imaginary);
            decimal complex = (c1.imaginary * c2.real) + (c1.real * c2.imaginary);
            return new Complex(real, complex);
        }

        public static Complex operator /(Complex c1, Complex c2) {
            decimal real = (c1.real * c2.real + c1.imaginary * c2.imaginary) / 
                (c2.real * c2.real + c2.imaginary * c2.imaginary);
            decimal complex = (c1.imaginary * c2.real - c1.real * c2.imaginary) /
                (c2.real * c2.real + c2.imaginary * c2.imaginary);
            return new Complex(real, complex);
        }

        public string ToString(string format, IFormatProvider formatProvider) {
            switch ( format ) {
                case "w":
                    return String.Format( "[{0},{1}]", real, imaginary );
                case "d":
                default:
                    return String.Format( "{0}+{1}i", real, imaginary );
            }
        }
    }
}
