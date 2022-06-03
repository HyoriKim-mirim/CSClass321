using System;

namespace CSClass32
{
    class Box2
    {
        public int width;
        public int height;

        public void setWidth(int width)
        {
            if (width > 0)
                this.width = width;
            else
                Console.WriteLine("양수입력해주세요");
            return;
        }

        public void setHeight(int height)
        {
            if (height > 0)
                this.height = height;
            else
                Console.WriteLine("양수입력해주세요");
            return;
        }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        public Box2(int width, int height)
        {
            setWidth(width);
            setHeight(height);
        }
        public int Area()
        {
            return this.width * this.height;
        }
    }
}