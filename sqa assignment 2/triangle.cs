using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqa_assignment_2
{
    public enum TriangleType
    {
        Scalene = 1, // set value of all type
        Isosceles = 2, 
        Equilateral = 3, 
        Error = 4 
    }
    public static class triangle
    {
        public static int tri_side1;
        public static int tri_side2;
        public static int tri_side3;

        static triangle()
        {
            //default counstructor
            tri_side1 = 1;
            tri_side2 = 1;
            tri_side3 = 1;
        }
        public static int Getside1() // return value of side one
        {
            return tri_side1;
        }
        public static int Setside1(int tri_s1)// set value of side 1
        {
            tri_side1 = tri_s1;
            return tri_side1;
        }
        public static int Getside2()// return value of side two
        {
            return tri_side2;
        }
        public static int Setside2(int tri_s2)// set value of side 2
        {
            tri_side2 = tri_s2;
            return tri_side2;
        }
        public static int Getside3()// return value of sdte three
        {
            return tri_side3;
        }
        public static int Setside3(int tri_s3)// set value of side 3
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

          
            if (tri_side1 <= 0 || tri_side2 <= 0 || tri_side3 <= 0)//check for type erroe
            {
                return (int)TriangleType.Error;
            }
            else if (values.Distinct().Count() == 1) // check for type equilateral
            {
                return (int)TriangleType.Equilateral;
            }
            else if (values.Distinct().Count() == 2) // check for type isosceles
            {
                return (int)TriangleType.Isosceles;
            }
            else if (values.Distinct().Count() == 3) // check for type scalene
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
