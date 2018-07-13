# Problem:
# The next task is to work with nested if.
# Here is the condition: enterprising Bulgarian opens neighborhood shops in several cities and sells at different prices:

# city ​​/ product coffee water beer sweet peanuts
# Sofia           0.50  0.80 1.20  1.45  1.60
# Plovdiv         0.40  0.70 1.15  1.30  1.50
# Varna           0.45  0.70 1.10  1.35  1.55

# Write a program that reads from the console city (string), product (string) and quantity (decimal number), and
# calculates and prints how much the corresponding quantity of the selected product costs in that city.
# The answer to be accurate to the second character.

product = input()
city = input()
quantity = float(input())

price = 0

if city == "Sofia":
    if product == "coffee":
       price = quantity * 0.50

    elif product == "water":
        price = quantity * 0.80

    elif product == "beer":
        price = quantity * 1.20

    elif product == "sweets":
        price = quantity * 1.45

    elif product == "peanuts":
        price = quantity * 1.60

elif city == "Plovdiv":
    if product == "coffee":
       price = quantity * 0.40

    elif product == "water":
        price = quantity * 0.70

    elif product == "beer":
        price = quantity * 1.15

    elif product == "sweets":
        price = quantity * 1.30

    elif product == "peanuts":
        price = quantity * 1.50

elif city == "Varna":
    if product == "coffee":
       price = quantity * 0.45

    elif product == "water":
        price = quantity * 0.70

    elif product == "beer":
        price = quantity * 1.10

    elif product == "sweets":
        price = quantity * 1.35

    elif product == "peanuts":
        price = quantity * 1.55



print(float("{0:.2f}".format(price)))

