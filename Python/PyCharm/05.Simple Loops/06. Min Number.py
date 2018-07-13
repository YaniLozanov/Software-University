# Problem:
# Write a program that reads n number of integers (n > 0) entered by the user,
# few of them. First, the number of ns is entered, and then the n numbers themselves, one per line.

num_of_loops = int(input())

min_num = 9223372036854775807
new_num  = 0

for i in range(1, num_of_loops + 1):
    new_num = int(input())

    if new_num < min_num:
        min_num = new_num

print(min_num)
