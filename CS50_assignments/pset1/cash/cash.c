#include <stdio.h>
#include <cs50.h>
#include <math.h>

int main(void)
{
    // only coins available are quarters (25¢), dimes (10¢), nickels (5¢), and pennies (1¢).
    float dollars;
    do{
        dollars = get_float("Change owed: ");
    }
    while(dollars < 0);

    int cents = round(dollars * 100);
    int coins = 0;

    if(cents > 0)
    {
        int quarters = cents / 25;
        cents = cents % 25;
        coins += quarters;

        printf("coins= %i\n",coins);
        printf("cents= %i\n",cents);

        int dimes = cents / 10;
        cents = cents % 10;
        coins += dimes;

        int nickels = cents / 5;
        cents = cents % 5;
        coins += nickels;

        int pennies = cents / 1;

        cents = cents % 1;

        coins += pennies;

    }

    printf("%i\n",coins);

}