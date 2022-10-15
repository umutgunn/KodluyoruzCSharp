using System;
using System.Collections;

public class Odev
{
    static void Main(){
        int odev;
        Console.WriteLine("Ödevi seçiniz: ");
        odev = int.Parse(Console.ReadLine());

        if(odev==1){
            int boyut;
            ArrayList ciftSayilar = new ArrayList();
            Console.WriteLine("Kaç sayı gireceğinizi yazın: ");
            boyut = int.Parse(Console.ReadLine());
            int[] sayilar = new int[boyut];

            for(int i=0; i<sayilar.Length;i++){
                Console.Write((i+1)+ ". sayıyı giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
                if(sayilar[i]%2==0){
                    ciftSayilar.Add(sayilar[i]);
                }
            }
            Console.WriteLine("Girdiğiniz çift sayılar");
            foreach(var item in ciftSayilar){
                Console.WriteLine(item);
            }
        }
        if(odev==2){
            int m,n;
            ArrayList bolunenler = new ArrayList();
            Console.Write("m sayıyısını giriniz: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("n sayıyısını giriniz: ");
            n = int.Parse(Console.ReadLine());
            int[] sayilar = new int[n];
            
            if(m>0 && n>0){
                for(int i=0; i<sayilar.Length;i++){
                    Console.Write((i+1)+ ". sayıyı giriniz: ");
                    sayilar[i] = int.Parse(Console.ReadLine());
                    if(sayilar[i]%m==0){
                        bolunenler.Add(sayilar[i]);
                    }
                }
                Console.WriteLine("m'ye bölünebilen sayilar");
                foreach(var item in bolunenler){
                    Console.WriteLine(item);
                }
            }
        }
        
        if(odev==3){
            int n;
            Console.Write("Kaç kelime yazcağınızı giriniz: ");
            n = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[n];
            
            for(int i=0;i<kelimeler.Length;i++){
                Console.WriteLine((i+1)+ ". kelimeyi giriniz: ");
                kelimeler[i] = Console.ReadLine();
            }
            Array.Reverse(kelimeler);
            foreach(var item in kelimeler)
                Console.WriteLine(item);
        }
        if(odev==4){
            Console.WriteLine("Cümleyi giriniz: ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(" ");
            char[] harfler = cumle.ToCharArray();
            Console.WriteLine("Cümledeki kelime sayısı :"+kelimeler.Length);
            Console.WriteLine("Cümledeki harf sayısı :"+harfler.Length);
        }
    }
}