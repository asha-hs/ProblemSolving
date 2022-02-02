from cs50 import get_float

# Assume that the only coins available are quarters (25¢), dimes (10¢), nickels (5¢), and pennies (1¢).
def main():
    input = get_input()
    cents = input*100
    coins = 0
    if cents>0:
        quarters = int(cents/25)
        cents = cents%25
        coins += quarters

        dimes = int(cents/10)
        cents = cents%10
        coins += dimes

        nickels = int(cents/5)
        cents = cents%5
        coins += nickels

        pennies = int(cents/1);
        cents = cents%1;
        coins += pennies
        coins = int(coins)
        print(f"{coins}")

def get_input():
    while(True):
        n = get_float("Money to be returned:")
        if(n>0):
            break
    return n

main()
