# Problem:
# Write a program that introduces a product name and checks whether it is a fruit or a vegetable.

# -> Fruit are: banana, apple, kiwi, cherry, lemon and grapes
# -> Vegetables  are: tomato, cucumber, pepper and carrot
# ->  All others are unknown ;

# Display "fruit", "vegetable" or "unknown" according to the introduced product.


product = input()


if product == "banana":
    print("fruit")

elif product == "apple":
    print("fruit")

elif product == "kiwi":
    print("fruit")

elif product == "cherry":
    print("fruit")

elif product == "lemon":
    print("fruit")

elif product == "grapes":
    print("fruit")

elif product == "tomato":
    print("vegetable")

elif product == "cucumber":
    print("vegetable")

elif product == "pepper":
    print("vegetable")

elif product == "carrot":
    print("vegetable")

else:
    print("unknown")


