# Problem:
# Write a program that reads the numbers submitted by the user and checks the sum of the even positions is equal to the sum of the odd numbers.
# In the case of equality, the "Yes" + amount is printed; otherwise you can print the "No" + difference. The difference is calculated in absolute terms value.

import  math

num_of_loops = int(input())

odd_sum = 0
even_sum = 0
difference = 0

for i in range(1,num_of_loops + 1):

    num = int(input())

    if i % 2 != 0:
        odd_sum += num

    else:
        even_sum += num

difference = math.fabs(odd_sum - even_sum)

if difference == 0:
    print(f"Yes, sum = {odd_sum}")

else:
    print(f"No, diff = {difference}")
