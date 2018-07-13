# Problem:
# Write a program that reads a text (string) entered by the user and calculates and prints the amount of the values ​​of the uppercase letters in the table below:
# letter:  a   e   i   o   u
# value:   1   2   3   4   5


text = input()

sum = 0

for i in range(0, len(text)):

    if text[i] == 'a':
        sum += 1

    elif text[i] == 'e':
        sum += 2


    elif text[i] == 'i':
        sum += 3

    elif text[i] == 'o':
        sum += 4

    elif text[i] == 'u':
        sum += 5

print(sum)
