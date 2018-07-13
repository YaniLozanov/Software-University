# Problem:
# The fruit shop during the working days works at the following prices:

# fruit:  banana  apple   orange  grapefruit  kiwi   pineapple   grapes
# price:  2.50    1.20    0.85      1.45      2.70     5.50       3.85

# Saturday and Sunday the shop runs at higher prices:

# fruit   banana  apple   orange  grapefruit  kiwi   pineapple   grapes
# price   2.70    1.25    0.90       1.60     3.00     5.60       4.20


# Write a program that reads from the fruit console (banana / apple / orange / grapefruit / kiwi / pineapple /
# grapes), day of the week (Monday / Tuesday / Wednesday / Wednesday / Friday / Saturday / Sunday) and quantity
# (decimal number) and calculate the price according to the prices in the tables above.
#  Print the result rounded by 2 digits after the decimal point. Invalid day of the week or invalid fruit name to print "error".

fruit = input()
day = input()
quantity = float(input())

price = 0

valid_Day = day == "Monday" or day == "Tuesday" or\
            day == "Wednesday" or day == "Thursday" or\
            day == "Friday"


if day == "Saturday" or day == "Sunday":
        if fruit == "banana":
            price = quantity * 2.70
            print(price)

        elif fruit == "apple":
            price = quantity * 1.25
            print(price)

        elif fruit == "orange":
            price = quantity * 0.90
            print(price)

        elif fruit == "grapefruit":
            price = quantity * 1.60
            print(price)

        elif fruit == "kiwi":
            price = quantity * 3.00
            print(price)

        elif fruit == "pineapple":
            price = quantity * 5.60
            print(price)

        elif fruit == "grapes":
            price = quantity * 4.20
            print(price)
            
        else:
            print("error")

elif valid_Day:
    if fruit == "banana":
            price = quantity * 2.50
            print(price)

    elif fruit == "apple":
            price = quantity * 1.20
            print(price)

    elif fruit == "orange":
            price = quantity * 0.85
            print(price)

    elif fruit == "grapefruit":
            price = quantity * 1.45
            print(price)

    elif fruit == "kiwi":
            price = quantity * 2.70
            print(price)

    elif fruit == "pineapple":
            price = quantity * 5.50
            print(price)

    elif fruit == "grapes":
            price = quantity * 3.85
            print(price)

    else:
        print("error")

else:
    print("error")
