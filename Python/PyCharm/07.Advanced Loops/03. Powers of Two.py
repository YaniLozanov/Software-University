# Problem:
# Write a program that reads from the console an integer n and prints the numbers from 1 to 2n.

n = int(input())

for i in range(0, n + 1, 1):

    print(pow(2,i))
