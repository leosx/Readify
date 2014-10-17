using System;

namespace ReadifySolution_Shixing_China
{
    /// <summary>
    /// Puzzle Three – Reverse Words
    /// </summary>
    public class PuzzleThree_ReverseWords : IRun
    {
        /// <summary>
        /// Reverse Words
        /// </summary>
        /// <param name="words">words</param>
        /// <returns>result</returns>
        public string ReverseWords(string words)
        {
            if (!string.IsNullOrEmpty(words))
            {
                string result = string.Empty;
                string[] resultArray = null;
                string[] splists = words.Split(new string[] { " " }, StringSplitOptions.None);
                if (null != splists && splists.Length > 0)
                {
                    resultArray = new string[splists.Length];
                    string temp = string.Empty;
                    char[] wordschars = null;
                    // Foreach all the words
                    for (int i = 0, l = splists.Length; i < l; i++)
                    {
                        wordschars = new char[splists[i].Length];
                        char singlechar;
                        // Foreach all the letters of words
                        for (int a = 0, b = splists[i].Length; a < b; a++)
                        {
                            singlechar = splists[i][b - a - 1];
                            if (singlechar > '~')
                            {
                                // '~' ASCII is 126
                                // just processing English characters.
                                continue;
                            }
                            wordschars[a] = singlechar;
                        }

                        resultArray[i] = new String(wordschars);
                    }

                    return string.Join(" ", resultArray);
                }
            }

            return string.Empty;
        }

        public void Run()
        {
            string word = "I need this job, I need this chance.中文 789456413 !@#!#$%~ ^&%(*&^)()";
            PuzzleThree_ReverseWords reverseWords = new PuzzleThree_ReverseWords();
            Console.WriteLine(string.Format("source words is:{0}  &  Resualt words is : {1}", word, reverseWords.ReverseWords(word)));
        }
    }
}
