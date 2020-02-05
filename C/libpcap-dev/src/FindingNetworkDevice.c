/*
 ============================================================================
 Name        : libpcap-dev.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdlib.h>
#include <stdio.h>                           /*PCAP_ERRBUF_SIZE pcap kütüphanesinde 256 olarak tanımlanmıştır*/
#include <pcap.h>                            /*device = pcap_lookupdev(error_buffer); --> burada call by referance yapılmıştır */
#include <arpa/inet.h>                       /*pcap_lookupdev --> Network device'ı bulan fonksiyondur */
#include <string.h>

//int main(void) {
//	char *device; /* Name of device (e.g. eth0, wlan0) */
//	   char error_buffer[PCAP_ERRBUF_SIZE]; /* Size defined in pcap.h */
//
//	    /* Find a device */
//	    device = pcap_lookupdev(error_buffer);
//	    if (device == NULL) {
//	        printf("Error finding device: %s\n", error_buffer);
//	        return 1;
//	    }
//
//	    printf("Network device found: %s\n", device);
//	return 0;
//}
