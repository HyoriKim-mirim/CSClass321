namespace CSClass32
{
    class Box1
    {
        public int width;
        public int height;
        private int v1;
        private int v2;

        public Box1(int height, int v2)
        {
            this.width = height;
            this.height = v2;
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }
}