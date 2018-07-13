# Problem:
# Write a program that reads the console number n and draws a square of n * n asterisks.
# The Difference with the previous task is that there is a space between every two asterisks.

n = int(input())

for i in range(0, n):
    print("* " * n)
