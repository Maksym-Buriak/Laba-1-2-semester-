using System;
using System.Text.Json;


namespace Завдання_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("key1", "value1");
            dictionary.Add("key2", "value2");
            dictionary.Add("key3", "value3");
            dictionary.Add("key4", "value4");
            dictionary.Add("key5", "value5");
            dictionary.Add("key6", "value6");
            dictionary.Add("key7", "value7");
            dictionary.Add("key8", "value8");
            dictionary.Add("key9", "value4");

            string json = JsonSerializer.Serialize(dictionary);
            Console.WriteLine(json);

            Console.WriteLine("\nПочатковий словник: ");
            PrintDictionary(dictionary);

            Dictionary<string, string> DictionaryResult = dictionary.GroupBy(x => x.Value)
                                                                    .Where(g => g.Count() > 1)
                                                                    .SelectMany(g => g)
                                                                    .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("\nПеретворений словник: ");
            PrintDictionary(DictionaryResult);

            string json2 = JsonSerializer.Serialize(DictionaryResult);
            Console.WriteLine(" ");
            Console.WriteLine(json2);

            static void PrintDictionary(Dictionary<string, string> dictionary)
            {
                foreach (KeyValuePair<string, string> dict in dictionary)
                {
                    Console.WriteLine($"Key = {dict.Key}; Value = {dict.Value} ");
                }
            }


            Console.ReadKey();
        }
    }
}
