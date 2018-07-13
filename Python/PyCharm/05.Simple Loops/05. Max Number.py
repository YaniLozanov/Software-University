# Problem:
# Write a program that reads n number of integers (n > 0) entered by the user,
# the greatest among them. First, the number of ns is entered, and then the n numbers themselves, one per line.


num_of_loops = int(input())

new_num = 0
max_num = 9223372036854775807 * (-1)


for i in range(1 , num_of_loops + 1):
    new_num = int(input())

    if  new_num > max_num:
        max_num = new_num


print(max_num)
