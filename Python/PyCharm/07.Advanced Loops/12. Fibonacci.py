# Problem:
# Write a program that enters an integer and calculates the Fibonacci nth number.
# The zero figure of Fibonacci is 1, the first one is also 1, and the next is the sum of the previous two.




n = int(input())

a = 1
b = 2

for i in range(1, n):
    new_b = a + b
    a = b
    b = new_b


print(a)
