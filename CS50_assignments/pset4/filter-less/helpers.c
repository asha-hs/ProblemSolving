#include "helpers.h"
#include <stdio.h>
#include <math.h>

// Convert image to grayscale
void grayscale(int height, int width, RGBTRIPLE image[height][width])
{
    float rgbGray;
    for(int i = 0; i < height; i++)
    {
        for(int j = 0; j < width; j++)
        {
            rgbGray = round((image[i][j].rgbtBlue + image[i][j].rgbtGreen + image[i][j].rgbtRed) / 3.0);

            image[i][j].rgbtBlue = rgbGray;
            image[i][j].rgbtGreen = rgbGray;
            image[i][j].rgbtRed = rgbGray;

        }
    }
    return;
}
int limit(int RGB)
{
    if(RGB > 255)
    {
        RGB = 255;
    }
    return RGB;
}
// Convert image to sepia
void sepia(int height, int width, RGBTRIPLE image[height][width])
{
    int sepiaRed;
    int sepiaGreen;
    int sepiaBlue;
    for(int i = 0; i < height; i++)
    {
        for(int j = 0; j < width; j++)
        {
             sepiaRed = limit(round(.393 * image[i][j].rgbtRed + .769 * image[i][j].rgbtGreen + .189 * image[i][j].rgbtBlue));
             sepiaGreen = limit(round(.349 * image[i][j].rgbtRed + .686 * image[i][j].rgbtGreen + .168 * image[i][j].rgbtBlue));
             sepiaBlue = limit(round(.272 * image[i][j].rgbtRed + .534 * image[i][j].rgbtGreen + .131 * image[i][j].rgbtBlue));



            image[i][j].rgbtRed = sepiaRed;
            image[i][j].rgbtGreen = sepiaGreen;
            image[i][j].rgbtBlue = sepiaBlue;

        }
    }

    return;
}

// Reflect image horizontally
void reflect(int height, int width, RGBTRIPLE image[height][width])
{
    for(int i = 0; i < height; i++)
    {
        for(int j = 0; j < width/2; j++)
        {
                int tempred = image[i][j].rgbtRed;
                int tempgreen = image[i][j].rgbtGreen;
                int tempBlue = image[i][j].rgbtBlue;

                image[i][j].rgbtRed = image[i][width-j-1].rgbtRed;
                image[i][j].rgbtGreen = image[i][width-j-1].rgbtGreen;
                image[i][j].rgbtBlue = image[i][width-j-1].rgbtBlue;

                image[i][width-j-1].rgbtRed = tempred;
                image[i][width-j-1].rgbtGreen = tempgreen;
                image[i][width-j-1].rgbtBlue = tempBlue;
        }
    }
    return;
}

int getBlur(int i, int j, int height, int width, RGBTRIPLE image[height][width],int color_position)
{
    int sum = 0;
    float counter = 0;
    /* start 1 row before it and end at 1 row after it - total of 3 rows */
    for(int k = i -1; k < (i+2); k++)
    {
        /* start 1 block before it and end at 1 block after it - totak of 3 blockes */
        for(int l = j -1; l < (j+2); l++)
        {
            if( k < 0 || l < 0 || k >= height || l >= width)
            {
                continue;
            }
            if(color_position == 0)
            {
                sum += image[k][l].rgbtRed;
            }
            else if(color_position == 1)
            {
                sum += image[k][l].rgbtGreen;
            }
            else if(color_position == 2)
            {
                sum += image[k][l].rgbtBlue;
            }
            counter++;
        }
    }

    return round(sum / counter);
}

// Blur image
void blur(int height, int width, RGBTRIPLE image[height][width])
{
    RGBTRIPLE copy[height][width];
    for(int i = 0; i < height; i++)
    {
        for(int j = 0; j < width; j++)
        {
            copy[i][j] = image[i][j];
        }
    }

    for(int i = 0; i < height; i++)
    {
        for(int j = 0; j < width; j++)
        {
            image[i][j].rgbtRed = getBlur(i,j,height,width,copy,0);
            image[i][j].rgbtGreen = getBlur(i,j,height,width,copy,1);
            image[i][j].rgbtBlue = getBlur(i,j,height,width,copy,2);
        }
    }
    return;
}
