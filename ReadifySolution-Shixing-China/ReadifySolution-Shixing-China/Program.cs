/*
 *Author: Xing Shi
 *
 *Country: China 
 * 
 * Phone Number: +8618508193815
 */
using System;
using System.Collections.Generic;

namespace ReadifySolution_Shixing_China
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            // Sorry ,I can't do the SharePoint Development.  Puzzle Four – SharePoint Learning  , Puzzle Five – SharePoint Weekly Reports  filters out.
            IEnumerable<IRun> projects = new List<IRun>()   
            {
                new PuzzleOne(1,3,5,7,9,10,25,31,24,14),
                new PuzzleTwo_Triangles(),
                new PuzzleThree_ReverseWords()
            };

            foreach (IRun pro in projects)
            {
                try
                {
                    pro.Run();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Gloable Exception Handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Console.WriteLine("Exception: " + ((Exception)e.ExceptionObject).Message);
            }
            catch
            { }
        }
    }
}
