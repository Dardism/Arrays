using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
  class ArrayApp {
    static void Main(string[] args) {
      HighArray highArray = new HighArray(100);

      highArray.insert(11);
      highArray.insert(22);
      highArray.insert(33);
      highArray.insert(44);
      highArray.insert(55);
      highArray.insert(66);
      highArray.insert(77);
      highArray.insert(88);
      highArray.insert(99);
      highArray.insert(100);

      highArray.display();

      int searchKey = 35;
      if (highArray.find(searchKey)) {
        Console.WriteLine("Found " + searchKey + " in array");
      }
      else {
        Console.WriteLine("Can't find " + searchKey);
      }


      //delete three items
      highArray.delete(44);
      highArray.delete(99);
      highArray.delete(22);

      highArray.display();
      Console.ReadKey();
    }
  }
}
