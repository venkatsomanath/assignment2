using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT2
{
    public static class Trianglesolver
    {

        public static string analyze(int s1,int s2,int s3)
        {

            String at = "triangle is not formed with given dimensions \n";

            if (!(s1 + s2 <= s3 || s1 + s3 <= s2 || s2 + s3 <= s1))
            {

                if ((s1 == s2) && (s1 == s3))

                {
                    at = " the given dimensions forms an equilateral triangle  \n";

                }

                else if ((s1 == s2) || (s2 == s3) || (s1 == s3))

                {
                    at = " the given dimensions forms an isosceles triangle  \n";
                }

                else

                {
                    at = "the given dimensions forms a scalene triangle  \n";
                }

            }

            return at;
                
                }
            }
        }

       
       