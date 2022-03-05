using System;
using ValueAndReferenceTypes; // Kullanicagimiz kutuphaneyi deklare ediyoruz.

namespace ValueAndRefTypeApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            var p1 = new ValueAndReferenceTypes.ValueType
            {
                X = 10,
                Y= 20
            };
            var p2 = p1;
            p2.X = 30;
            Console.WriteLine($"P1: {p1.X} {p1.Y}");
            Console.WriteLine($"P2: {p2.X} {p2.Y}");

            /*RefType için p1 ve p2 nin bellek üzerinde göstermis oldugu alanlar aynı oldugu
            icin yapilan degisiklikler her ikisine de etki etmis oldu.*/
            
            /*ValueType icin degeriyle birlikte stack bolgesinde saklanmaktadir. 
             * Alacagimiz sonucta p2.X yapılan degisiklik p1.X inde gozukmeyecektir. */

        }
    }
}
