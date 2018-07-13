# Problem:
# Write a program that enters a password (one line with any text) and
# checks if it is entered matches the phrase "s3cr3t! P @ ssw0rd".
# In case of a collision, bring "Welcome".
# In case of inconsistency "Wrong Password!"

password = input()

if password == "s3cr3t!P@ssw0rd":
    print("Welcome")

else:
    print("Wrong password!")
