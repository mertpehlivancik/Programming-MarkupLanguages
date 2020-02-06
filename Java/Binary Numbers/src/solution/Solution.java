package solution;

import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

	private static final Scanner scanner = new Scanner(System.in);
	static Stack<Integer> myStack = new Stack<Integer>();

	private static int MaximumNumberConsecutive() {
		int counter = 0;
		int Tcounter = 0;
		boolean onoff = true;
		boolean onoff2 = true;
		int value = 0;
		while (myStack.empty() == false) {
			value = myStack.pop();
			if (value == 0 && onoff2 == true) {
				if (onoff == true) {
					onoff = false;
					onoff2 = false;
				} else {
					onoff = true;
					onoff2 = false;
				}
				if (counter != 0 && Tcounter != 0) {
					if (counter > Tcounter) {
						Tcounter = 0;
						onoff = false;
					} else {
						counter = 0;
						onoff = true;
					}
				}
			} else if (value == 1 && onoff == false) {
				Tcounter++;
				onoff2 = true;
			} else if (value == 1 && onoff == true) {
				counter++;
				onoff2 = true;
			}
		}
		if (counter > Tcounter) {
			return counter;
		} else {
			return Tcounter;
		}

	}

	public static void main(String[] args) {
		int n = scanner.nextInt();
		scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

		while (n > 0) {
			int remainder = n % 2;
			n = n / 2;
			myStack.push(new Integer(remainder));
		}
		int Result = 0;
		Result = MaximumNumberConsecutive();
		System.out.print(Result);
		scanner.close();
	}
}
