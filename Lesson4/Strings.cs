using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson4
{
    class Strings
    {
        public string StringGenerator()
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Random rand = new();
            int wordLength = 6;

            string word = "";
            for (int j = 0; j <= wordLength; j++)
            {
                // Выбор случайного числа от 0 до 25
                // для выбора буквы из массива букв.
                int letter_num = rand.Next(0, letters.Length - 1);
                
                word += letters[letter_num];
            }
            return word;
        }
        public string[] CreateArray()
        {
            string[] randomStringArray = new string[15000];
            for (int i = 0; i < randomStringArray.Length; i++)
            {
                randomStringArray[i] += StringGenerator();
            }
            return randomStringArray;
        }
    }
}
