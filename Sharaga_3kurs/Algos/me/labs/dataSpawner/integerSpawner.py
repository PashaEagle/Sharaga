            ### INTEGER SPAWNER ###
import random

print("\n\t!!!***Welcome to data spawner v -0.1***!!!\n");

try:
    ls = []
    amt = int(input("What amount of elements: "));
    ans = input("Do you want to randomly generate numbers ? (yes/no) .. ");

    if ans.lower() == "yes":
        min = int(input("To finish enter limits..\nMinimum = "))
        max = int(input("Maximum = "))
        random.seed()
        for i in range(amt):
            ls.append(random.randint(min, max))

    else:
        print("Ok, now set numbers..")
        for i in range(amt):
            ls.append(int(input(str(i) + " --> ")))

    fileName = str(input("Enter name of the file to finish.. "))
    myfile = open("../dataSets/" + str(fileName) + ".txt", "w")
    for i in ls:
        myfile.write(str(i) + "\n")

    myfile.close()
    print("File created. Job done. Now exiting.. See ya. ")
except:
    print("Whoooooops.. I think error occured, please restart")
