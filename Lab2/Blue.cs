using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double pow = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / pow;
                pow *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double term = 1;
            for (int i = 1; i <= n; i++)
            {
                term = term * (-5) / i;
                answer += term;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 0, b = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += a;
                long next = a + b;
                a = b;
                b = next;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            long sum = 0;
            long term = a;
            while (sum + term <= L)
            {
                sum += term;
                term += h;
                answer++;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            long cells = S;
            while (cells < L)
            {
                cells *= 2;
                answer += h;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double k = 1 + I / 100;
            // A:
            double daily = S;
            for (int d = 1; d <= 7; d++)
            {
                a += daily;
                daily *= k;
            }

            // B:
            daily = S;
            double km = 0;
            while (km < 100)
            {
                km += daily;
                daily *= k;
                b++;
            }

            // C:
            daily = S;
            c = 0;
            while (daily <= 42)
            {
                daily *= k;
                c++;
            }

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            int k = 0;

            while (true)
            {
                double x = a + k * h;

                if (x > b + 0.000000001)
                    break;

                double s = 0;
                double elem = 1;
                int i = 0;

                while (true)
                {
                    s += elem;

                    if (Math.Abs(elem) < E)
                        break;

                    elem = elem * (2.0 * i + 3) * x * x
                           / ((2.0 * i + 1) * (i + 1));

                    i++;
                }

                SS += s;

                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SY += y;

                k++;
            }
            // end

            return (SS, SY);
        }
    }
}
