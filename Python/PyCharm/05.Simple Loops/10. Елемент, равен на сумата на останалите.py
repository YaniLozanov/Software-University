# Problem:
# Write a program that reads n-number integer numbers entered by the user and checks if among
# there is a number that is equal to the sum of all others. If there is such an item, print "Yes ,  Sum =  + its value" otherwise the "No", "Diff =  + the difference between the largest element and the sum of the rest" (in absolute terms).
import  math

num_of_loops = int(input())

sum = 0
max_num = 0
new_num = 0

for i in range(1 , num_of_loops + 1):

    new_num = int(input())

    if new_num > max_num:
        max_num = new_num

    sum += new_num



if sum / 2 == max_num:
    print(f"Yes, Sum = {max_num}")

else:
    print(f"No, diff = {math.fabs((sum - max_num) - max_num)}")





