#include <stdio.h>
#include <cs50.h>

int main(void)
{
    long cardnumber = get_long("Number: ");
    int count = 0;
    int products_digits_sum = 0;
    int digits_sum = 0;
    int digits_not_multiplied_sum = 0;
    int digit;
    int checksum = 0;
    int seconddigit = 0;

    while (cardnumber > 0)
    {
        digit = cardnumber % 10;
        count++;
        cardnumber = cardnumber / 10;


        if (cardnumber < 10 && cardnumber > 0)
        {

            seconddigit = digit;

        }

        if (count % 2 == 0)
        {
            int copydigit = digit;
            copydigit = copydigit * 2;

            products_digits_sum = 0;
            while (copydigit > 0)
            {
                products_digits_sum += copydigit % 10;

                copydigit = copydigit / 10;
            }

            digits_sum += products_digits_sum;

        }
        else {
            digits_not_multiplied_sum += digit;
        }

    }


    checksum = digits_sum + digits_not_multiplied_sum;



    if ((checksum % 10) == 0)
    {


        if (count == 15 && digit == 3 && (seconddigit == 4 || seconddigit == 7))
            printf("AMEX\n");
        else if (count == 16 && digit == 5 && seconddigit < 6)
            printf("MASTERCARD\n");
        else if ((count == 13 || count == 16) && digit == 4)
            printf("VISA\n");
        else
            printf("INVALID\n");
    }
    else
        printf("INVALID\n");

}