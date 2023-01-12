using System;

namespace YourNamespace
{
    public static class CreditCardHelper
    {
        public static bool IsValid(int[] cardNumber)
        {
            int sum = 0;
            int parity = cardNumber.Length % 2;

            for (int i = 0; i < cardNumber.Length; i++)
            {
                if (i % 2 == parity)
                {
                    sum += cardNumber[i];
                }
                else if (cardNumber[i] > 4)
                {
                    sum += 2 * cardNumber[i] - 9;
                }
                else
                {
                    sum += 2 * cardNumber[i];
                }
            }

            return sum % 10 == 0;
        }
    }
}
