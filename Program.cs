using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morris_Pratt_algorithm
{
    internal class Program
    {
        static int[] parcala(string pattern)
        {//bu kısımda arayacağımız kelimeyi pattern şeklinde parçalara ayırıyoruz.
            int m = pattern.Length;
            int[] pi = new int[m];
            int k = 0;
            for (int q = 1; q < m; q++)
            {
                while (k > 0 && pattern[k] != pattern[q])
                {
                    k = pi[k - 1];
                }
                if (pattern[k] == pattern[q])
                {
                    k = k + 1;
                }
                pi[q] = k;
            }
            return pi;
        }
        static int MorrisPratt(string text, string pattern)
        {
            //n ile gönderdiğimiz metinin m ile de gönderdiğimiz kelimenin uzunluklarını belirtiyoruz.
            int n = text.Length;
            int m = pattern.Length;
            //kelimeyi parcala fonksiyonuna gönderiyor ve int[] pi dizisine eşitliyoruz.
            int[] pi = parcala(pattern);
            int q = 0;
            //for döngüsüyle birlikte metin içinde kelimenin parçalanmış halini aramaya başlıyoruz
            for (int i = 0; i < n; i++)
            {
                while (q > 0 && pattern[q] != text[i])
                {//q nun sıfırdan büyük olup olmadığı ve pattern[q]  text[i] eşitsizliği kontrol ediliyor 
                    q = pi[q - 1];
                }
                if (pattern[q] == text[i])
                {//pattern[q] = text[i] olduğunda bir geniş paterne bakmak için q bir arttırılıyor
                    q = q + 1;
                }
                if (q == m)
                {//q=m olduğunda kelime bulunmuş oluyor fonksiyon sonlandırılıp index değeri geri döndürülüyor.
                    return i - m + 1;
                }
            }
            return -1;
        }





        static void Main(string[] args)
        {
            int secim;
            int index = -1;
            // !!!!!!!!! bu kısımda repo dosyamızın içindeki txt belgemizin konumunu belirtiyoruz bu alanı kendi dosya diziminize göre düzeltiniz !!!!!!!!
            string metin = File.ReadAllText("C:/Users/yusuf/source/repos/Morris~Pratt~algorithm/alice_in_wonderland.txt");
            Console.WriteLine("Alice in wonderland metninde kelime arama uygulaması\nseçiminizi aşağıdaki seçim haritasına göre yapabilirsiniz.\n\n");
        /*
        upon
        sigh
        Dormouse
        jury-box
        swim
        */
        git1:
            Console.WriteLine("upon için ----------------------------->1");
            Console.WriteLine("sigh için ----------------------------->2");
            Console.WriteLine("Dormouse için ------------------------->3");
            Console.WriteLine("jury-box için ------------------------->4");
            Console.WriteLine("swim için ----------------------------->5");
            Console.WriteLine("kendi aramak istediğiniz metin için --->6");
            Console.WriteLine("çıkış  için --------------------------->0\n");
            Console.Write("Seçiminiz->");
            try
            {
                secim = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
            }
            catch (Exception)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lütfen Bir Sayı Giriniz", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                goto git1;

            }



            string kelime = "";
            switch (secim)
            {
                case 1:
                    kelime = "upon";
                    index = MorrisPratt(metin, kelime);
                    break;

                case 2:
                    kelime = "sigh";
                    index = MorrisPratt(metin, kelime);
                    break;
                case 3:
                    kelime = "Dormouse";
                    index = MorrisPratt(metin, kelime);
                    break;
                case 4:
                    kelime = "jury-box";
                    index = MorrisPratt(metin, kelime);
                    break;
                case 5:
                    kelime = "swim";
                    index = MorrisPratt(metin, kelime);
                    break;
                case 6:
                    Console.WriteLine("Lütfen aşağıya aramak istediğiniz kelimeyi giriniz.");
                    kelime = Console.ReadLine();
                    index = MorrisPratt(metin, kelime);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Lütfen verilen seçimler içinde kalınız.");
                    goto git1;

            }
            if (index == -1)
            {
                Console.WriteLine("Aradığınız *" + kelime + "* kelimesi metin içinde bulunamamıştır");
            }
            else if (index > 0)
            {
                Console.WriteLine("Aradığınız *" + kelime + "* kelimesi " + index + ". indexten başlar durumda bulunmuştur.");
            }

            Console.WriteLine("Uygulamadan çıkış yapmak için 0 seçimini yapabilirsiniz.\n\n");

            goto git1;













        }
    }
}
