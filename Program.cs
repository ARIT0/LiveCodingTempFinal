using System;

namespace FinalLiveCode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int toBuyCandy;
            //int Candy = 0;

            double kid = 250;

            double clear = (kid * .1) + kid;
            double cloudy = kid;
            double rainy = kid - (kid * .25);
            double fullMoon = (kid * .25) + kid;

            double deg40 = kid - (kid * .05);
            double deg50 = kid;
            double deg60 = (kid * .05) + kid;
            double deg70 = (kid * .20) + kid;

            double toGive = kid * 3;

            
            
            Console.WriteLine(clear + deg50);

            Console.WriteLine(fullMoon + deg40);

            Console.WriteLine(rainy + deg70);



        }
    }
}
