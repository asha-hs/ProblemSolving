#include <stdio.h>
#include <cs50.h>
#include <string.h>
#include <ctype.h>


int main(int argc, string argv[])
{
    if(argc != 2)
    {
        printf("Usage: ./substitution key \n");
        return 1;
    }

     int keysize = strlen(argv[1]);
    if(keysize < 26 || keysize > 26)
    {
        printf("Key must contain 26 characters.\n");
        return 1;
    }



    bool is_only_alpha = true;
    bool is_unique = true;

    int alpha_arr[26];

    string key = argv[1];

    for(int i = 0; i < 26; i++)
    {
        alpha_arr[i] = 0;
    }

    for(int i = 0; i < keysize; i++)
    {
        if(!isalpha(argv[1][i]))
        {
            is_only_alpha = false;
            break;
        }
        if(isupper(argv[1][i]))
        {
            alpha_arr[argv[1][i] - 'A']++;
            if(alpha_arr[argv[1][i] - 'A'] > 1)
            {
                is_unique = false;
                break;
            }
        }

        if(islower(argv[1][i]))
        {
            alpha_arr[argv[1][i] - 'a']++;
            if(alpha_arr[argv[1][i] - 'a'] > 1)
            {
                is_unique = false;
                break;
            }
        }
    }

    if(!is_only_alpha)
    {
         printf("Usage: ./substitution key, key only contains alphabet characters\n");
        return 1;
    }
    if(!is_unique)
    {
         printf("Usage: ./substitution key, key should contain unique alphabet characters\n");
        return 1;
    }

    string plaintext = get_string("plaintext: ");

    int len = strlen(plaintext);
    string cipertext = plaintext;

    for(int i = 0; i < len; i++)
    {
        if(isupper(plaintext[i]))
        {
            cipertext[i] = toupper(key[plaintext[i] - 'A']);
        }else if(islower(plaintext[i]))
        {
            cipertext[i] = tolower(key[plaintext[i] - 'a']);
        }

    }

    printf("ciphertext: %s", cipertext);
    printf("\n");
    return 0;
}