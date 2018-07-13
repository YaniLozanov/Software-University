# Problem:
# Vladi is a student, lives in Sofia and walks from time to time to his hometown.
# He is very keen on volleyball but busy during business days and playing volleyball only on weekends and holidays.
# Vladi plays in Sofia every Saturday when he is not at work and does not travel to his hometown, as well as in 2/3 of festive days.
# He travels to his hometown h times in the year where he plays volleyball with his old ones friends on Sunday.
# Vladi is not at work 3/4 of the weekends he's in Sofia.
# Separately, through the leeches years Vladi plays with 15% more volleyball than normal.
#  We assume that the year has exactly 48 weekends,suitable for volleyball.

# How many times , he played during the year

import  math

years_Type = input()
holidays = int(input())
weekends = int(input())

times = 0
weekends_games = 0
games_in_Sofia = 0

if years_Type == "normal":
    weekends_games = (48 - weekends) * ( 3 / 4)
    games_in_Sofia = holidays * (2/3)
    times = weekends_games + games_in_Sofia + weekends
    print(math.floor(times))



elif years_Type == "leap":
     weekends_games = (48 - weekends) * ( 3 / 4)
     games_in_Sofia = holidays * (2/3)
     times = weekends_games + games_in_Sofia + weekends
     times += 0.15 * times
     print(math.floor(times))
