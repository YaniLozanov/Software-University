# Problem:
# Write a program that introduces a positive integer n and prints a diamond-sized nugget.


n = int(input())

spaces = ' '
asterisk = '*'
for i in range(1, (n * 2) ):

    if i <= n:
        spaces = n - i
        asterisk = i
        print(" " * spaces + "* " * asterisk)

    else:
        spaces = i - n
        asterisk = n * 2 - i
        print(" " * spaces + "* " * asterisk)
