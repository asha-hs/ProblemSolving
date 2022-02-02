from cs50 import get_int
def main():
    height = get_height()
    for i in range(height):
        print("#"*3)

def get_height():
    while(True):
        n = get_int("height:")
        if(n>0):
            break
    return n

main()