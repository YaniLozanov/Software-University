# Problem:
# Write down a program to convert US Dollars (USD) into Bulgarian Leva (BGN).
# Round the score to 2 digits after the decimal point.
# Use a fixed exchange rate between USD and BGN: 1 USD = 1.79549 BGN.

dollars = float(input())

leva = dollars * 1.79549

print(float("{0:.2f}".format(leva)),"BGN")
