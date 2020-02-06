package solution;

import java.io.*;
import java.util.*;

public class Solution {

	public static void main(String[] args) {
		/*
		 * Enter your code here. Read input from STDIN. Print output to STDOUT. Your
		 * class should be named Solution.
		 */
		Scanner scan = new Scanner(System.in);
		Integer T;
		String myString = null;
		T = scan.nextInt();
		char[] myCharArray = null;
		for (int i = 0; i < T; i++) {
			myString = scan.next();
			myCharArray = myString.toCharArray();
			for (int j = 0; j < myString.length(); j++) {
				if (j % 2 == 0) {
					System.out.print(myCharArray[j]);
				}
			}
			System.out.print(" ");
			for (int k = 0; k < myString.length(); k++) {
				if (k % 2 == 1) {
					System.out.print(myCharArray[k]);
				}
			}
			System.out.println("");
		}
		scan.close();
	}
}
