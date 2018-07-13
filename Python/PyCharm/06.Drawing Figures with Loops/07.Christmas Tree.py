# Problem
# Write a program that enters a number n (1 ≤ n ≤ 100) and prints a Christmas tree size n.


n = int(input())

spaces = " "



for i in range(0, n + 1):

    spaces = n - i
    print(" " * spaces + "*" * i + " | " + "*" * i + " " * spaces)
