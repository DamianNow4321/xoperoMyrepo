﻿using System;

namespace BasenStr214
{
    class Triangle
    {
        double area;
        int height;
        int length;
        public static void Main(string[] args)
        {
            string results = "";
            int x = 0;
            Triangle[] ta = new Triangle[4];
            while (x < 4)
            {
                ta[x] = new Triangle();
                ta[x].height = (x + 1) * 2;
                ta[x].length = x + 4;
                ta[x].setArea();
                results += "trójkąt " + x + ", area";
                results += " = " + ta[x].area + "\n";
                x = x + 1;
            }
            int y = x;
            x = 27;
            Triangle t5 = ta[2];
            ta[2].area = 343;
            results += "y = " + y;
            Console.WriteLine(results +
               ", t5 pole = " + t5.area);
        }
        void setArea()
        {
            area = (height * length) / 2;
        }
    }
}