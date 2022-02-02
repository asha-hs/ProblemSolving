from sys import argv

#Ignore last item from the list
for arg in argv[:-1]:
     print(arg)

print()
#Ignore first item from the list
for arg in argv[1:]:
     print(arg)