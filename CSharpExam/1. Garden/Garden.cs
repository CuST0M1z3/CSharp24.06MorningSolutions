using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class Garden
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        float tomatoAmount = float.Parse(Console.ReadLine());
        float tomatoArea = float.Parse(Console.ReadLine());
        float cucumberAmount = float.Parse(Console.ReadLine());
        float cucumberArea = float.Parse(Console.ReadLine());
        float potatoAmount = float.Parse(Console.ReadLine());
        float potatoArea = float.Parse(Console.ReadLine());
        float carrotAmount = float.Parse(Console.ReadLine());
        float carrotArea = float.Parse(Console.ReadLine());
        float cabbageAmount = float.Parse(Console.ReadLine());
        float cabbageArea = float.Parse(Console.ReadLine());
        float beansAmount = float.Parse(Console.ReadLine());

        float totalArea = 250.0f;

        float tomatoPrice = (float)(tomatoAmount * 0.5);

        float cucumberPrice = (float)(cucumberAmount * 0.4);

        float potatoPrice = (float)(potatoAmount * 0.25);

        float carrotPrice = (float)(carrotAmount * 0.6);

        float cabbagePrice = (float)(cabbageAmount * 0.3);

        float beansPrice = (float)(beansAmount * 0.4);

        float totalCost = tomatoPrice + cucumberPrice + potatoPrice +
            carrotPrice + cabbagePrice + beansPrice;


        totalArea = totalArea - tomatoArea - cucumberArea - potatoArea -
            carrotArea - cabbageArea;

        Console.WriteLine("Total costs: {0:F2}", totalCost);

        if (totalArea > 0)
        {
            Console.WriteLine("Beans area: " + totalArea);
        }
        if (totalArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        if (totalArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }

    }
}

