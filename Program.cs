using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petle_Wzorki
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();

        public static void Prostokat(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            for(int j=1; j<m-1; j++)
            {
                Star();
                for (int i = 1; i < n-1; i++)
                    Space();

                StarLn();
            }

            for(int i=0; i<n; i++)
            {
                Star();
            }
            NewLine();
        }

        static void LiteraX(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n + 1;

            //górna połówka
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();

                for (int j = 0; j < n - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //pojedyncza gwiazdka w środku
            for (int i = 0; i < n / 2; i++)
                Space();

            StarLn();

            //dolna połówka, symetrycznie do górnej
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - 1 - i; j++)
                    Space();
                Star();
                for (int j = 0; j < 2 * i + 1; j++)
                    Space();
                StarLn();
            }
        }

        static void Z_Lustrzane(int n)
        {
            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            for (int i = 0; i < n; i++)
            {
                for(int j=0; j<n-1-i; j++)
                    Space();
                StarLn();
            }

            for (int i = 0; i < n; i++)
                Star();
        }

        static void Z(int n)
        {
            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                StarLn();
            }
            for (int i = 0; i < n; i++)
                Star();
            NewLine();

        }

        static void Klepsydra(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n + 1;

            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            //górna połówka
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();

                for (int j = 0; j < n - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //pojedyncza gwiazdka w środku
            for (int i = 0; i < n / 2; i++)
                Space();

            StarLn();

            //dolna połówka, symetrycznie do górnej
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - 1 - i; j++)
                    Space();
                Star();
                for (int j = 0; j < 2 * i + 1; j++)
                    Space();
                StarLn();
            }

            for (int i = 0; i < n; i++)
                Star();
            NewLine();
        }

        static void Klepsydrav2(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n + 1;

            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 3 - 2 * i; j++)
                    Space();
                StarLn();
            }

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - 1 - i; j++)
                    Space();
                Star();
                for (int j = 0; j < 2 * i; j++)
                    Space();
                StarLn();
            }

            for (int i = 0; i < n; i++)
                Star();
            NewLine();
        }

        static void LiteraP(int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < n / 2 - 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        Star();
                    }
                    else if (j == n - 1)
                    {
                        StarLn();
                    }
                    else
                    {
                        Space();
                    }
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < n / 2 - 1; i++)
            {
                StarLn();
            }
            NewLine();
        }

        static void LiteraB(int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < n / 2 - 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        Star();
                    }
                    else if (j == n - 1)
                    {
                        StarLn();
                    }
                    else
                    {
                        Space();
                    }
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();

            //dół
            for (int i = 0; i < n / 2 - 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        Star();
                    }
                    else if (j == n - 1)
                    {
                        StarLn();
                    }
                    else
                    {
                        Space();
                    }
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();
        }

        static void LiteraK(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Star();
                for (int j = n / 2; j < n; j++)
                {
                    if (j == i || j == n - i - 1)
                        Star();
                    else
                        Space();
                }
                NewLine();
            }
        }

        static void LiteraR(int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < n / 2 - 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        Star();
                    }
                    else if (j == n - 1)
                    {
                        StarLn();
                    }
                    else
                    {
                        Space();
                    }
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < n/2-1; i++)
            {
                Star();
                for (int j = 0; j < 2 * i + 1; j++)
                    Space();

                Star();
                NewLine();
            }

        }

        static void Cyfra7(int n)
        {
            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                    Space();
                StarLn();
            }
        }

        static void Cyfra3(int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < n / 2 - 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        Space();
                    }
                    else if (j == n - 1)
                    {
                        StarLn();
                    }
                    else
                    {
                        Space();
                    }
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();

            //dół
            for (int i = 0; i < n / 2 - 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        Space();
                    }
                    else if (j == n - 1)
                    {
                        StarLn();
                    }
                    else
                    {
                        Space();
                    }
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();
        }

        static void Cyfra6(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Space();
                }
                else
                {
                    Star();
                }
            }
            for (int i = 0; i <= n / 4; i++)
            {
                StarLn();
            }
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            for (int j = 0; j < n / 2 - 1; j++)
            {
                for (int i = 0; i < n + 1; i++)
                {
                    if (i == 0)
                    {
                        Star();
                    }
                    else if (i == n)
                    {
                        StarLn();
                    }
                    else
                    {
                        Space();
                    }

                }
            }

            for (int k = 0; k < n; k++)
            {
                if (k == 0)
                {
                    Space();
                }

                else
                {
                    Star();
                }

            }
        }

        static void Main(string[] args)
        {
            Prostokat(5, 7);
            Console.WriteLine();
            LiteraX(9);
            Console.WriteLine();
            Z_Lustrzane(10);
            Console.WriteLine();
            Z(10);
            Console.WriteLine();
            Klepsydra(5);
            Console.WriteLine();
            Klepsydrav2(7);
            Console.WriteLine();
            LiteraP(8);
            Console.WriteLine();
            LiteraB(8);
            Console.WriteLine();
            LiteraK(8);
            Console.WriteLine();
            LiteraR(8);
            Console.WriteLine();
            Cyfra7(8);
            Console.WriteLine();
            Cyfra3(8);
            Console.WriteLine();
            Cyfra6(8);
            Console.WriteLine();



        }
    }
}
