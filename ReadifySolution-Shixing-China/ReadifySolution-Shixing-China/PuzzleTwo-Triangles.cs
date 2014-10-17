using System;

namespace ReadifySolution_Shixing_China
{
    /// <summary>
    /// enum of Triangle type.
    /// </summary>
    public enum TriangleType
    {
        Scalene = 0,

        Isosceles = 1,

        Equilateral = 2,

        Error = 3
    }

    /// <summary>
    /// Puzzle Two - Triangles
    /// </summary>
    public class PuzzleTwo_Triangles : IRun
    {
        public TriangleType GetTriangleType(int Sideone, int Sidetwo, int Sidethree)
        {
            //if (Sideone <= 0)
            //    throw new ArgumentException("argument must be greater than 0.", "Sideone");
            //if (Sidetwo <= 0)
            //    throw new ArgumentException("argument must be greater than 0.", "Sidetwo");
            //if (Sidethree <= 0)
            //    throw new ArgumentException("argument must be greater than 0.", "Sidethree");

            if (Sideone <= 0 || Sidetwo <= 0 || Sidethree <= 0)
            {
                return TriangleType.Error;
            }

            if (Sideone.Equals(Sidetwo) && Sideone.Equals(Sidethree))
            {
                return TriangleType.Equilateral;
            }
            else if ((Sideone.Equals(Sidetwo) && !Sidetwo.Equals(Sidethree)) || ((Sidetwo.Equals(Sidethree)) && !Sideone.Equals(Sidetwo)))
            {
                return TriangleType.Isosceles;
            }
            else if ((!Sideone.Equals(Sidetwo) && !Sidetwo.Equals(Sidethree) && !Sideone.Equals(Sidethree)))
            {
                return TriangleType.Scalene;
            }

            return TriangleType.Error;
        }

        public void Run()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("==============Puzzle Two==============");
            int sideOne, sideTwo, sideThree = sideOne = sideTwo = 13;

            PuzzleTwo_Triangles triangle = new PuzzleTwo_Triangles();

            // Equilateral
            Console.WriteLine(string.Format("Triangle ({0} - {1} - {2}) type is : {3}", sideOne, sideTwo, sideThree, triangle.GetTriangleType(sideOne, sideTwo, sideThree).ToString()));

            // Isosceles
            sideOne = sideTwo = 13;
            sideThree = 20;
            Console.WriteLine(string.Format("Triangle ({0} - {1} - {2}) type is : {3}", sideOne, sideTwo, sideThree, triangle.GetTriangleType(sideOne, sideTwo, sideThree).ToString()));

            //Scalene
            sideOne = 13;
            sideTwo = 14;
            sideThree = 25;
            Console.WriteLine(string.Format("Triangle ({0} - {1} - {2}) type is : {3}", sideOne, sideTwo, sideThree, triangle.GetTriangleType(sideOne, sideTwo, sideThree).ToString()));

            // Error
            sideOne = sideThree = sideTwo = -1;
            Console.WriteLine(string.Format("Triangle ({0} - {1} - {2}) type is : {3}", sideOne, sideTwo, sideThree, triangle.GetTriangleType(sideOne, sideTwo, sideThree).ToString()));
        }
    }
}
