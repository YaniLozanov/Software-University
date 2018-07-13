# Problem:
# Write a program that reads 2 * ns of whole integers filed by the user and checks if
# the sum of the first n numbers (left sum) is equal to the sum of the second n numbers (right amount).
# In case of equality print "Yes" + the sum; otherwise "No" + difference.
# The difference is calculated as a positive number (inabsolute value).
import  math

num_of_loops  = int(input())

first_sum = 0
second_sum = 0

difference = 0

for i in range(1, num_of_loops * 2 + 1):

    number = int(input())

    if i <= num_of_loops:
        first_sum += number

    else:
        second_sum += number


difference = math.fabs(first_sum - second_sum)

if difference == 0:
    print(f"Yes, sum = {first_sum}")

else:
    print(f"No, diff = {difference}")
