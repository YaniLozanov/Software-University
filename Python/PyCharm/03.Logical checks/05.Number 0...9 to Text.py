# Problem:
# Write a program that enters an integer in the range [0 ... 10] and writes it in English language.
# If the number is out of range, it says "number too big"

num = int(input())

if num == 0:
    print("zero")

elif num == 1:
    print("one")

elif num == 2:
    print("two")

elif num == 3:
    print("three")

elif num == 4:
    print("four")

elif num == 5:
    print("five")

elif num == 6:
    print("six")

elif num == 7:
    print("seven")

elif num == 8:
    print("eight")

elif num == 9:
    print("nine")

else:
    print("number too big")
