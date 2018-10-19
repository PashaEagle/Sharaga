from precompile import *

print("*************** BUBBLE++ SORT *****************\n\n")

left = 0
right = len(ls) - 1

while left <= right:
    for i in range(left, right, +1):
        if ls[i].mark < ls[i + 1].mark:
            ls[i], ls[i + 1] = ls[i + 1], ls[i]
    right -= 1

    for i in range(right, left, -1):
        if ls[i - 1].mark < ls[i].mark:
            ls[i], ls[i - 1] = ls[i - 1], ls[i]
    left += 1

showList(ls)