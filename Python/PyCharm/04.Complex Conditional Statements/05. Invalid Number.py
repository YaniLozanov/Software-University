# Problem:
# A given number is valid if it is in the range [100 ... 200] or is 0.
# Write a program that enters a whole number and print "invalid" if the entered number is not valid



num = float(input())

if num == 0 or (num >= 100 and num <= 200):
    print()
    
else:
    print("invalid")
