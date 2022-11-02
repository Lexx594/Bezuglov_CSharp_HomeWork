using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    
    static class Message
    {
        private static string[] separators = { ".", ",", "!", "?", ";", ":", " ", "-" }; // Создаем массив с разделитеми, которые могут быть использованы в строке

        public static Dictionary<string, int> TextAnaysis(string massage, string[] words)
        {
            if (string.IsNullOrEmpty(massage) || words == null)
            {
                return null;
            }

            Dictionary<string, int> analysisDict = new Dictionary<string, int>();
            string[] messageWords = massage.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < messageWords.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (messageWords[i].Equals(words[j]))
                    {
                        if (analysisDict.ContainsKey(words[j]))
                        {
                            analysisDict[words[j]] += 1;
                        }
                        else
                            analysisDict.Add(words[j], 1);

                    }


                }


            }
            return analysisDict;
        }


    }

    
    
    internal class Sample02
    {
        static void Main(string[] args)
        {

            string message = "дловауулоущ уща мир солнце уаущал луащлущ солнце аущалу мир аущалуащу узащл мир аузащлуаыщ мир аыузщалыщуа щлущаыулаыл солнце щыулащыуаз ыуаащлыа ы ау";
            Dictionary<string, int> dict = Message.TextAnaysis(message, new string[] { "мир", "солнце" });

            foreach(KeyValuePair<string, int> element in dict)
            {

                Console.WriteLine($"{element.Key} встречается {element.Value} раз");
            }

        Console.ReadLine(); 
        }
        

    }
}
