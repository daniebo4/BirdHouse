using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdHouse
{
    public enum Material { Steel, Wood, Plastic }

    internal class Cage
    {
        private String serial;
        string length, width, height;
        private string material;

        public Cage(string serial, string length, string width, string height, string material)
        {
            this.serial = serial;
            this.length = length;   
            this.width = width;
            this.height = height;
            this.material = material;
        }
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }
        public string Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Width
        {
            get { return width; }
            set { width = value; }
        }
        public string Height
        {
            get { return height; }
            set { height = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
    }
}
