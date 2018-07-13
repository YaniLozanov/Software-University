# Problem:
# Write a program that introduces two integer positive integers a and b and calculates and prints their largest common divisor (NOD).

a = int(input())
b = int(input())

while b != 0:

    save = a % b
    a = b
    b = save

print(a)
