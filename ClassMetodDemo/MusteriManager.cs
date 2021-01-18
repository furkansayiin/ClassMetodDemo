using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi.");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi.");
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri listelendi.");
        }
    }
}
