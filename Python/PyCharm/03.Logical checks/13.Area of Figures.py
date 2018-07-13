# Problem:
# Write a program that introduces the dimensions of a geometric figure and calculates its face.
# The figures are four types: a square, a rectangle, a circle, and a triangle.
# On the first line of the input reads the shape of the figure (square, rectangle, circle or triangle).
# If the figure is a square, the next line reads one number - the length of its country.
# If the figure is a rectangle, the next one two lines read two numbers - the lengths of his sides. If the figure is a circle, the next line reads one number
# - the radius of the circle.
# If the figure is a triangle, the next two lines read two numbers - the length of the
# its side and the length of the height to it. Score to round to 3 digits after the decimal  point.

import math

figure = input()


if figure == "square":
    side = float(input())

    area = side ** 2

    print(format(area,'.3f'))

elif figure == "rectangle":
    side_a = float(input())
    side_b = float(input())

    area = side_a * side_b

    print(format(area,'.3f'))

elif figure == "circle":
     radius = float(input())

     area = radius ** 2 * math.pi

     print(format(area,'.3f'))


elif figure == "triangle":
    side = float(input())
    height = float(input())

    area = (side * height) / 2

    print(format(area,'.3f'))
