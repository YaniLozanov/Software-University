# Problem:
# Three athletes finish for some seconds (between 1 and 50).
# To write a program,which sets the times of the contestants and calculates their cumulative time in the "minutes: seconds" format.
# Take seconds to lead zero (2  "02", 7  "07", 35  "35").

first_Time = int(input())
second_Time = int(input())
third_Time = int(input())


total_Time = first_Time + second_Time + third_Time
minutes = int(total_Time / 60)
seconds = total_Time % 60

if total_Time < 60:
    if total_Time <= 9:
        print(f'0:0{seconds}')
    else:
        print(f'0:{seconds}')

elif total_Time >= 60:
    if seconds <= 9:
        print(f'{minutes}:0{seconds}')
    else:
        print(f'{minutes}:{seconds}')

