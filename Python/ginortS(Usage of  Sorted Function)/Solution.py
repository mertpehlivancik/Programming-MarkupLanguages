# Enter your code here. Read input from STDIN. Print output to STDOUT
if __name__ == '__main__':
    order = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1357902468'
    print(*sorted(input(), key=order.index), sep='')