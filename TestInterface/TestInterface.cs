namespace TestInterface
{
    // All the code in this file is included in all platforms.
    public interface IArithmeticOP
    {
        public int Add(int leftnum, int rightnum);

        public int Subtract(int leftnum, int rightnum);

        public int Multiply(int leftnum, int rightnum);

        public int Divide(int leftnum, int rightnum);
    }
}