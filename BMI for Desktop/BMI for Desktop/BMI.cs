using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_for_Desktop
{
    class BMI
    {
        public float masaOsoby { get; set; }
        public float wzrostOsoby { get; set; }

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
