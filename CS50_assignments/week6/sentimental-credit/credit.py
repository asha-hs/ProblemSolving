from cs50 import get_int


def main():
    while True:
        credit_card = get_int("Number..")
        if credit_card >= 0:
            break

    if check_validity(credit_card):
        print_card_brand(credit_card)
    else:
        print("INVALID")


def check_validity(ccn):
    return checksum(ccn)

def checksum(ccn):
    sum = 0

    for i in range(len(str(ccn))):
        if (i % 2 == 0):
            sum += ccn % 10
        else:
            digit = 2 * (ccn % 10)
            sum += digit//10 + digit%10

        ccn //= 10

    return sum % 10 == 0

def print_card_brand(ccn):
    if (ccn >= 34e13 and ccn < 35e13) or (ccn >= 37e13 and ccn < 38e13):
        print("AMEX")
    elif (ccn >= 51e14 and ccn < 56e14):
        print("MASTERCARD")
    elif ((ccn >= 4e12 and ccn < 5e12) or (ccn >= 4e15 and ccn < 5e15)):
        print("VISA")
    else:
        print("INVALID")

main()



