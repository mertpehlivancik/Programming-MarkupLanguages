# ABABABA string - ABA substring. We will search ABA in string.
###
# Nonoverlapping situation
# First step
# ABABABA
# ABA , count=1
# ***
# ABABABA
#     ABA , count=2
# Result is 2 for nonoverlapping situation
###
# Overlapping Situation
# ABABABA
# ABA , count=1
# ***
# ABABABA
#   ABA , count=2
# ***
# ABABABA
#     ABA , count=3
# Result is 3 for overlapping situation 
def count_substring(string, sub_string):
    count = start = 0
    while True:
        start = string.find(sub_string, start) + 1
        if start > 0:
            count+=1
        else:
            return count
    
if __name__ == '__main__':
    string = input().strip()
    sub_string = input().strip()
    
    count = count_substring(string, sub_string)
    print(count)