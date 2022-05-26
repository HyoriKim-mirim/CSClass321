namespace CSClass32
{
    internal class Student
    {
        internal string name;
        internal int grade;

        public override string ToString()
        {
            return this.name + " : " + this.grade;
        }
    }
}