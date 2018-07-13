# Problem:
# Write a program that introduces a number n (2 ≤ n ≤ 100) and prints a cot with a size n x n.


n = int(input())

asterisk = "*"
minuses = "-"

for i in range(1, n + 1):

    if n % 2 == 0 and i % 2 == 0:
        asterisk = i
        minuses = (n - i ) // 2
        print("-" * minuses + "*" * asterisk + "-" * minuses)

    elif n % 2 != 0 and i % 2 != 0:
        asterisk = i
        minuses = (n - i) // 2
        print("-" * minuses + "*" * asterisk + "-" * minuses)


for i in range(0 , n // 2):
    print("|" + "*" * (n -2) + "|")
