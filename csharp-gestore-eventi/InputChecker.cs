using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;

namespace csharp_gestore_eventi
{
    public static class InputChecker
    {
        
        public static int GetIntInput()
        {
            while (true)
            {

                if (int.TryParse(ReadLine(), out int result))
                {
                    return result;
                }
                WriteLine("Input non valido. Iserisci un numero intero.");
            }
        }

        public static string GetStringInput()
        {
            while (true)
            {
                //WriteLine("Inserisci una parola");
                string? word = ReadLine();
                if (!string.IsNullOrEmpty(word))
                {
                    if (int.TryParse(word, out int result))
                    {
                        WriteLine("Input non valido, inserisci una stringa");
                        continue;
                    }
                    return word;
                }
                WriteLine("Input non valido, inserisci una stringa");

            }
        }

        public static bool IsStringYesOrNo(string myString)
        {
            while(true){

            string[] acceptableYesValues = { "si", "s","y","ye","yes" };
            string[] acceptableNoValues = { "no", "n" };
            if (acceptableYesValues.Contains(myString.ToLower()))
            {
                return true;
            }else if(acceptableNoValues.Contains(myString.ToLower()))
            {
                return false;
            }else{
                Console.WriteLine("Input non valido, i valori ammessi sono: si, no");
                continue;
            }
            }
        }
            
        
        

        
        public static DateTime GetDateTimeInput()
        {
            while (true)
            {
                
                string? eventDate = ReadLine();
                string format = "dd/MM/yyyy"; // Specify the format

                if (DateTime.TryParseExact(eventDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    return parsedDate;
                }
                else
                {
                    WriteLine("Data non valida, inserisci una data nel formato MM/dd/yyyy");
                }
            }
        }



    }
}
