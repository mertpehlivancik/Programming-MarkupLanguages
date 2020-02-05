#include <stdio.h>
#include <unistd.h>
#include <sys/socket.h>
#include <bluetooth/bluetooth.h>
#include <bluetooth/rfcomm.h>
#include <sodium.h>

#define	MESSAGE_PART1	(const	unsigned	char	*)	"mert"
#define	MESSAGE_PART1_LEN				25
#define	CIPHERTEXT_PART1_LEN	MESSAGE_PART1_LEN	+	crypto_secretstream_xchacha20poly1305_ABYTES

int main(int argc, char **argv) {
	struct sockaddr_rc addr = { 0 };
	int s, status;
	char dest[18] = "DC:85:DE:3F:C6:1B";

	// allocate a socket
	s = socket(AF_BLUETOOTH, SOCK_STREAM, BTPROTO_RFCOMM);

	// set the connection parameters (who to connect to)
	addr.rc_family = AF_BLUETOOTH;
	addr.rc_channel = (uint8_t) 1;
	str2ba(dest, &addr.rc_bdaddr);

	// connect to server
	status = connect(s, (struct sockaddr *) &addr, sizeof(addr));
//	unsigned char k[crypto_secretstream_xchacha20poly1305_KEYBYTES];
//	crypto_secretstream_xchacha20poly1305_keygen(k);
//	for (int i = 0; i < strlen(k); i++) {
//		printf("%c ", k[i]);
//	}
	crypto_secretstream_xchacha20poly1305_state state;
	unsigned char key[4] = "1234";
	crypto_secretstream_xchacha20poly1305_keygen(key);
	unsigned char header[crypto_secretstream_xchacha20poly1305_HEADERBYTES];
	unsigned char c1[CIPHERTEXT_PART1_LEN];
	crypto_secretstream_xchacha20poly1305_init_push(&state, header, key);
	crypto_secretstream_xchacha20poly1305_push(&state, c1, NULL, MESSAGE_PART1,
		MESSAGE_PART1_LEN, NULL, 0, 0);
	// send a message
	if (status == 0) {
		status = write(s, c1, CIPHERTEXT_PART1_LEN);
	}
	for (int i = 0; i < CIPHERTEXT_PART1_LEN; i++) {
		printf("%c", c1[i]);
	}
	if (status < 0)
		perror("uh oh");

	close(s);

	return 0;
}
