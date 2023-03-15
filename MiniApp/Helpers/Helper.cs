using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp.Helpers
{
    public static class Helper
    {
        public static bool CheckLength( this string data)
     {
      return data.Length > 2 && data.Length < 30&&!string.IsNullOrWhiteSpace(data);
     }
    }
}
