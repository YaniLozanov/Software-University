# Problem:
# Write a program for converting money from one currency to another.
# The following currencies need to be maintained: BGN, USD, EUR, GBP.
# Use the following fixed exchange rates:

# BGN = 1.79549 USD / 1.95583 EUR / 2.53405 GBP

# The input is a conversion amount + Input Currency + Output Currency.
# The output is one number - the converted amount on the above courses, rounded to 2 digits after the decimal point.

amount = float(input())
first_currency = input()
second_currency = input()

result = 0

if first_currency == "BGN":

    if second_currency == "BGN":
       result = amount * 1

    elif second_currency == "USD":
        result = amount / 1.79549

    elif second_currency == "EUR":
        result = amount / 1.95583

    elif second_currency == "GBP":
        result = amount / 2.53405

elif first_currency == "USD":

    if second_currency == "BGN":
        result = amount * 1.79549

    elif second_currency == "USD":
        result = amount * 1

    elif second_currency == "EUR":
        result = (amount * 1.79549) / 1.95583

    elif second_currency == "GBP":
        result = (amount * 1.79549) / 2.53405

elif first_currency == "EUR":

    if second_currency == "BGN":
        result = amount * 1.95583

    elif second_currency == "USD":
        result = (amount * 1.95583 ) / 1.79549

    elif second_currency == "EUR":
        result = amount * 1

    elif second_currency == "GBP":
        result = (amount * 1.95583 ) / 2.53405


elif first_currency == "GBP":

    if second_currency == "BGN":
        result = amount * 2.53405

    elif second_currency == "USD":
        result = (amount * 2.53405) / 1.79549

    elif second_currency == "EUR":
        result = (amount * 2.53405) / 1.95583

    elif second_currency == "GBP":
        result = amount * 1

print(float("{0:.2f}".format(result)),second_currency)



