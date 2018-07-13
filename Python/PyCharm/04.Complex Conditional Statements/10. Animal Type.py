# Problem:
# Write a program that prints the animal's class according to its user name:
# -> dog  -> mammal
# -> crocodile, tortoise, snake -> reptiles
# -> others -> unknown


animal = input()

if animal == "dog":
    print("mammal")

elif animal == "crocodile" or animal == "snake" or animal == "tortoise":
      print("reptile")

else:
    print("unknown")
