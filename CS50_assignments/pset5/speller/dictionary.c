// Implements a dictionary's functionality

#include <ctype.h>
#include <stdbool.h>
#include <strings.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <stdint.h>

#include "dictionary.h"

// Represents a node in a hash table
typedef struct node
{
    char word[LENGTH + 1];
    struct node *next;
}
node;

// TODO: Choose number of buckets in hash table
const unsigned int N = 10000;

// Number of words
unsigned int count = 0;

// Hash table
node *table[N];

// Returns true if word is in dictionary, else false
bool check(const char *word)
{
    // TODO
    // Hash word to obtain hash value
    unsigned int index = hash(word);

    // Access linked list at that index in hash table
    node *cursor = table[index];

    while(cursor != NULL)
    {
        if(strcasecmp(cursor->word, word) == 0)
        {
            return true;
        }

        cursor = cursor->next;
    }
    return false;
}

// Hashes word to a number
unsigned int hash(const char *word)
{
    // TODO: Improve this hash function

  int len = strlen(word);
  int sum = 0;

   for(int i = 0; i < len; i++)
   {
      sum += tolower(word[i]);
   }

   return sum % N;
   // return toupper(word[0]) - 'A';
}

// Loads dictionary into memory, returning true if successful, else false
bool load(const char *dictionary)
{
    // TODO
     // Open dictionary file
    FILE *file = fopen(dictionary,"r");

    // Check if null
    if( file == NULL)
    {
        printf("Unable to open %s\n", dictionary);
        return false;
    }

     // Initialise word array
    char word[LENGTH+1];
    // Read strings from file one at a time
    while(fscanf(file,"%s",word) != EOF)
    {
         // Create new node for each word
        node *newnode = malloc(sizeof(node));


        if(newnode == NULL)
            return false;

        // copy word into node using strcopy
        strcpy(newnode->word, word);
        newnode->next = NULL;

         // Hash word to obtain hash value
        int index = hash(word);

        // Insert node into hash table at that location
        newnode->next = table[index];
        table[index] = newnode;
        count++;
    }

     // Close file
     fclose(file);
    return true;
}

// Returns number of words in dictionary if loaded, else 0 if not yet loaded
unsigned int size(void)
{
    // TODO
    return count;
}

// Unloads dictionary from memory, returning true if successful, else false
bool unload(void)
{
    // TODO
    // Iterate over hash table and free nodes in each linked list
    for(int i = 0; i < N; i++)
    {
        // Assign cursor
        node *cursor = table[i];

        // Loop through linked list
        while(cursor != NULL)
        {
            // Make temp equal cursor;
            node *tmp = cursor;
            cursor = cursor->next;
            free(tmp);
        }

        if(cursor == NULL && i == N-1)
        {
            return true;
        }

    }
    return false;
}
