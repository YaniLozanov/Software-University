# Problem:
# An integer number is given. Bonus points based on the rules described below are charged.
# Yes a program is written that calculates the bonus points for that number and the total number of points with the bonuses.

# 01.If the number is up to 100 inclusive, the bonus points are 5.
# 02.If the number is greater than 100, the bonus points are 20% of the number.
# 03.If the number is greater than 1000, the bonus points are 10% of the number.
# 04. Additional bonus points (charged separately from the previous ones):
#     o For even number  + 1 p.
#     o For a number that ends at 5  + 2 points.

num = int(input())

bonus = 0
if num <= 100:
    bonus += 5

elif num > 100 and num < 1000:
    bonus += (num * 0.2)

elif num >= 1000:
    bonus += (num * 0.1)

if num % 2 == 0:
    bonus += 1

if num % 10 == 5:
    bonus += 2

print(bonus)
print(bonus + num)
