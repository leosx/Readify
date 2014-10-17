using System;

namespace ReadifySolution_Shixing_China
{
    /// <summary>
    ///  Linked List (not use any built-in .NET collection components.)
    /// </summary>
    public class PuzzleOne : IRun
    {
        private int[] inputNums;

        public PuzzleOne(params int[] nums)
        {
            this.inputNums = nums;
        }

        /// <summary>
        /// indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                if (index < 0)
                    throw new ArgumentOutOfRangeException("index");
                if (null == inputNums || inputNums.Length <= 0)
                    throw new Exception("No Data !");

                return inputNums[index];
            }
        }

        /// <summary>
        /// Puzzle Answer Entrance
        /// </summary>
        public void Run()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("==============Puzzle One==============");
            Console.WriteLine(string.Format("5th element is: {0}", this[5])); // Use indexer to custom error message.
        }
    }
}
