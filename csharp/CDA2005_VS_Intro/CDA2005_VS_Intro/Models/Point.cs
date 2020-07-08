using System;
using System.Collections.Generic;
using System.Text;

namespace CDA2005_VS_Intro.Models
{
    public class Point
    {       

        private int x;

        private int y;


        public Point() : this(0, 0)
        {
            
        }

        public Point(int _x) : this(_x, 0)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public Point(int _x, int _y) 
        {
            x = _x;
            y = _y;
        }


        public Point(int a, string b)
        {

        }

        public Point(string a, int b)
        {

        }

    }
}
