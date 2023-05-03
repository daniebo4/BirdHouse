namespace BirdHouse
{
    public enum Species { American, European, Australian }
    public enum AmericanSubSpecies { North, Center, South }
    public enum EuropeanSubSpecies { West, East }
    public enum AustralianSubSpecies { Center, Beach }


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

        public int Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        public Species Specie
        {
            get { return specie; }
            set { specie = value; }
        }

        public object SubSpecies
        {
            get { return subSpecies; }
            set { subSpecies = value; }
        }

        public DateTime HatchDate
        {
            get { return hatchDate; }
            set { hatchDate = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string CageNum
        {
            get { return cageNum; }
            set { cageNum = value; }
        }

        public int FatherSerial
        {
            get { return fatherSerial; }
            set { fatherSerial = value; }
        }

        public int MotherSerial
        {
            get { return motherSerial; }
            set { motherSerial = value; }
        }

    }
}
