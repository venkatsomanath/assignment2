using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASSIGNMENT2;
using NUnit.Framework;



namespace assignment2tests
{


    [TestFixture]


    public class assignment2
    {


        [Test]
        public void test_analyze_scalenetriangle_input_22_34_44()
        {
            string output = Trianglesolver.analyze(22, 34, 44);
            Console.Write(output);
        }


        [Test]
        public void test_analyze_scalenetriangle_input_28_38_64()
        {
            string output = Trianglesolver.analyze(28, 38, 64);
            Console.Write(output);
        }


        [Test]
        public void test_analyze_trianglenotpossible_input_28_38_84()
        {
            string output = Trianglesolver.analyze(28, 38, 84);
            Console.Write(output);
        }


        [Test]
        public void test_analyze_isoscelestriangle_input_22_22_10()
        {
            string output = Trianglesolver.analyze(22, 22, 10);
            Console.Write(output);
        }


        [Test]
        public void test_analyze_isoscelestriangle_input_38_38_14()
        {
            string output = Trianglesolver.analyze(38, 38, 14);
            Console.Write(output);
        }


        [Test]
        public void test_analyze_trianglenotpossible_input_28_28_84()
        {
            string output = Trianglesolver.analyze(28, 28, 84);
            Console.Write(output);
        }


        [Test]
        public void test_analyze_Equilateraltriangle_input_55_55_55()
        {
            string output = Trianglesolver.analyze(55, 55, 55);
            Console.Write(output);
        }


        [Test]
        public void test_analyze_Equilateraltriangle_input_66_66_66()
        {
            string output = Trianglesolver.analyze(66, 66, 66);
            Console.Write(output);
        }


    }
}
