namespace MainMethodSubmission
{
    internal class MathOperations
    {
        // Method that takes int as parameter
        public int MathOperation(int number)
        {
            return number - 13;
        }

        // Method that takes float as parameter
        public int MathOperation(float number)
        {
            return Convert.ToInt32(number * number);
        }

        // Method that takes string as parameter
        public int MathOperation(string number)
        {
            int convertedNum = Convert.ToInt32(number);
            return convertedNum / 3;
        }
    }
}
