# Problem:
# Write a program that checks whether the point {x, y} is located on either side of a rectangle {x1, y1} - {x2, y2}.
# The input data is read from the console and consists of 6 rows: the decimal numbers x1, y1, x2, y2, x and y (ensuring that x1 <x2 and y1 <y2).
# Print "Border" (the point lies on one side)or "Inside / Outside" (otherwise).

x1 = float(input())
y1 = float(input())

x2 = float(input())
y2 = float(input())

x = float(input())
y = float(input())

if ((( y == y1 or y == y2)and (x1 <= x and x <= x2))) or ((x == x1 or x == x2)and (y1 <= y and y <= y2)):
    print("Border")

else:
    print("Inside / Outside")

