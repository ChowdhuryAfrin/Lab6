using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_PigLatinTranslator
{
    public class Translator
    {
      
        

        public string Translate(string wordToTranslate)
        {
        
            wordToTranslate = wordToTranslate.ToLower();
            string firstLetter="";
            if (wordToTranslate.StartsWith("a") || wordToTranslate.StartsWith("e") || wordToTranslate.StartsWith("i") || wordToTranslate.StartsWith("o") || wordToTranslate.StartsWith("u"))

            { firstLetter = wordToTranslate.Substring(0, 1);
                return wordToTranslate + "way";
            }
            else
            {
                int indexOfFirstVowel = 0;
                string letterAtIndex = wordToTranslate.Substring(indexOfFirstVowel, 1);

                while(!(letterAtIndex == "a" || letterAtIndex == "e" || letterAtIndex == "i" || letterAtIndex == "o" || letterAtIndex == "u"))
                {
                    indexOfFirstVowel++;
                    letterAtIndex = wordToTranslate.Substring(indexOfFirstVowel, 1);
                }

                return (wordToTranslate.Substring(indexOfFirstVowel) + wordToTranslate.Substring(0, indexOfFirstVowel) + "ay");



            }
            
            

        }

    }
} 




