#include <stdio.h>
#include <cs50.h>

int main(void)
{
    int height;

    do
    {
        height = get_int("Height : ");
    }
    while(height < 1 || height > 8);

    for(int i = 0; i < height; i++)
    {
        int c = i, r = i;
        int space = height - (i + 1);

        while(space > 0)
        {
            printf("%c",' ');
            space--;
        }

        while( c >= 0)
        {
            printf("%c",'#');
            c--;
        }
        printf("%c%c", ' ',' ');
        while( r >= 0)
        {
            printf("%c",'#');
            r--;
        }
        printf("\n");
    }
}
