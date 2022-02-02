from cs50 import get_int

points = get_int("How many points you lost? ")

if points < 2:
    print("you lost fewer points than me")
elif points > 2:
    print(" you lost more points than me ")
else:
    print("you lost the same number of points than me")

