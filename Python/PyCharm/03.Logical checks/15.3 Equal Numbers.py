# Problem:
# Enter 3 numbers and print whether they are the same (yes / no)

first_num = int(input())
second_num = int(input())
third_num = int(input())

sum = first_num + second_num + third_num

if sum / 3 == first_num:
    print("yes")

else:
    print("no")
