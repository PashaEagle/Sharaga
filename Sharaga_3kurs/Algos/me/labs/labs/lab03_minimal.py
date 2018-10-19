from precompile import *

print("*************** SELECTION SORT *****************\n\n")

n = len(ls)
i = 0

while i < n:
    smallest = i
    j = i + 1

    while j < n:
        if ls[j].mark > ls[smallest].mark:
            smallest = j
        j+=1

    ls[i], ls[smallest] = ls[smallest], ls[i]

    i+=1

showList(ls)