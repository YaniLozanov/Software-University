# Problem:
# Write a program that checks whether the point {x, y} is located in a rectangle {x1, y1} - {x2, y2}.
# The input data is read from the console and consists of 6 rows: the decimal numbers x1, y1, x2, y2, x and y (taking
# ensure that x1 <x2 and y1 <y2). One point is internal to a rectangle if it is located somewhere in
# its interior or on one of its sides. Print "Inside" or "Outside".


x1 = float(input())
y1 = float(input())

x2 = float(input())
y2 = float(input())

x = float(input())
y = float(input())


if x >= x1 and x <= x2 and y >= y1 and y <= y2:
    print("Inside")

else:
    print("Outside")
