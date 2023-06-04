        string input = Console.ReadLine();

            int[] allNumbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsDigit(currentChar))
                {
                    allNumbers[i] = currentChar - '0';
                }
            }

            int evenSum = GetSumOfEvenDigits(allNumbers);
            int oddNSum = GetSumOfOddDigits(allNumbers);

            int result = GetMultipleOfEvenAndOdds(evenSum, oddNSum);

            Console.WriteLine(result);
        

         static int GetSumOfOddDigits(int[] allNumbers)
        {
            return allNumbers.Where(x => x % 2 == 1).Sum();
        }

         static int GetSumOfEvenDigits(int[] allNumbers)
        {
            return allNumbers.Where(x => x % 2 == 0).Sum();
        }

         static int GetMultipleOfEvenAndOdds(int evenSum, int oddNSum)
        {
            return evenSum * oddNSum;
        }