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
        int length, width, height;
        private Material material;

        public Cage(string serial, int length, int width, int height, Material material)
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
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public Material Material
        {
            get { return material; }
            set { material = value; }
        }
    }
}
