from precompile import *

print("*************** INSERTION SORT *****************\n\n")

n = len(ls)

for k in range(1, n):
        i = k - 1
        while (i >= 0) and ls[i+1].mark > ls[i].mark:
            ls[i+1], ls[i] = ls[i], ls[i+1]
            i -= 1

showList(ls)