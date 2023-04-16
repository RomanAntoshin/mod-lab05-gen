using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace generator
{
    public class BiCharGenerator
    {
        private int size;
        private string syms1 = "абвгдежзийклмнопрстуфхцчшщьыэюя";
        private string syms2 = "абвгдежзийклмнопрстуфхцчшщьыэюя";
        private Tuple<char, char>[] pair=new Tuple<char, char>[31*31];
        private char[] data;
        private Random random = new Random();
        int[] weights = new int[31*31];
        int[] np;
        int summa = 0;
        private void Load()
        {
            string buf;
            StreamReader sr = new StreamReader("веса биграм.txt");
            buf = sr.ReadToEnd();
            weights=buf.Split(' ').Select(r => Convert.ToInt32(r)).ToArray();
        }
        private void GetBigram()
        {
            int count = 0;
            char[] s1 = syms1.ToCharArray();
            char[] s2 = syms2.ToCharArray();
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    pair[count]=new Tuple<char, char>(s1[i], s2[j]);
                    count++;
                }
            }
        }
        public BiCharGenerator()
        {
            GetBigram();
            Load();
            size = syms1.Length * syms2.Length;
            data = syms1.ToCharArray();
            for (int i = 0; i < size; i++)
                summa += weights[i];
            np = new int[size];
            int s2 = 0;
            for (int i = 0; i < size; i++)
            {
                s2 += weights[i];
                np[i] = s2;
            }
        }
        public Tuple<char, char> getSym()
        {
            int m = random.Next(0, summa);
            int j;
            //поиск символа по его диапазону случайных значений
            for (j = 0; j < size; j++)
            {
                if (m < np[j])
                    break;
            }
            Tuple<char, char> buf = pair[j];
            return buf;
        }
    }
}
