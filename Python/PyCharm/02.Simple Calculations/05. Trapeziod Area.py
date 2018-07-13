# Write a program that reads from the console three real numbers b1, b2 and h and calculates the trapeze face with bases b1 and b2 and height h.
# The trapezoidal face formula is (b1 + b2) * h / 2.

b1 =  float(input())
b2 = float(input())
h = float(input())

area = ((b1 + b2) * h) / 2

print(area)
