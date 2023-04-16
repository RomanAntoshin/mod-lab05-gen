using System;
using System.Collections.Generic;
using System.IO;

namespace generator
{
   public class Program
    {
        static void Main(string[] args)
        {
            BiGenerator();
            WordGenerator();
            BiWordGenerator();
        }
        public static void BiGenerator()
        {
            BiCharGenerator gen = new BiCharGenerator();
            StreamWriter writer = new StreamWriter("BiGram.txt");
            SortedDictionary<Tuple<char, char>, int> stat = new SortedDictionary<Tuple<char, char>, int>();
            for (int i = 0; i < 1000; i++)
            {
                Tuple<char, char> ch = gen.getSym();
                if (stat.ContainsKey(ch))
                    stat[ch]++;
                else
                    stat.Add(ch, 1);
                writer.Write(ch);
                writer.Write(" ");
            }
            writer.Write('\n');
            writer.Close();
        }
        public static void WordGenerator()
        {
            WordGenerator gen = new WordGenerator();
            StreamWriter writer = new StreamWriter("Words.txt");
            SortedDictionary<string, int> stat = new SortedDictionary<string, int>();
            for (int i = 0; i < 1000; i++)
            {
                string ch = gen.getSym();
                if (stat.ContainsKey(ch))
                    stat[ch]++;
                else
                    stat.Add(ch, 1);
                writer.Write(ch);
                writer.Write(" ");
            }
            writer.Write('\n');
            writer.Close();
        }
        public static void BiWordGenerator()
        {
            BiWordGenerator gen = new BiWordGenerator();
            StreamWriter writer = new StreamWriter("BiWords.txt");
            SortedDictionary<string, int> stat = new SortedDictionary<string, int>();
            for (int i = 0; i < 1000; i++)
            {
                string ch = gen.getSym();
                if (stat.ContainsKey(ch))
                    stat[ch]++;
                else
                    stat.Add(ch, 1);
                writer.Write(ch);
                writer.Write(" ");
            }
            writer.Write('\n');
            writer.Close();
        }
    }
}

