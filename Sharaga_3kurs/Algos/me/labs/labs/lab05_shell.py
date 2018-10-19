from precompile import *

print("*************** INSERTION++ SORT *****************\n\n")

n = len(ls)
step = int(n / 2)

while step > 0:
    for i in range(n - step):
        j = i
        while j >= 0 and ls[j].mark > ls[j + step].mark:
            ls[j], ls[j + step] = ls[j + step], ls[j]
            j -= 1
    step //= 2

showList(ls)