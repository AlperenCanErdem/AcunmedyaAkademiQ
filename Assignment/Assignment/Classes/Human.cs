using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    class Human
    {
        public string Name;
        public int Age;

        public string ageCategory(int Age)
        {
            if (Age > 0 && Age < 18)
            {
                return "Küçüksünüz";
            }
            else if (Age >= 18 && Age < 35)
            {
                return "Gençsiniz";
            }
            else if (Age >= 35 && Age < 55)
            {
                return "Yetişkinsiniz";
            }
            else if (Age >= 55 && Age < 75)
            {
                return "Yaşlısınız";
            }
            else if (Age >= 75 && Age < 99)
            {
                return "Çok yaşlısınız";
            }
            else
            {
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
            }
        }
    }
}
