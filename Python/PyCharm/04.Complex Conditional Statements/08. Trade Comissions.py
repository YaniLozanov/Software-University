# Problem:
# The company gives the following commissions to its merchants according to the town in which the sales volume works:
#
# City     0 ≤ s ≤ 500    500 < s ≤ 1,000     1,000 < s ≤ 10,000     s > 10 000
# Sofia       5%                7%                    8%              12%
# Varna       4.5%              7.5%                  10%             13%
# Plovdiv     5.5%              8%                    12%             14.5%

# Write a console program that reads a city name and sales volume (decimal number) and calculates and
# returns the amount of merchant commission according to the above table.
# Score to be rounded by 2 digits after the decimal point.
# In the case of an invalid city or sales volume (negative number) prints "error".


city = input()
sales = float(input())

commission = 0
commission_Percent = 0

if city == "Sofia":
    if 0 <= sales <= 500:
        commission_Percent = 0.05

    elif 500 <= sales <= 1000:
        commission_Percent = 0.07

    elif 1000 <= sales <= 10000:
        commission_Percent =  0.08

    elif sales > 10000:
        commission_Percent = 0.12

elif city == "Varna":
    if 0 <= sales <= 500:
        commission_Percent = 0.045

    elif 500 <= sales <= 1000:
        commission_Percent = 0.075

    elif 1000 <= sales <= 10000:
        commission_Percent =  0.10

    elif sales > 10000:
        commission_Percent = 0.13

    else:
        print("error")

elif city == "Plovdiv":
    if 0 <= sales <= 500:
        commission_Percent = 0.055

    elif 500 <= sales <= 1000:
        commission_Percent = 0.08

    elif 1000 <= sales <= 10000:
        commission_Percent =  0.12

    elif sales > 10000:
        commission_Percent = 0.145

    else:
        print("error")
else:
    print("error")

commission = sales * commission_Percent

print(float("{0:.2f}".format(commission)))
