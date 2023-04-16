using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace generator
{
    public class BiWordGenerator
    {
        private int size = 100;
        private Tuple<string, int>[] Dictionary = new Tuple<string, int>[100];
        private Random random = new Random();
        int[] np;
        int summa = 0;
        private void Load()
        {
            StreamReader sr = new StreamReader("пары слов.txt");
            string[] buf = new string[4];
            for (int i = 0; i < size; i++)
            {
                buf = sr.ReadLine().Split('#');
                Dictionary[i] = new Tuple<string, int>(buf[1], int.Parse(buf[3]) / 100);
            }
        }
        public BiWordGenerator()
        {
            Load();
            for (int i = 0; i < size; i++)
                summa += Dictionary[i].Item2;
            np = new int[size];
            int s2 = 0;
            for (int i = 0; i < size; i++)
            {
                s2 += Dictionary[i].Item2;
                np[i] = s2;
            }
        }
        public string getSym()
        {
            int m = random.Next(0, summa);
            int j;
            //поиск символа по его диапазону случайных значений
            for (j = 0; j < size; j++)
            {
                if (m < np[j])
                    break;
            }
            string buf = Dictionary[j].Item1;
            return buf;
        }
    }
}
