using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA
{
    internal class RandomData
    {

        public int randomVaso()
        {
            Random random = new Random(); 
            int RanVaso = random.Next(0, 11); 
            return RanVaso; 
        }

        public int randomCafe()
        {
            Random random = new Random();
            int RanVaso = random.Next(0, 2001);
            return RanVaso;
        }

        public int randomAzucar()
        {
            Random random = new Random();
            int RanVaso = random.Next(0, 21);
            return RanVaso;
        }


    }
}
