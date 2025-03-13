using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    class Car
    {
        public int Age;

        public string ageCategory(int Age)
        {
            if (Age > 0 && Age < 10)
            {
                return "Arabanız yeni";
            }l
            else if (Age >= 10 && Age < 20)
            {
                return "Servise götürmeniz gerekebilir";
            }
            else if (Age >= 20 && Age < 30)
            {
                return "Arabanız hurdaya çıkabilir";
            }
            else
            {
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
        } 
    }
}
