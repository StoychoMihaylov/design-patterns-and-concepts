namespace ServiceLocatorDesignPattern.StrongTypeServiceLocator.Services
{
    using ServiceLocatorDesignPattern.StrongTypeServiceLocator.Interfaces;
    using System;

    public class CalculationService : ICalculationService
    {
        public int CalculateSumOfArray(int[] array)
        {
            int sum = 0;

            foreach (var number in array)
            {
                sum += number;
            }

            return sum;
        }

        public string ReverseString(string str)
        {
            char[] charAttay = str.ToCharArray();
            Array.Reverse(charAttay);

            return new string(charAttay);
        }
    }
}
