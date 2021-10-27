list = ['paper','scissors','rock']
i = True
while i==True:
    p1 = input("enter p1 choice :")
    p2 = input("enter p2 choice :")
    if (p1 != p2) and (p1 in list) and (p2 in list):
        if (p1 == "rock" and p2 == "scissors") or (p1 == "paper" and p2 == "rock") or (p1 == "scissors" and p2 == "paper"):
            print("p1 wins")
        else:
            print("p2 wins")
        playagain = input("play again:(yes/no):")
        if playagain == "yes":
            i = True
        else:
            i = False
    else:
        print("retrying game! enter a valid input")
        pass















