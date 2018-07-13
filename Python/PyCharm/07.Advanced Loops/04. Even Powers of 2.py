# Problem:
# Write a program that enters n and prints the even degrees at 2 ≤ 2n: 20, 22, 24, 28, ..., 2n.

n = int(input())

for i in range(0, n + 1, 1):

    if i % 2 == 0:
        print(pow(2,i))
