# Problem:
# Write a program that introduces a positive integer n in the range [1 ... 100].
# When entering a number outside the specified range, an error message is printed and the user is prompted to enter a new number.


n = int(input('Еnter a number in the range [1...100]: '))

while 1 > n or n > 100:
    print("Invalid number!")
    n = int(input('Еnter a number in the range [1...100]: '))



print("The number is: "+ str(n))
