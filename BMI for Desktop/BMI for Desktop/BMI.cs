using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_for_Desktop
{
    class BMI
    {
        public string textInfoBMI
        {
            get
            {
                return textInfo;
            }
            set
            {
                textInfo = value;
            }
        }
        
        private string textInfo;
        
        public float obliczBMI(float masa, float wzrost)
        {
            float BodyMassIndex;
            BodyMassIndex = (masa / (wzrost * wzrost));

            return BodyMassIndex;
        }

        public void infoBMI(float infoBodyMassIndex)
        {
            if (infoBodyMassIndex > 40)
            {
                textInfo = "Stopień III otyłości (ekstremalna).";
            }
            else if (infoBodyMassIndex <= 39.9 && infoBodyMassIndex >= 35)
            {
                textInfo = "Stopień II otyłości.";
            }
            else if (infoBodyMassIndex <= 34.9 && infoBodyMassIndex >= 30)
            {
                textInfo = "Stopień I otyłości.";
            }
            else if (infoBodyMassIndex <= 29.9 && infoBodyMassIndex >= 25)
            {
                textInfo = "Nadwaga bez otyłości.";
            }
            else if (infoBodyMassIndex <= 24.9 && infoBodyMassIndex >= 18.5)
            {
                textInfo = "Prawidłowa masa ciała.";
            }
            else if (infoBodyMassIndex < 18.5)
            {
                textInfo = "Niedowaga.";
            }
        }
    }
}
