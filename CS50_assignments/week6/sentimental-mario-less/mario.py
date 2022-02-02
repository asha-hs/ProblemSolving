from cs50 import get_int

def main():
    height = get_height()
    for i in range(height):
        print(" "*(height-(i+1)),end="")
        for j in range(i+1):
            print("#", end="")
        print()

def get_height():
     while(True):
        n = get_int("height:")
        if(n>0 and n < 9):
            break
     return n

main()