using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_İşlemleri2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "C# programlama dilini öğrenmek çok eğlenceli.";

            // Substring
            string parca = metin.Substring(3, 12);
            Console.WriteLine($"Substring ile alınan parça: {parca}");

            // Replace
            string duzenlenmis = metin.Replace("eğlenceli", "yararlı");
            Console.WriteLine($"Replace işlemi sonrası: {duzenlenmis}");

            // Split
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Split ile ayrılmış kelimeler:");
            foreach (var k in kelimeler)
            {
                Console.WriteLine(k);
            }

            // Join
            string yeniCümle = string.Join(" | ", kelimeler);
            Console.WriteLine($"Join ile birleştirilmiş hali: {yeniCümle}");

            // StringBuilder ile tersten yazdırma
            StringBuilder sb = new StringBuilder();
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                sb.Append(metin[i]);
            }
            Console.WriteLine("Metnin tersten yazımı: " + sb.ToString());
        }
    }
}
