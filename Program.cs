using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Author: Emereole Chinduji

Poject Name: Cypher converter

Description: Converts plain text into a cypher text. 
 
 
 */

namespace Cypher_Project
{
    class Program
    {
        char[] alphabet ="ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        int shiftNumber = 13;

        static void Main(string[] args)
        {
          var MyClass = new Program();

          Console.WriteLine("Write something (only letters)");

          string userInput = Console.ReadLine();

         Console.WriteLine(MyClass.CypherConvertor(userInput)); 
          
            Console.ReadLine();
        }

        /// <summary>
        /// Method to convert plain text into a cypher text 
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        private string CypherConvertor(string userInput)
        {
            var MyClass = new Program();

            char[] cypherAlphabet = MyClass.AlphabetShifter(shiftNumber);

            char[] input = userInput.ToUpper().ToCharArray();

            string result  = string.Empty;


            for (int y = 0; y < input.Length; y++)
            {
               
              for(int z = 0; z < alphabet.Length; z++)
                {
                    if (alphabet[z] == input[y])
                    {
                        result += cypherAlphabet[z];
                        
                    }
                    else if(input[y] == ' ')
                    {
                       result += new string(' ', 1);
                    }
                    
                }
            }     

            return result;
        }


        /// <summary>
        /// Shift letters from the alphabet to the left.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private char[] AlphabetShifter(int number)
        {
            char[] cypherAlphabet = new char[alphabet.Length];

            for (int i = 0; i < alphabet.Length; i++ )
            {
                cypherAlphabet[i] = alphabet[(i + number) % alphabet.Length];
            
            }

            return cypherAlphabet;
        }


    }
}
