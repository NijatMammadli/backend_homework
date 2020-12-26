using System;

namespace hw_strings_2
{
    class Program
    {
        static void Main(string[] args)
        {
        START:

            Console.WriteLine("insert a word which suits to conditions");
            string word = Console.ReadLine();
            int b_n = word.ToLower().IndexOf('b');
            
            if (word.Length != 6)
            {
                Console.WriteLine("word should be 5 letters");
                goto START;
            }
            else if (word.ToLower().Contains('a'))
            {
                Console.WriteLine("word should not contain a");
                goto START;
            }
            else if (word[5] != '.')
            {
                Console.WriteLine("at the end of word . sign should be written");
                goto START;
            }
            else if(b_n == -1)
            {
                Console.WriteLine("word should containt at least one 'b' character");
                goto START;
            }
           
            word = word.Replace('u', 'k');
            
            word = word.Replace('Z', 'z');
            Console.WriteLine(Convert.ToInt32(word.Contains('z')));

            for (int i = 0; i < word.Length; i++)
            {
                if (Convert.ToInt32(word.Contains('z')) != -0)
                {
                    word = word.Remove(Convert.ToInt32(word.IndexOf('z')), 1);
                }
                Console.WriteLine(word);
            }

            word = word.Replace('o', 'O');
            word = word.Replace('L', 'l');

            Console.WriteLine(word);

            Console.WriteLine((word.Substring(2, word.Length - 3) + word.Substring(0, 2)).ToLower());

            
        }
    }
}
