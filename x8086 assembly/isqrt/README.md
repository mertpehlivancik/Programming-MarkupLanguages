
In number theory, the integer square root(isqrt) of a positive integer n is the positive integer m which is greatest integer less than or equal to the square root of n.
√
isqrt(n) = √n
For example, isqrt(27) = 5 because 5 · 5 = 25 ≤ 27 and 6 · 6 = 36 > 27. An the algorithm is,

x = 2 ^(log 2 n )/2

y = (x + n/x)/2

while(y < x){

x = y

y = b(x + n/x)/2

}

return x

Your task is to write a Microsoft Assembly code to calculate square root of an integer with the help of the simple algorithm above. The program will also be able to use I/O ports of EMU8086. It means that the code will take the input from the input port, calculate the function and write the result to the output port. Please write a generic algorithm not working only for a special integer.
