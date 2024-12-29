namespace ClassLibrary1
{
    public class Calculator
    {
        public int hello;

        public int Hello { get => hello; set => hello = 123; }
        public static float add(float a,float b)
        {
            return  a + b;
        }
        public static float sub(float a, float b)
        {
            return a - b;
        }
        public static float multiply(float a, float b)
        {
            return a * b;
        }
        public static float divide(float a, float b)
        {
            if (b == 0)
                return 0;
            return a / b;
        }

    }
}
