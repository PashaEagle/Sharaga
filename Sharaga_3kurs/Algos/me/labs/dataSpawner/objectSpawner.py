            ### DATA SPAWNER ###
import random
from enum import Enum

###########################################

class Data:
    name = "not set"
    subject = "not set"
    mark = -1

d_Names = ("Petya", "Pasha", "Vasya", "Dima", "Egor", "Taras", "Nazar", "Anya", "Dasha", "Nastya", "Katya")
d_Subjects = ("English", "Math", "Programming", "Computer Science", "Physics", "Italian", "Probability Theory", "Literature")

###########################################


print("\n\t!!!***Welcome to obj spawner v -0.1***!!!\n");

#try:
ls = []
amt = int(input("What amount of objects: "));
ans = input("You want to spawn " + str(amt) + " objects. \n"
                    "Every objects by my task has 3 fields: Name, Subject and Mark.\n"
                        "Do you want to randomly generate objects with all of fields ? (yes/no).. ")

if ans.lower() == "yes":
    random.seed()
    for i in range(amt):
        x = Data()
        x.name = d_Names[random.randint(0, len(d_Names) - 1)]
        x.subject = d_Subjects[random.randint(0, len(d_Subjects) - 1)]
        x.mark = random.randint(2, 5)
        ls.append(x)

else:
    for i in range(amt):
        x = Data()
        x.name = input("\nEnter name of " + str(i) + " student.. ")
        x.subject = input("Enter subject of " + str(i) + " student.. ")
        x.mark = input("Enter mark of " + str(i) + " student.. ")
        ls.append(x)
    print("Data successfully generated")

print(ls[17].name)
print(ls[17].subject)
print(ls[17].mark)

fileName = str(input("Enter name of the file to finish.. "))
myfile = open("../dataSets/" + str(fileName) + ".txt", "w")
myfile.write(str(amt) + "\n")
for count in ls:
    myfile.write(count.name + " | " + count.subject + " | " + str(count.mark) + "\n")

myfile.close()
print("File created. Job done. Now exiting.. See ya. ")
#except:
    #print("Whoooooops.. I think error occured, please restart")
