﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);
            
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " ₺");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " ₺");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma       " + "-Birim Fiyat: " + applePrice + " ₺   " + "-Gramaj:" + appleGram + " g   " + "-Toplam Tutar:" + appleTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Portakal   " + "-Birim Fiyat: " + orangePrice + " ₺   " + "-Gramaj:" + orangeGram + " g   " + " -Toplam Tutar:" + orangeTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Çilek      " + "-Birim Fiyat: " + strawberryPrice + " ₺      " + "-Gramaj:" + strawberryGram + " g   " + " -Toplam Tutar:" + strawberryTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Patates    " + "-Birim Fiyat: " + potatoPrice + " ₺    " + "-Gramaj:" + potatoGram + " g   " + "-Toplam Tutar:" + potatoTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Domates    " + "-Birim Fiyat: " + tomatoPrice + " ₺    " + "-Gramaj:" + tomatoGram + " g   " + "-Toplam Tutar:" + tomatoTotalPrice + " ₺");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " ₺");

            #endregion

            #region Char Değişkenler

            //ABCDFEGH
            //DEF....
            //Toplantı Saat 20.00'da
            //" ' sembolleri

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurnname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber ;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurnname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik Numarası:"+ " " + passengerIdentityNumber +"Yolcu Ad Soyad: "+ passengerName +" "+passengerSurnname+ " "+ passengerDistrict+" / "+ passengerCity+" "+ passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Adedini Giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());  

            //Console.Write("Lütfen Aldığınız Bilgisayar Adedini Giriniz:");
            //computerCount = int.Parse(Console.ReadLine());  

            //Console.Write("Lütfen Aldığınız Sandalye Adedini Giriniz:");
            //chairCount = int.Parse(Console.ReadLine());  

            //Console.Write("Lütfen Aldığınız Televizyon Adedini Giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+ totalPrice +" TL");

            #endregion

            #region Klavyedden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notunuzu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunuzu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunuzu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());

            //result=(exam1+exam2 + exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " +gender);

            #endregion

            Console.Read();

        }
    }
}
