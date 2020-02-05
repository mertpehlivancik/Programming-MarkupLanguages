/*
 ============================================================================
 Name        : bolme.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>

int main(void) {
	int bolunen = 17;
	int temp = 0;
	temp = bolunen;
	int bolen = 2;
	int bolum = 0;
	int kalan = 0;
	while(temp > bolen){
		temp = temp - bolen;
		bolum = bolum +1;
	}
	kalan = temp;
	printf("Bolunen = %d\n",bolunen);
	printf("Bolen = %d\n",bolen);
	printf("Bolum = %d\n",bolum);
	printf("Kalan = %d\n",kalan);
	return EXIT_SUCCESS;
}
