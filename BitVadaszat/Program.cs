using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitVadaszat
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Kérem a számot:");
      int szam;
      szam = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Hanyadik bitjére vagy kiváncsi 0-31 között?");
      int bit;
      bit = Convert.ToInt32(Console.ReadLine());

      int x = 1 << bit;

      int result = szam & x;
      int resultOR = szam | x;
      int result2 = szam & (~x);
      int d;
      d = result == 0 ? 0 : 1;
      Console.WriteLine($"A {bit}-ik helyiérték értéke: {d}");
      Console.WriteLine("Megváltoztassam?(i/n)");
      string valasz;
      valasz = Console.ReadLine();
      int ujeredmeny;
      if(valasz == "i")
      {
        if(d==0)
        {
          ujeredmeny = szam + x;
          Console.WriteLine($"Az új eredmény összeadással:  {ujeredmeny}");
        }
        else
        {
          ujeredmeny = szam - x;
          Console.WriteLine($"Az új eredmény kivonással: {ujeredmeny}");
        }
      }

      int[] bitArray = new int[10];
      int c;
      int result3;
      for (int i = 0; i < 10; i++)
      {
        c = i << bit;
        result3 = szam & c;
        bitArray[i] = result3 == 0 ? 0 : 1;
      }

      Console.WriteLine("A megadott szám bináris formátuma:");

      Console.ReadKey();
    }
  }
}
