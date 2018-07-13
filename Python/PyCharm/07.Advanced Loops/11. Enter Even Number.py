# Problem:
# Write a program that introduces an even number.
# If the user has entered the wrong number, a new one must be entered.

n = float(input('Enter even number: '))

while n % 2 != 0:
    print('Invalid number!')
    n = int(input('Enter even number: '))

n = print('Even number entered: ' + str(n))
