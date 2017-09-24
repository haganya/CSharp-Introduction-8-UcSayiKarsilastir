using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170807_2Con_UcSayiKarsilastirma
{
    class Program
    {
        static void Main(string[] args)
        {
            // konsoldan 3 adet sayı girilsin A>B>C sonucunu versin
            int s1, s2, s3, eb = 0, ek = 0, ortanca = 0;
            Console.Write("1. Sayıyı giriniz : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sayıyı giriniz : ");
            s3 = Convert.ToInt32(Console.ReadLine());
            if (s1 > s2)
            {
                if (s1>s3)
                {
                    eb = s1;
                    if (s2>s3)
                    {
                        ek = s3;
                        ortanca = s2;
                    }
                    else
                    {
                        ek = s2;
                        ortanca = s3;
                    }
                }
                //else if(s1==s3)
                //{

                //}
            }

            if (s2 > s1)
            {
                if (s2 > s3)
                {
                    eb = s2;
                    if (s1 > s3)
                    {
                        ek = s3;
                        ortanca = s1;
                    }
                    else
                    {
                        ek = s1;
                        ortanca = s3;
                    }
                }
                //else if (s2 == s3)///////////////
                //{

                //}
            }

            if (s3 > s2)
            {
                if (s3 > s1)
                {
                    eb = s3;
                    if (s2 > s1)
                    {
                        ek = s1;
                        ortanca = s2;
                    }
                    else
                    {
                        ek = s2;
                        ortanca = s1;
                    }
                }
                //else if(s3 == s1) ////////////////////////////
                //{

                //}
            }

            if (s1==s2 & s2==s3)
            {
                Console.WriteLine("sıralama : {0} > {1} > {2}", s1, s2, s3);
            }
            else
            {
                Console.WriteLine("sıralama : {0} > {1} > {2}", eb, ortanca, ek);
            }

           
            Console.Read();
        }
    }
}
