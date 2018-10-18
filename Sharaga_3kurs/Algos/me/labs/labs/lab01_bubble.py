from precompile import *

print("*************** BUBBLE SORT *****************\n\n")

#VARIANT 1
# n = 1
# while n < len(ls):
#     for i in range(len(ls) - n):
#         if ls[i].mark < ls[i + 1].mark:
#             ls[i], ls[i + 1] = ls[i + 1], ls[i]
#     n += 1
#

#VARIANT 2 - sort by 2 name too

n = 1
while n < len(ls):
    for i in range(len(ls) - n):
        if ls[i].mark < ls[i + 1].mark:
            ls[i], ls[i + 1] = ls[i + 1], ls[i]
        else:
            j = i
            while (j < len(ls) and ls[j].mark == ls[j + 1].mark and ls[j].name > ls[j + 1].name):
                ls[j], ls[j + 1] = ls[j + 1], ls[j]
                j += 1

    n += 1



showList(ls)