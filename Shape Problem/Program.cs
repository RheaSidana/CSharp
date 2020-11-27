using System;

namespace Ass2Quse1
{
    class Program
    {
        public delegate double Area();
        static void Main(string[] args)
        {
            //array of different shapes
            Shape[] arr = new Shape[8];

            //array of the area of different shapes
            double[] area = new double[8];

            //creating delegate
            Area space;

            arr[0] = new Triangle();
            arr[0].Width = 10;
            arr[0].Height = 11;
            space = new Area(arr[0].Calculatesurface);
            area[0] = space();

            arr[1] = new Rectangle();
            arr[1].Width = 8;
            arr[1].Height = 11;
            space = new Area(arr[1].Calculatesurface);
            area[1] = space();

            arr[2] = new Rectangle();
            arr[2].Width = 20;
            arr[2].Height = 15;
            space = new Area(arr[2].Calculatesurface);
            area[2] = space();

            arr[3] = new Triangle();
            arr[3].Width = 40;
            arr[3].Height = 15;
            space = new Area(arr[3].Calculatesurface);
            area[3] = space();

            arr[4] = new Rectangle();
            arr[4].Width = 10;
            arr[4].Height = 11;
            space = new Area(arr[4].Calculatesurface);
            area[4] = space();

            arr[5] = new Circle(8);
            space = new Area(arr[5].Calculatesurface);
            area[5] = space();

            arr[6] = new Triangle();
            arr[6].Width = 16;
            arr[6].Height = 11;
            space = new Area(arr[6].Calculatesurface);
            area[6] = space();

            arr[7] = new Circle(10);
            space = new Area(arr[7].Calculatesurface);
            area[7] = space();

            Console.WriteLine("Displaying : ");
            for(int i=0;i<8;i++)
            {
                Console.WriteLine(arr[i]+"\nArea:"+area[i]);
            }
        }
    }
}
