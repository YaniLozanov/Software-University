# Problem:
# Write a program that enters an integer and checks if it is below 100, between 100 and 200 or more 200.
# Print relevant messages as in the examples below:

num = int(input())

if num < 100:
    print("Less than 100")

elif num >= 100 and num <= 200:
    print("Between 100 and 200")

elif num > 200:
    print("Greater than 200")
