package cryptology;


public class Cryptology {
	public static void main(String[] args)
	{
	    final String secretKey = "CDFF59672EB38EEA1C976564213EA2869B510C546FE6C7A111041426FB4D2207";
	     
	    String originalString = "Mert";
	    String encryptedString = AES.encrypt(originalString, secretKey) ;
	    String decryptedString = AES.decrypt(encryptedString, secretKey) ;
	     
	    System.out.println(originalString);
	    System.out.println(encryptedString);
	    System.out.println(decryptedString);
	}
}
