# Problem:
# Write a program that introduces an integer n (3 ≤ n ≤ 100) and print sunglasses of size 5 * n x n.

n = int(input())

asterisk = "*"
slash = "/"
spaces = " "

asterisk = 2 * n
spaces = n

print("*" * asterisk + " " * spaces + "*" * asterisk)

for i in range(1, (n - 2) + 1):

    if n % 2 == 0:
        if i == n / 2 - 1:

            slash = 2 * n - 2
            print("*" + "/" * slash + "*" + "|" * n + "*" + "/" * slash + "*")

        else:
            spaces = 2 *n - 2
            print("*" + "/" * spaces + "*" + " " * n + "*" + "/" * spaces + "*")


    else:
        if i == n // 2:

            slash = 2 * n - 2
            print("*" + "/" * slash + "*" + "|" * n + "*" + "/" * slash + "*")

        else:
            spaces = 2 *n - 2
            print("*" + "/" * spaces + "*" + " " * n + "*" + "/" * spaces + "*")









asterisk = 2 * n
spaces = n

print("*" * asterisk + " " * spaces + "*" * asterisk)
