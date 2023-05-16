using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CsBootCamp
{
    class KenimaticsCalculator
    {
        double Dx = 0;
        double vO = 0;
        double V = 0;
        double a = 0;
        double t = 0;

        string DxTXT;
        string vOTXT;
        string VTXT;
        string aTXT;
        string tTXT;

        public void EquationSetup()
        {
            Console.WriteLine("This calculator can only be used for non constant Velocity. " +
                "\nEnter 'solve' for the variable you are solving for and leave the variable you are missing blank.");

            Console.WriteLine("Enter your DeltaX");
            DxTXT = Console.ReadLine();
            try
            {
                Dx = float.Parse(DxTXT);
            }
            catch (Exception)
            {
                if (DxTXT != ("solve"))
                {
                    DxTXT = ("");
                }
                else
                {
                    DxTXT = ("solve");
                }
            }

            Console.WriteLine("Enter your vO");
            vOTXT = Console.ReadLine();
            try
            {
                vO = float.Parse(vOTXT);
            }
            catch (Exception)
            {
                if (vOTXT != ("solve"))
                {
                    vOTXT = ("");
                }
                else
                {
                    vOTXT = ("solve");
                }
            }

            Console.WriteLine("Enter your V");
            VTXT = Console.ReadLine();
            try
            {
                V = float.Parse(VTXT);
            }
            catch (Exception)
            {
                if (VTXT != ("solve"))
                {
                    VTXT = ("");
                }
                else
                {
                    VTXT = ("solve");
                }
            }

            Console.WriteLine("Enter your a");
            aTXT = Console.ReadLine();
            try
            {
                a = float.Parse(aTXT);
            }
            catch (Exception)
            {
                if (aTXT != ("solve"))
                {
                    aTXT = ("");
                }
                else
                {
                    aTXT = ("solve");
                }
            }

            Console.WriteLine("Enter your t");
            tTXT = Console.ReadLine();
            try
            {
                t = float.Parse(tTXT);
            }
            catch (Exception)
            {
                if (tTXT != ("solve"))
                {
                    tTXT = ("");
                }
                else
                {
                    tTXT = ("solve");
                }
            }

            Equation();
        }

        public void Equation()
        {
            Console.WriteLine("Your values are Dx: {0}, vO: {1}, V: {2}, a: {3}, t: {4}"
                                , Dx, vO, V, a, t);

            if (DxTXT == ("solve"))
            {
                Console.WriteLine("We will solve for Dx");
                SolveForDx();
            }
            else if (vOTXT == ("solve"))
            {
                Console.WriteLine("We will solve for vO");
                SolveForvO();
            }
            else if (VTXT == ("solve"))
            {
                Console.WriteLine("We will solve for V");
                SolveForVelocity();
            }
            else if (aTXT == ("solve"))
            {
                Console.WriteLine("We will solve for a");
                SolveFora();
            }
            else if (tTXT == ("solve"))
            {
                Console.WriteLine("We will solve for t");
                SolveFort();
            }
            else
            {
                Console.WriteLine("You need to enter which value you are solving for");
            }
        }

        public void SolveForDx()
        {
            if (aTXT == (""))
            {
                Dx = 0.5 * (V + vO) * t;

                Console.Write(Dx);
            }
            else if (tTXT == (""))
            {
                double VSqr = Math.Pow(V, 2);
                double vOSqr = Math.Pow(vO, 2);

                Dx = (VSqr - vOSqr) / (2.0 * a);

                Console.Write(Dx);
            }
            else if(VTXT == (""))
            {
                double tSqr = Math.Pow(t, 2.0);
                Dx = vO * t + (0.5 * a * tSqr);

                Console.Write(Dx);
            }
        }

        public void SolveForvO()
        {
            if (DxTXT == (""))
            {
                vO = V - a * t;

                Console.Write(vO);
            }
            else if(VTXT == (""))
            {
                double tSqr = Math.Pow(t, 2.0);
                vO = (Dx - 0.5 * a * tSqr) / t;

                Console.Write(vO);
            }
            else if (tTXT == (""))
            {
                double VSqr = Math.Pow(V, 2.0);
                vO = Math.Sqrt(VSqr - 2.0 * a * Dx);

                Console.Write(vO);
            }
            else if (aTXT == (""))
            {
                vO = (2.0 * Dx / t) - V;

                Console.Write(vO);
            }
        }

        public void SolveForVelocity()
        {
            if (DxTXT == (""))
            {
                V = vO + a * t;

                Console.Write (V);
            }
            else if (tTXT == (""))
            {
                double vOSqr = Math.Pow(vO, 2.0);
                V = Math.Sqrt(vOSqr + 2.0 * a * Dx);

                Console.Write(V);
            }
            else if (aTXT == (""))
            {
                V = (2.0 * Dx / t) - vO;

                Console.Write(V);
            }
        }

        public void SolveFora()
        {
            if (DxTXT == (""))
            {
                a = (V - vO) / t;

                Console.Write(a);
            }
            else if (VTXT == (""))
            {
                double tSqr = Math.Pow(t, 2.0);
                a = (2 * (Dx - vO * t)) / tSqr;

                Console.Write(a);
            }
            else if (tTXT == (""))
            {
                double VSqr = Math.Pow(V, 2.0);
                double vOSqr = Math.Pow(vO, 2.0);
                a = (VSqr - vOSqr) / (2.0 * Dx);

                Console.Write(a);
            }
        }

        public void SolveFort()
        {
            if (DxTXT == (""))
            {
                t = (V - vO) / a;

                Console.Write(t);
            }
            else if (VTXT == (""))
            {
                double vOSqr = Math.Pow(vO, 2.0);
                double SqrtTerm = vOSqr - 2.0 * a * Dx;

                if (SqrtTerm > 0 ) 
                {
                    t = (-vO + Math.Sqrt(SqrtTerm)) / a;
                }
                else
                {
                    SqrtTerm = SqrtTerm * -1.0;
                    t = (-vO + Math.Sqrt(SqrtTerm)) / a;
                }

                Console.WriteLine("{0}", t);
            }
            else if (aTXT == (""))
            {
                t = (2.0 * Dx) / (vO + V);

                Console.Write(t);
            }
        }
    }
    }
