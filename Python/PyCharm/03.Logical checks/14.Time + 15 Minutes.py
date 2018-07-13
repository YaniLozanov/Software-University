# Problem:
# Write a program that introduces hours and minutes of 24 hours a day and calculates how much time it will take
# after 15 minutes. The result is printed in hh: mm format.
# Hours are always between 0 and 23 minutes are always between 0 and 59.
# Hours are written in one or two digits. Minutes are always written with two digits, with lead zero when needed.

hours = int(input())
minutes = int(input())

minutes += 15

if minutes >= 60:
    minutes %= 60
    hours += 1

    if hours >= 24:
     hours -= 24
     if minutes <= 9:
        print(f'{hours}:0{minutes}')

     else:
        print(f'{hours}:{minutes}')

    else:
        if minutes <= 9:
            print(f'{hours}:0{minutes}')

        else:
          print(f'{hours}:{minutes}')

else:
    print(f'{hours}:{minutes}')


