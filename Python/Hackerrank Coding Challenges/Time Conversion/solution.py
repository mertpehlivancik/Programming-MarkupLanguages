#!/bin/python3

import os
import sys

#
# Complete the timeConversion function below.
#
def timeConversion(s):
    a = s[0] + s[1]
    a = int(a)
    if s[8:10] == "AM":
        if a == 12:
            a = a - a
            a = str(a)
            a = a + "0"
            s = a + s[2:8]
        else:
            s = s[0:8]
    elif s[8:10] == "PM":
        if a == 12:
            s = s[0:8]
        else:
            a = a + 12
            a = str(a)
            s = a + s[2:8]
    return s     

if __name__ == '__main__':
    f = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = timeConversion(s)

    f.write(result + '\n')

    f.close()
