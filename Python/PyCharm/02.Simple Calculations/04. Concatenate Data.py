# Write a Python program that reads from the console name, surname, age, and city and prints a message from
# type: "You are (firstName), (lastName), (age) years old person from (town);"


first_name = input()
last_name = input()
age = int(input())
town = input()

print(f"You are {first_name} {last_name}, a {age}-years old person from {town}.")
