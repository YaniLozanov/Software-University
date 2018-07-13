# Problem:
# Write a program that sets a positive integer n and prints the numbers from n to 1 in reverse order (from the largest to the smallest).


n = int(input())


for i in range(n, 0, -1):
    print(i)
