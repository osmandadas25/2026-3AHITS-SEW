public class Complex {
    private readonly double re;   // Realteil
    private readonly double im;   // Imaginärteil

    public Complex(double real, double imag) {
        re = real;
        im = imag;
    }

    public override string ToString()
    {
        return  $"{Math.Round(re,4)} + {Math.Round(im,4)}i";
    }


    public double Abs() {
        return Math.Round(Math.Sqrt(re*re+im*im),4);
    }

    public Complex Plus(Complex b) {
        return new Complex(re+b.re,im+b.im);
    }

    public Complex Times(Complex b) {
        return new Complex((re*b.re-im*b.im),(re*b.im+im*b.re));
    }

    public int CheckenMandelbrotmenge() {
        if(re*re + im*im > 4)
            return -1;
        else
            return 1;
    }

}