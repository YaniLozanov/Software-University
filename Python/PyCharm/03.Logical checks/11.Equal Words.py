# Problem:
# Write a program that introduces two words and checks whether they are the same.
# Do not make a difference between headwords and small words. Show "yes" or "no".

first_Word = input().lower()
second_Word = input().lower()

if first_Word == second_Word:
    print("yes")

else:
    print("no")

