
def RunnerUpScore(myList):
    m = max(myList)
    myList.remove(m)
    while m == max(myList):
        myList.remove(m)
    m = max(myList)
    return m

if __name__ == '__main__':
    n = int(input())
    arr = list(map(int, input().split()))[:n]
    a = RunnerUpScore(arr)
    print(a)
    
   