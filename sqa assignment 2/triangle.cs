using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqa_assignment_2
{
    public enum TriangleType
    {
        Scalene = 1, // no two sides are the same length
        Isosceles = 2, // two sides are the same length and one differs
        Equilateral = 3, // all sides are the same length
        Error = 4 // inputs can't produce a triangle
    }
    public static class triangle
    {
        public static int tri_side1;
        public static int tri_side2;
        public static int tri_side3;

        static triangle()
        {
            tri_side1 = 1;
            tri_side2 = 1;
            tri_side3 = 1;
        }
        public static int Getside1()
        {
            return tri_side1;
        }
        public static int Setside1(int tri_s1)
        {
            tri_side1 = tri_s1;
            return tri_side1;
        }
        public static int Getside2()
        {
            return tri_side2;
        }
        public static int Setside2(int tri_s2)
        {
            tri_side2 = tri_s2;
            return tri_side2;
        }
        public static int Getside3()
        {
            return tri_side3;
        }
        public static int Setside3(int tri_s3)
        {
            tri_side3 = tri_s3;
            return tri_side3;
        }

        public static int Analyze(int tri_s1, int tri_s2, int tri_s3)
        {
            tri_side1 = tri_s1;
            tri_side2 = tri_s2;
            tri_side3 = tri_s3;
            //Placing items in an array for processing 
            int[] values = new int[3] { tri_side1, tri_side2, tri_side3 };

            // keeping this as the first check in case someone passes invalid parameters that could also be a triangle type. 
            //Example: -2,-2,-2 could return Equilateral instead of Error without this check.  
            //We also have a catch all at the end that returns Error if no other condition was met.
            if (tri_side1 <= 0 || tri_side2 <= 0 || tri_side3 <= 0)
            {
                return (int)TriangleType.Error;
            }
            else if (values.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
            {
                return (int)TriangleType.Equilateral;
            }
            else if (values.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                return (int)TriangleType.Isosceles;
            }
            else if (values.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
            {
                return (int)TriangleType.Scalene;
            }
            else
            {
                return (int)TriangleType.Error;
            }
        }
    }
}
