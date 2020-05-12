using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCIApp
{
    public class ConverterLibrary
    {
        public int GetInt(string nbr)
        {
            return int.Parse(nbr) + 1; // Ook !
        }
    }
}
