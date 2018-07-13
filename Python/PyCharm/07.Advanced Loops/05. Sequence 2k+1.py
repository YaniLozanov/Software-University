# Problem:
# Write a program that enters a number n and prints all numbers ≤ n of the row: 1, 3, 7, 15, 31, ....
# Each subsequent number is calculated as the previous number * 2 + 1.

n = int(input())

result = 1

while result <= n:

    print(result)
    result = result * 2 + 1



