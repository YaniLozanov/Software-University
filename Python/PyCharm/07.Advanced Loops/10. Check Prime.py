# Problem:
# Write a program that enters an integer n and checks whether it is a simple number (whether it is divided by itself and per unit).
# Print "Prime" or "Not prime".

import  math


n = int(input())

is_prime = True

if n < 2:
    print('Not Prime')

else:
    end = int(math.sqrt(n))

    for i in range(2, end + 1):

        if n / i == n//i:
          is_prime = False


if is_prime:
    print('Prime')
else:
    print('Not Prime')
