using System;

namespace HW_arrays_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[3];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }



            for (int k = 0; k < words.Length; k++)
            {
                if (Convert.ToString(words[k]).Contains('a') && Convert.ToString(words[k]).Contains('o'))
                {

                    if (Convert.ToString(words[k]).IndexOf('a') < Convert.ToString(words[k]).IndexOf('o'))
                    {

                        words[k] = words[k].ToUpper();
                    }

                    else if (Convert.ToString(words[k]).IndexOf('a') > Convert.ToString(words[k]).IndexOf('o'))
                    {
                        words[k] = words[k].ToLower();
                    }
                }
                if (Convert.ToInt32(Convert.ToString(words[k]).Contains('a')) == 1)
                {
                   words[k] = words[k].ToUpper();
                }
                else if (Convert.ToInt32(Convert.ToString(words[k]).Contains('o')) == 1)
                {
                    words[k] = words[k].ToLower();
                }
            }

            foreach (var element in words)
            {
                Console.WriteLine(element);
            }


        }


    }
}
