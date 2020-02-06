

if __name__ == '__main__':
    
    Liste = []
    N = int(input())

    for i in range(0,N):
        tokens = input().split()
        
        if tokens[0] == "insert":
            Liste.insert(int(tokens[1]), int(tokens[2]))
        elif tokens[0] == "print":
            print(Liste)
        elif tokens[0] == "remove":
            Liste.remove(int(tokens[1]))
        elif tokens[0] == "append":
            Liste.append(int(tokens[1]))
        elif tokens[0] == "sort":
            Liste.sort()
        elif tokens[0] == "pop":
            Liste.pop()
        elif tokens[0] == "reverse":
            Liste.reverse()
        