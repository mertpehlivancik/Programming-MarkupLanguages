if __name__ == '__main__':
    x = int(input())
    y = int(input())
    z = int(input())
    n = int(input())
#Solving
arr = [[X, Y, Z] for X in range(x+1) for Y in range(y+1) for Z in range(z+1) if sum([X,Y,Z]) != n]
#Output
print(arr)
