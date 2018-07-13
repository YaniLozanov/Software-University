# Problem:
# Write a program that enters an integer n (1 ≤ n ≤ 12) and calculates and prints n! = 1 * 2 * ... * n (n factorial).

n = int(input())

result = 1

for i in range(1, n + 1):

    result *= i


print(result)
