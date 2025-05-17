using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectDebugging;

public class DebuggingMethods
{
    public static double W(double e)
    {
        double n = 1;
        n = J(e) + 4;
        return n;
    }

    public static double P(double v)
    {
        double o = 0;
        o = F(v) + 2;

        return o;
    }

    public static double F(double x)
    {
        double y = 0;
        y = x / 5;
        return y;
    }

    public static double J(double a)
    {
        double c = 0;
        a = a - 1;
        c = R(a);
        c = P(c) / 3;

        return c;
    }

    public static double R(double v)
    {
        double z = 5;
        if (v == 0)
        {
            throw new ArgumentException("We cannot divide by zero", "v");
            //Console.WriteLine("Assuming a result of zero to avoid a divide by zero.");
            //z = 0;
        }
        else
        {
            z = 3 / v;
        }

        return z;

    }

    public static double Solution(double input)
    {
        double output;
        input = input - 1;
        if(input == 0)
        {
            throw new ArgumentException("We cannot divide by zero", "v");
            //Console.WriteLine("Assuming a result of zero to avoid a divide by zero.");
        }
        else
        {
            output = (3 / input / 5 + 2) / 3 + 4;
        }
        //input = input / 5;
        //input = input + 2;
        //input = input / 3;
        //double output = input + 4;

        return output;
    }
}
