using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depreciacionactivos
{
    internal class operaciones
    {
        public bool Numeric(string num)
        {

            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {

               return false;
            }
        }
        public int division (int a, int b)
        {
            return a / b;
        }
    }
  }
