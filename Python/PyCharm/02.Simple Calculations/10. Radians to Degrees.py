# Problem:
# Write a program that reads an angle in radians (rad) and converts it into degrees (deg).
# Look for an appropriate formula online.
# The number π in Python programs is available through math.pi.
# Round the result to the nearest integer using round ().
import  math

radians = float(input())

degrees = round((radians * 180) / math.pi)

print(degrees)
