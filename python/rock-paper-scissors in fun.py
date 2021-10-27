def game():
 while True:
    p1 = input("player1 please enter rock,scissor or paper: ")
    p2 = input("player2 please enter rock,scissor or paper: ")
    if p1 == p2:
        print("Its a tie!!!")

    elif p1 == 'rock':
        if p2 == 'scissors':
            print("player 1 wins\n Congratulations!!!")
        else:
            print("player 2 wins\n Congratulations!!!")
    elif p1 == 'scissors':
        if p2 == 'paper':
            print("player1 wins\n Congratulations!!!")
        else:
            print("player 2 wins\n Congratulations!!!")
    elif p1 == 'paper':
        if p2 == 'rock':
            print("player1 wins\n Congratulations!!!")
        else:
            print("player2 wins\n Congratulations!!!")
    else:
        print("enter valid input")
    print("Do you want to play again? (Yes/No)")
    ans = input()
    if ans == 'no' or ans == 'No':
        break
game()
print("\nThanks for playing")
