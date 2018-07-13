# Problem:
# In one cinema hall, the chairs are arranged in rectangular shape in r row and c columns.
#  There are three types of projections with Tickets at different rates:

# -> Premiere - Premiere, at a price of 12.00 BGN.
# -> Normal - standard screening, at a price of 7.50 leva.

# -> Discount - screening for children, students and students at a reduced price of 5.00 BGN.
# Write a program that introduces a screen type, number of rows, and number of columns in the room
# numbers) and calculates total ticket revenue in a full room.
#  Print the result in a format such as the examples below, with 2 decimal places.

projections_Type = input()
row = int(input())
cow = int(input())

tickets_Price = 0
total_Price = 0

if projections_Type == "Premiere":
    tickets_Price = 12


elif projections_Type == "Normal":
    tickets_Price = 7.5


elif projections_Type == "Discount":
    tickets_Price = 5

total_Price = tickets_Price * (row * cow)

print("{0:.2f} leva".format(total_Price))
