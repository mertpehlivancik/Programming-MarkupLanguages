/*
 ============================================================================
 Name        : CaesarCipherBreaker.c
 Author      : Mert PEHLİVANCIK
 Version     : 1.0
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */
#include <stdio.h>
#include <stdlib.h>

void bubbleSort(int arr[][2], int n)
{
   int i, j;
   int temp=0;
   int tempN=0;
   for (i = 0; i < n-1; i++)
       for (j = 0; j < n-i-1; j++){
           if (arr[j][1] > arr[j+1][1]){
               temp = arr[j][1];
               tempN = arr[j][0];
               arr[j][1] = arr[j+1][1];
               arr[j][0] = arr[j+1][0];
               arr[j+1][1] = temp;
               arr[j+1][0] = tempN;
           }
       }
}
int main(void) {
    //Declarations
	int i=0;
	int j=0;
	double totalFreq=0.0;
	int asciiAlphabet[26][2]={{97,0},{98,0},{99,0},{100,0},{101,0},{102,0},{103,0},{104,0},{105,0},{106,0},{107,0},{108,0},{109,0},{110,0},{111,0},{112,0},{113,0},{114,0},{115,0},{116,0},{117,0},{118,0},{119,0},{120,0},{121,0},{122,0}};
	int calculatedgivingFrequency[26];
	int givingFrequency[26]={113,106,120,112,107,119,118,98,103,121,102,109,100,104,108,105,99,117,114,115,111,97,110,116,101,32};
	//#Declarations
	//Initializations
	for(i=0;i<26;i++){
		calculatedgivingFrequency[i]=0;
	        }
	//#Initializations
	FILE *in = fopen("Write Path of Encrypted Text of Path", "r");
	 char c;
	    while ((c = fgetc(in)) != EOF){
	        for(i=0;i<26;i++){
	        	if(c==asciiAlphabet[i][0]){
	        		asciiAlphabet[i][1]=asciiAlphabet[i][1]+1;
	        		calculatedgivingFrequency[i]=calculatedgivingFrequency[i]+1;
	        	}
	        }
	    }
	    bubbleSort(asciiAlphabet,26);
	    fclose(in);
	    FILE *inN = fopen("Write Path of Encrypted Text of Path", "r");
	    FILE *f = fopen("Write Path of Decrypted Text of Path", "w+");
	          char d;
	          	    while ((d = fgetc(inN)) != EOF){
	          	        for(i=0;i<26;i++){
	          	        	if(d==asciiAlphabet[i][0]){
	          	        		fprintf(f, "%c", givingFrequency[i]);
	          	        	}
	          	        }
	          	    }
	     fclose(f);
	     fclose(in);
	return EXIT_SUCCESS;
}
