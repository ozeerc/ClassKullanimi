using System;

namespace Gun2Odev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1001;
            product1.Adi = "Ayakkabı";
            product1.Fiyati = 59.90;
            product1.Aciklama = "Sneaker";
            product1.StokAdeti = 50;

            Product product2 = new Product();
            product2.Id = 2002;
            product2.Adi = "Bilgisayar";
            product2.Fiyati = 6999.99;
            product2.Aciklama = "Gaming Computer";
            product2.StokAdeti = 40;

            Product product3 = new Product();
            product3.Id = 3003;
            product3.Adi = "Oto Aksesuar";
            product3.Fiyati = 15.99;
            product3.Aciklama = "Koltuk Kılıfı";
            product3.StokAdeti = 500;

            Product product4 = new Product();
            product4.Id = 4004;
            product4.Adi = "Sweatshirt";
            product4.Fiyati = 59.90;
            product4.Aciklama = "Baskılı Sweat";
            product4.StokAdeti = 250;


            Product[] products = new Product[] { product1, product2, product3,product4 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Id Numarası :" + products[i].Id);
                Console.WriteLine("Ürün Adı :" + products[i].Adi);
                Console.WriteLine("Ürün Fiyatı :" + products[i].Fiyati + "TL");
                Console.WriteLine("Ürün Açıklaması :" + products[i].Aciklama);
                Console.WriteLine("Ürün Adeti :" + products[i].StokAdeti);
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("For Bitti Sıra Foreach'de :)");
            Console.WriteLine("---------------------");
            Console.WriteLine("");


            foreach (Product product in products)
            {
                Console.WriteLine("Id Numarası:" + product.Id + " - " +"Ürün Adı:" + product.Adi + " - "+ "Ürün Fiyatı:" + product.Fiyati + "TL" + " - " +"Ürün Açıklaması:" + product.Aciklama +" - "+"Ürün Adeti:" + product.StokAdeti);
                //Console.WriteLine("Ürün Adı :" + product.Adi);
                //Console.WriteLine("Ürün Fiyatı :" + product.Fiyati + "TL");
                //Console.WriteLine("Ürün Açıklaması :" + product.Aciklama);
                //Console.WriteLine("Ürün Adeti :" + product.StokAdeti);
                //Console.WriteLine("");
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Foreach Bitti Sıra While'de :)");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            int x = 0;
            while (x < products.Length)
            {
                Console.WriteLine("Id Numarası :" + products[x].Id);
                Console.WriteLine("Ürün Adı :" + products[x].Adi);
                Console.WriteLine("Ürün Fiyatı :" + products[x].Fiyati + "TL");
                Console.WriteLine("Ürün Açıklaması :" + products[x].Aciklama);
                Console.WriteLine("Ürün Adeti :" + products[x].StokAdeti);
                Console.WriteLine("");
                x++;
            }
        }
    }
}
