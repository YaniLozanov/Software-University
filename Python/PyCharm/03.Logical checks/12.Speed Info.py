# Problem:
# Write a program that introduces a speed (decimal number) and prints speed information.
# At speeds of up to 10 (inclusive), print "slow". At speeds over 10 and up to 50, print "average".
# At speeds over 50 and up to 150, print "fast". At speed above 150 and up to 1000, print "ultra fast".
# At higher speed, print "extremely fast".

speed = float(input())

if speed <= 10:
    print("slow")

elif speed > 10 and speed <= 50:
    print("average")

elif speed > 50 and speed <= 150:
    print("fast")

elif speed > 150 and speed <= 1000:
    print("ultra fast")

else:
    print("extremely fast")


