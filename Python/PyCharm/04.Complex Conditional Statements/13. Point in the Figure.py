# Problem:
# Figure consists of 6 blocks of size h * h, located as in the figure on the right.
# Lower left corner of the building is in position {0, 0}.
# The upper right corner of the figure is in position {2 * h, 4 * h}.
# In the figure the coordinates are given at h = 2.
# Write a program that enters integer h and coordinates
# a point {x, y} (integers) and prints whether the point is inside
# the inside, outside the figure, or on any of the sides of the border.


h = int(input())
x = int(input())
y = int(input())

left_square = (0 < x <= h) and (0 < y < h)               # Is the point in the left square.
mid = (h < x < 2 * h) and (0 < y < 4 * h)               # Is the point in the middle cow.
right_square = (2 * h <= x < 3 * h) and (0 < y < h)      # Is the point in the right square.


left_squares_borders = (x == 0 and 0 <= y <= h)or\
                       (y == h and 0 <= x <= h)         # Is the point on the left squares border.

down_border = (y == 0 and 0 <= x <= h * 3)

right_squares_borders = (x == h * 3 and 0 <= y <= h)or\
                        (y == h and 2 * h <= x <= 3 * h)  # Is the point on the right squares border.

mid_borders = (x == 2 * h and h <= y <= 4 * h)or\
              (x == h and h <= y <= 4 * h)

top_border = (y == 4 * h and h <= x <= 2 * h)


inside = left_square or mid or right_square
border = left_squares_borders or right_squares_borders or\
         down_border or mid_borders or top_border




if inside:
    print("inside")

elif border:
    print("border")

else:
    print("Outside")

