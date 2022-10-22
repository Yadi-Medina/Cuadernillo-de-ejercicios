using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace swicht
{
 class Program
 {
  static void Main(string[] args)
  {

int mes;
Console.WriteLine("ingrese el numero de mes");
mes=int.Parse(Console.ReadLine());

switch(mes)
{
    case 1: Console.Write("enero");
    break;
     case 2: Console.Write("febrero");
    break;
     case 3: Console.Write("marzo");
    break;
     case 4: Console.Write("abril");
    break;
     case 5: Console.Write("mayo");
    break;
     case 6: Console.Write("junio");
    break;
     case 7: Console.Write("julio");
    break;
     case 8: Console.Write("agosto");
    break;
     case 9: Console.Write("septiembre");
    break;
     case 10: Console.Write("octubre");
    break;
    
     case 11: Console.Write("noviembre");
    break;
     case 12:Console.Write("diciembre");
    break;
    default: Console.Write("ese mes no existe");
    break;
}
   Console.ReadKey();
  }
 }
}