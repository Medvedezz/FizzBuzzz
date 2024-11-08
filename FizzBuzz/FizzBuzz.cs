namespace FizzBuzz.Project
{
    public class FizzBuzzClass
    {
        public FizzBuzzClass() { }

        public String play(int number)
        {
            if (number % 5 == 0)
            {
                return "Fizz";
            }
            if (number % 3 == 0)
            {
                return "Buzz";
            }
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            return number.ToString();
        }
    }
}