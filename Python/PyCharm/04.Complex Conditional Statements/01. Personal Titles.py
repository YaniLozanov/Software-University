# Problem:
# The first task of this topic is to write a console program that introduces age (decimal number) and
# gender ("m" or "f") and prints an address from among the following:
# -> "Mr." - male (gender "m") aged 16 or over
# -> "Master" - boy (sex "m") under 16 years of age
# -> "Ms." - woman (gender "f") aged 16 or over
# -> "Miss" - girl (gender "f") under 16 years of age


age = float(input())
sex = input()

if sex == "m":
    if age >= 16:
        print("Mr.")
    else:
        print("Master")

else:
    if age >= 16:
        print("Ms.")
    else:
        print("Miss")





