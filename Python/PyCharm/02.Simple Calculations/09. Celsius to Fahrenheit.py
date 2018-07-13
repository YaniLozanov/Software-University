# Problem:
# Write a program that reads degrees on the Celsius scale (° C) and converts them to degrees Fahrenheit (° F).
# Look for an appropriate formula on the Internet to make the calculations.
# Round the score to 2 decimal places.


celsius = float(input())

fahrenheit = celsius * 9/5 + 32

print(float("{0:.2f}".format(fahrenheit)))
