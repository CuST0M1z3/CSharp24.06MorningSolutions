using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BatGoikoTower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        int width = height * 2;

        int dots = height - 1;
        int centerDots = 0;
        int backSlash = 1;
        int forwardSlash = 1;
        int centerDash = 2;
        int count = 0;

        for (int row = 0; row < height; row++)
        {
            Console.Write(new String('.', dots));
            Console.Write(new String('/', backSlash));
            if (row > 0 && centerDots == centerDash)
            {
                Console.Write(new String('-', centerDash));               
                centerDash += (centerDots + 2) - count;
                centerDots += 2;
                if (row == 1)
                {
                    count += 2;
                }
                else if(row == 3)
                {
                    count += 4;
                }
                else if (row == 6)
                {
                    count += 6;
                }
                else if (row == 10)
                {
                    count += 8;
                }
                else if (row == 15)
                {
                    count += 10;
                }
                else if (row == 21)
                {
                    count += 12;
                }
                else if (row == 28)
                {
                    count += 14;
                }
                                            
            }
            else
            {
                Console.Write(new String('.', centerDots));
                centerDots += 2;
            }           
            Console.Write(new String('\\', forwardSlash));
            Console.Write(new String('.', dots));
            Console.WriteLine();
            dots--;
        }
    }
}

