# Problem:
# Write a program that reads a number of integer numbers entered by the user and sums them.

num_of_loops = int(input())

sum = 0;

for i in range(1, num_of_loops + 1):
    num = int(input())

    sum += num

print(sum)
