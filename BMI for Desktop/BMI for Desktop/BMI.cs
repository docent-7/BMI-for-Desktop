using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_for_Desktop
{
    class BMI
    {
        public float masaOsoby 
        {
            get
            {
                return masaCzlowieka;
            }
            set
            {
                masaCzlowieka = value;
            }
        }
        public float wzrostOsoby 
        { 
            get
            {
                return wzrostCzlowieka;
            }
            set
            {
                wzrostCzlowieka = value;
            }
        }

        private float masaCzlowieka;
        private float wzrostCzlowieka;

        private float BMI;

        public float obliczBMI(float masa, float wzrost)
        {
            BMI = masa / (wzrost * wzrost);

            return BMI;
        }
    }
}
