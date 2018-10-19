class Data:
    name = "unknown"
    subject = "unknown"
    mark = -1


ls = []

fileName = input("Enter name of file to set data values.. ")
myfile = open("../dataSets/" + str(fileName) + ".txt", "r")
amt = int(myfile.readline())

for i in range(amt):
    temp = Data()
    fields = (myfile.readline()).split(" | ")
    #print(fields[0] + ", " + fields[1])
    temp.name = fields[0] + " " * (17 - len(fields[0]))
    temp.subject = fields[1]
    temp.mark = int(fields[2])
    ls.append(temp)

myfile.close()

def showList(ls):
    for i in range(len(ls)):
        print("(" + str(i + 1) + ") \t" + str(ls[i].mark) + "\t" + ls[i].name + "\t" + ls[i].subject)
    return