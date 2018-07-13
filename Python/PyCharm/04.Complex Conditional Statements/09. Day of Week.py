# Problem:
# Print the name of the day of the week by day of the day from [1 ... 7] or
# print an "Error" for an invalid number.


num = float(input())

if num == 1:
    print("Monday")

elif num == 2:
    print("Tuesday")

elif num == 3:
    print("Wednesday")

elif num == 4:
    print("Thursday")

elif num == 5:
    print("Friday")

elif num == 6:
    print("Saturday")

elif num == 7:
    print("Sunday")

else:
    print("error")
