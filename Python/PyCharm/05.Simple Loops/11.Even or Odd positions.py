# Problem:
# Write a program that reads n-number numbers entered by the user and calculates the amount, minimum and
# the maximum of the even and odd numbers (1 count). When there is no minimum / maximum item, print "No".

import  math
num_of_loops = int(input())

odd_sum = 0
odd_min = math.inf
odd_max = math.inf * (-1)

even_sum = 0
even_min = math.inf
even_max = math.inf * (-1)

new_num = 0

for i in range(1, num_of_loops + 1):

    new_num = float(input())

    if i % 2 != 0:
        odd_sum += new_num

        if new_num < odd_min:
            odd_min = new_num

        if new_num > odd_max:
            odd_max = new_num

    else:
        even_sum += new_num

        if new_num < even_min:
            even_min = new_num

        if  new_num > even_max:
            even_max = new_num

if odd_sum == 0:
    print(f"OddSum = 0")

else:
    print(f"OddSum = {odd_sum}")

if odd_min != math.inf:
    print(f"OddMin = {odd_min},")

else:
    print(f"OddMin = No,")


if odd_max != (math.inf * (-1)):
    print(f"OddMax = {odd_max},")

else:
    print("OddMax = No,")


if even_sum == 0:
    print(f"EvenSum = 0,")

else:
    print(f"EvenSum = {even_sum},")

if even_min != math.inf:
    print(f"EvenMin = {even_min},")

else:
    print("EvenMin = No,")



if even_max != (math.inf * (-1)):
    print(f"EvenMax = {even_max}")


else:
    print(f"EvenMax = No")

