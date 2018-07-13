# Problem:
# Write a program that reads from the console side and triangle height and calculates its face.
# Use the face to triangle formula: area = a * h / 2.
# Round the result to 2 decimal places using float ("{0: .2f}".


side = float(input())
height = float(input())

area = (side * height) / 2

print("Triangle area = ",float("{0:.2f}".format(area)))
