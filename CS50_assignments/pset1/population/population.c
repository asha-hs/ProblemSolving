#include <cs50.h>
#include <stdio.h>

int main(void)
{
    // TODO: Prompt for start size
    int startsize,endsize;
    do
    {
        startsize = get_int("Enter starting population : ");
    }while(startsize < 9);

    // TODO: Prompt for end size

    do{
        endsize = get_int(" Enter end population : ");
    }while(endsize < startsize);

    // TODO: Calculate number of years until we reach threshold
    int year = 0;

    int newbornsize = startsize / 3;
    int passawaysize = startsize / 4;

    int currentsize = startsize;

    while(currentsize < endsize)
    {
        currentsize +=  newbornsize - passawaysize;
        year++;
        newbornsize = currentsize / 3;
        passawaysize = currentsize / 4;
    }


    // TODO: Print number of years
    printf("Years: %i",year);
}