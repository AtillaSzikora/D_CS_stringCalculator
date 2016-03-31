using static System.Int32;
using static System.String;

namespace StringCalculatorKata
{
    public class CalculatorKata
    {
        public static int Add(string textToAdd)
        {
            if (IsNullOrEmpty(textToAdd))
            {
                return 0;
            }
            textToAdd = textToAdd.Replace("\n", ",");
            string[] numbers = textToAdd.Split(',');
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += Parse(number);
            }
            return sum;
        }
    }
}