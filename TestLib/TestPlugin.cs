namespace TestLib
{
    using TestInterface;

    // All the code in this file is included in all platforms.
    public class TestPlugin : IArithmeticOP
    {
        ArithmeticImpl arithmeticImpl = new ArithmeticImpl();

        public int Add(int leftnum, int rightnum)
        {
            return arithmeticImpl.Add(leftnum, rightnum);
        }

        public int Divide(int leftnum, int rightnum)
        {
            return arithmeticImpl.Divide(leftnum, rightnum);
        }

        public int Multiply(int leftnum, int rightnum)
        {
            return arithmeticImpl.Multiply(leftnum, rightnum);
        }

        public int Subtract(int leftnum, int rightnum)
        {
            return arithmeticImpl.Subtract(leftnum, rightnum);
        }
    }
}