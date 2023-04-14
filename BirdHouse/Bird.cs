using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BirdHouse
{    
    enum Species { American, European, Australian }
    enum AmericanSubSpcies { North, Center, South }
    enum EuropeanSubSpcies { West, East }
    enum AustralianSubSpcies { Center, Beach }


    internal class Bird
    {
        private int serial;
        private Species specie;
        private object subSpecies;
        private DateTime hatchDate;
        private string gender;
        private string cageNum;
        private int fatherSerial;
        private int motherSerial;

        public Bird(int serial, Species specie, object subSpecies, DateTime hatchDate, string gender, string cageNum, int fatherSerial, int motherSerial)
        {
            this.serial = serial;
            this.specie = specie;
            this.subSpecies = subSpecies;
            this.hatchDate = hatchDate;
            this.gender = gender;
            this.cageNum = cageNum;
            this.fatherSerial = fatherSerial;
            this.motherSerial = motherSerial;
        }

    }
}
