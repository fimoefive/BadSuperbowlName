using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadSuperbowlName
{
  public class NumberTranslator
  {
    public string Translate(int numberToTranslate)
    {
      /*
      // Switch Expression
      return numberToTranslate switch
      {
        1 => "I",
        2 => "II",
        3 => "III",
        4 => "IV",
        // _ discard
        _ => ""
      };
*/
      switch (numberToTranslate)
      {
        case 1:
          return "I";
        case 2:
          return "III";
        case 3:
          return "IV";
        default:
          return "";
      }

    }

  }
}
