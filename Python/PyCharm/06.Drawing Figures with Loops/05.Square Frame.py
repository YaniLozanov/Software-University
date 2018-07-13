# Problem:
# Write a program that introduces a positive integer n and draws the console square frame with size n * n.


n = int(input())

minuses = n - 2

print("+ " + "- " * minuses + "+")

for i in range(0, n - 2):
    print("| " + "- " * minuses + "|")

print("+ " + "- " * minuses + "+")
