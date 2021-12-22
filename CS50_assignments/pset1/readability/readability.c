#include <stdio.h>
#include <cs50.h>
#include <string.h>
#include <ctype.h>
#include <math.h>

int count_letters(string text);
int count_words(string text);
int count_sentences(string text);

int main(void)
{
    string text = get_string("Text : ");

    int letters = count_letters(text);

    int words = count_words(text);

    int sentences = count_sentences(text);
    //index = 0.0588 * L - 0.296 * S - 15.8
    //where L is the average number of letters per 100 words in the text, and S is the average number of sentences per 100 words in the text.

    float average_letters = (letters * 100.0) / words;
    float average_sentences = (sentences * 100.0) / words;

    float index = (0.0588 * average_letters) - (0.296 * average_sentences) - 15.8;

    if(index < 1)
    {
        printf("Before Grade 1\n");
    }
    else
    {
        int grade = round(index);

        if(grade > 16)
        {
            printf("Grade 16+\n");
        }
        else
        {
            printf("Grade %i\n",grade);
        }

    }


  //  printf("%i letter(s)\n",letters);
  //  printf("%i word(s)\n",words);
  //  printf("%i sentence(s)\n",sentences);
}

int count_letters(string text)
{
    int count = 0;
    for(int i = 0, n = strlen(text); i < n; i++)
    {
        if(isupper(text[i]) || islower(text[i]))
        {
            count++;
        }

    }

    return count;
}

int count_words(string text)
{
    int count = 0;

    for(int i = 0, n = strlen(text); i < n; i++)
    {
        if(text[i] == ' ')
        {
            count++;
        }
    }

    // add one extra to count the last word
    return count+1;
}

int count_sentences(string text)
{
    int count = 0;

    for(int i = 0, n = strlen(text); i < n; i++)
    {
        if(text[i] == '.' || text[i] == '!' || text[i] == '?')
        {
            count++;
        }
    }

    return count;
}