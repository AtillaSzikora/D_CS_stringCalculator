using System;
using System.Linq;
using static System.Int32;
using static System.String;

namespace StringCalculatorKata {

    public class CalculatorKata {
        private static char delimiter = ',';

        public static int Add(string textToAdd) {
            if (IsNullOrEmpty(textToAdd)) { return 0; }
            if (textToAdd.StartsWith("//")) {
                int firstNewLineIndex = textToAdd.IndexOf('\n');
                string delimiterString = textToAdd.Substring(2, firstNewLineIndex - 2);
                if (delimiterString.Length > 1) { throw new Exception("Custom delimiter length is invalid (max 1)"); }
                delimiter = delimiterString[0]; }

            textToAdd = textToAdd.Replace('\n', delimiter);
            string[] numbers = textToAdd.Split('\n', delimiter);
            int sum = 0;
            foreach (var number in numbers) {
                if (String.IsNullOrEmpty(number)) {
                    throw new ArgumentException("Following chars each other are incorrect."); }
                sum += Parse(number); }
            return sum; }

        private static void Main(string[] args) {}
    }
}