/*
 ============================================================================
 Name        : StreamCryptology.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include <sodium.h>
#include <assert.h>
#define	MESSAGE_PART1	(const	unsigned	char	*)	"Mert Pehlivancik"
#define	MESSAGE_PART1_LEN				25
#define	CIPHERTEXT_PART1_LEN	MESSAGE_PART1_LEN	+	crypto_secretstream_xchacha20poly1305_ABYTES
#define	MESSAGE_PART2	(const	unsigned	char	*)	"split	into"
#define	MESSAGE_PART2_LEN				10
#define	CIPHERTEXT_PART2_LEN	MESSAGE_PART2_LEN	+	crypto_secretstream_xchacha20poly1305_ABYTES
#define	MESSAGE_PART3	(const	unsigned	char	*)	"three	messages"
#define	MESSAGE_PART3_LEN				14
#define	CIPHERTEXT_PART3_LEN	MESSAGE_PART3_LEN	+	crypto_secretstream_xchacha20poly1305_ABYTES

int main(void) {

	crypto_secretstream_xchacha20poly1305_state state;
	unsigned char key[crypto_secretstream_xchacha20poly1305_KEYBYTES];
	unsigned char header[crypto_secretstream_xchacha20poly1305_HEADERBYTES];
	unsigned char c1[CIPHERTEXT_PART1_LEN], c2[CIPHERTEXT_PART2_LEN],
			c3[CIPHERTEXT_PART3_LEN];
	/*	Shared	secret	key	required	to	encrypt/decrypt	the	stream	*/
	crypto_secretstream_xchacha20poly1305_keygen(key);
	/*	Set	up	a	new	stream:	initialize	the	state	and	create	the	header	*/
	crypto_secretstream_xchacha20poly1305_init_push(&state, header, key);
	/*	Now,	encrypt	the	first	chunk.	`c1`	will	contain	an	encrypted,
	 *	authenticated	representation	of	`MESSAGE_PART1`.	*/
	crypto_secretstream_xchacha20poly1305_push(&state, c1, NULL, MESSAGE_PART1,
	MESSAGE_PART1_LEN, NULL, 0, 0);
	/*	Encrypt	the	second	chunk.	`c2`	will	contain	an	encrypted,	authenticated
	 *	representation	of	`MESSAGE_PART2`.	*/
	crypto_secretstream_xchacha20poly1305_push(&state, c2, NULL, MESSAGE_PART2,
	MESSAGE_PART2_LEN, NULL, 0, 0);
	/*	Encrypt	the	last	chunk,	and	store	the	ciphertext	into	`c3`.
	 *	Note	the	`TAG_FINAL`	tag	to	indicate	that	this	is	the	final	chunk.	*/
	crypto_secretstream_xchacha20poly1305_push(&state, c3, NULL, MESSAGE_PART3,
	MESSAGE_PART3_LEN, NULL, 0,
	crypto_secretstream_xchacha20poly1305_TAG_FINAL);

	unsigned char tag;
	unsigned char m1[MESSAGE_PART1_LEN], m2[MESSAGE_PART2_LEN],
			m3[MESSAGE_PART3_LEN];
	/*	Decrypt	the	stream:	initializes	the	state,	using	the	key	and	a	header	*/
	if (crypto_secretstream_xchacha20poly1305_init_pull(&state, header, key)
			!= 0) {
		/*	Invalid	header,	no	need	to	go	any	further	*/
	}
	/*	Decrypt	the	first	chunk.	A	real	application	would	probably	use
	 *	a	loop,	that	reads	data	from	the	network	or	from	disk,	and	exits	after
	 *	an	error,	or	after	the	last	chunk	(with	a	`TAG_FINAL`	tag)	has	been
	 *	decrypted.	*/
	if (crypto_secretstream_xchacha20poly1305_pull(&state, m1, NULL, &tag, c1,
	CIPHERTEXT_PART1_LEN, NULL, 0) != 0) {
		/*	Invalid/incomplete/corrupted	ciphertext	-	abort	*/
	}
	for(int i=0;i<CIPHERTEXT_PART1_LEN;i++){
				printf("%c ",m1[i]);
			}
	assert(tag == 0); /*	The	tag	is	the	one	we	attached	to	this	chunk:	0	*/
	/*	Decrypt	the	second	chunk,	store	the	result	into	`m2`	*/
	if (crypto_secretstream_xchacha20poly1305_pull(&state, m2, NULL, &tag, c2,
	CIPHERTEXT_PART2_LEN, NULL, 0) != 0) {
		/*	Invalid/incomplete/corrupted	ciphertext	-	abort	*/
	}
	assert(tag == 0); /*	Not	the	end	of	the	stream	yet	*/
	/*	Decrypt	the	last	chunk,	store	the	result	into	`m3`	*/
	if (crypto_secretstream_xchacha20poly1305_pull(&state, m3, NULL, &tag, c3,
	CIPHERTEXT_PART3_LEN, NULL, 0) != 0) {
		/*	Invalid/incomplete/corrupted	ciphertext	-	abort	*/
	}
	/*	The	tag	indicates	that	this	is	the	final	chunk,	no	need	to	read	and	decrypt	more	*/
	assert(tag == crypto_secretstream_xchacha20poly1305_TAG_FINAL);

	return 0;
}
