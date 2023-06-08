string input = Console.ReadLine();
PasswordValidator(input);

static void PasswordValidator(string input){

    bool length = false;
    bool lettersDigits = true;
    bool digits2 = false;
    int counterDigits = 0;

    if (input.Length >= 6 && input.Length <= 10)
            {
                length = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if ((int)current >= 48 && (int)current <= 57)
                {
                    counterDigits++;
                }

                if ((int)current < 48 || (int)current > 122 ||
                    (int)current > 90 && (int)current < 97 ||
                    (int)current > 57 && (int)current < 65)
                {
                    lettersDigits = false;
                }
            }

            if (lettersDigits == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (counterDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else if (counterDigits >= 2)
            {
                digits2 = true;
            }
            
            if (length && lettersDigits && digits2)
            {
                Console.WriteLine("Password is valid");
            }
}
