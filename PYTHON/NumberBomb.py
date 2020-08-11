# I make this as one file only
# I have no idea how Python work since there is no requirment of class which make me confuse on parsing data
# To ensure it work and upload to pip, it's better to use one file for entire program

#Import
import random
import time

# Global variable 
minRange = 1
maxRange = 0
luckNum = 0
userInput = -1
playTheGame = True


def compareNumber(user,computer):
    """Compare does user input 'Lucky' number

    Args:
        user (int): user input
        computer (int): computer generated number

    Returns:
        booleans
    """
    if int(user)==int(computer):
        return True
    
    return False

while playTheGame:
    while True:
        try:
            diff = input("Difficulties? (1:1-100, 2:1-250, 3:1-500) : ")
            if (int(diff) >= 1 and int(diff) <= 3):
                swithcer = {
                    1:100,
                    2:250,
                    3:500
                }
                maxRange = swithcer.get(int(diff))
                break
            else:
                print("Please select 1-3")
                continue
        except ValueError:
            print("Number please!")
            continue

    # When finished while loop, pick the number
    luckNum = random.randint(2,maxRange-1)
        
    while True:
        try:
            print("\nCurrent range : " + str(minRange) + " - " + str(maxRange) + '\n')
            kbInput = input("Please pick the number : ")
            if (int(kbInput) > minRange and int(kbInput) < maxRange):
                if (compareNumber(int(kbInput),luckNum)):
                    time.sleep(3.0)
                    break
                else:
                    time.sleep(3.0)
                    if int(kbInput) > luckNum:
                        maxRange = int(kbInput)
                    else:
                        minRange = int(kbInput)
                continue
            else:
                print('\n'+"Invalid input!!!"+'\n')
                continue
        except ValueError:
            print("\nCome on, input integer please...\n")
            continue
        except (KeyboardInterrupt, SystemExit):
            exit(0)
        except (KeyboardInterrupt, not SystemExit):
            print("\nYou can't use interupter to affect program (expect Ctrl+C)")
            continue

    print("\nThe balloon poped!\nThe \"lucky number\" is " + str(luckNum) + "\n\nYou lose!\n")
    
    while True:
        yn = input("Continue? (y/n) : ")
        if yn == "y":
            minRange = 1
            userInput = -1
            luckNum = 0
            break
        elif yn == "n":
            playTheGame = False
            break
        else:
            print("Please enter (y/n)\n")
            continue

exit(0)


