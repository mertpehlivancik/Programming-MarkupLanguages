package solution;

import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

	public static void main(String[] args) {
		int i = 4;
		double d = 4.0;
		String s = "HackerRank ";

		Scanner scan = new Scanner(System.in);

		/* Declare second integer, double, and String variables. */
		Integer a;
		Double b;
		String c;
		/* Read and save an integer, double, and String to your variables. */
		// Note: If you have trouble reading the entire String, please go back and
		// review the Tutorial closely.
		a = scan.nextInt();
		b = scan.nextDouble();
		c = scan.nextLine();
		c += scan.nextLine();
		// scan.close();
		/* Print the sum of both integer variables on a new line. */
		i = i + a;
		System.out.print(i);
		System.out.println("");
		/* Print the sum of the double variables on a new line. */
		d = d + b;
		System.out.print(d);
		System.out.println("");
		/*
		 * Concatenate and print the String variables on a new line; the 's' variable
		 * above should be printed first.
		 */
		System.out.println(s + "" + c);

		scan.close();
	}
}
