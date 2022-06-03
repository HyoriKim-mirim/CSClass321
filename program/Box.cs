using System;

namespace CSClass32
{
    internal class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set { 
                if (value > 0) width = value;
                else Console.WriteLine("양수를 입력해주세요");
            }
        }
        public int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
                else Console.WriteLine("양수를 입력해주세요");
            }
        }


        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }


        internal string Area()
        {
            throw new NotImplementedException();
        }
    }
}