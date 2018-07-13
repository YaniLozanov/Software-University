# Problem:
# Write a program that reads from the console number r and calculates and prints the face and perimeter of a circle /
# circle with radius r.
import math

r = float(input())

area = math.pi * r * r
perimeter = 2 * math.pi * r

print(f"Area = {area}")
print(f"Perimeter = {perimeter}")
