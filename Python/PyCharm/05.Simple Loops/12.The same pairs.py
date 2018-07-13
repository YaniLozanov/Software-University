# Problem:
# Given are 2 * n-numbered numbers.
# The first and the second form a pair, the third and the fourth also, etc.
#  Each pair has value - the sum of its numbers.
# Write a program that checks if everyone pairs have the same value or print the maximum difference between two consecutive pairs.
# If all pairs have the same value,print: "Yes, value = {Value} + value".
# Otherwise print "No, maxdiff = {Difference} " + maximum difference.
import  math

num_of_loops = int(input())

num_1 = 0
num_2 = 0

first_pair = 0
second_pair = 0

max_num_of_equal_pairs = 0
max_diff = 0
difference = 0


for i in range(1, num_of_loops + 1):

     num_1 = int(input())
     num_2 = int(input())

     if i % 2 != 0:
          first_pair = num_1 + num_2

     else:
          second_pair = num_1 + num_2

     if first_pair == second_pair:
          max_num_of_equal_pairs += 1

     difference = math.fabs(first_pair - second_pair)

     if difference > max_diff and i > 1:
          max_diff = difference



if (max_num_of_equal_pairs + 1) == num_of_loops:
     print(f"Yes, value = {first_pair}")

else:
     print(f"No, maxdiff = {max_diff}")

