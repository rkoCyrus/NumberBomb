package main

import (
	"bufio"
	"fmt"
	"os"
	"time"

	grs "github.com/rkoCyrus/gorandomstring"
)

//Private struct that storing integer in the game
type pregame struct {
	maxrange int
	lucknum  int
}

var (
	//Setup game data
	gd pregame
	//Minimum number on this round of game
	minnum int
	//Maxium number on this round of game
	maxnum int
	//Set is play or not
	playgame bool
)

//A flow which setup the game
func GameSetup() {
	var input int
	for {
		fmt.Print("Difficulty? (1:1-100, 2:1-250, 3:1-500) : ")
		_, err := fmt.Scanf("%d", &input)
		if err != nil {
			fmt.Println("Number please" + "\n")
			continue
		}
		if input > 3 || input < 1 {
			fmt.Println("Please enter 1 - 3" + "\n")
			continue
		} else {
			setmax(input)
			setluck(gd.maxrange)
			break
		}
	}
}

//Set maximum number on a range
func setmax(value int) {
	switch value {
	case 1:
		gd.maxrange = 100
		break
	case 2:
		gd.maxrange = 250
		break
	case 3:
		gd.maxrange = 500
		break
	default:
		return
	}
}

//Set lucky number
func setluck(maxrange int) {
	result := 0
	seed := []byte(grs.GenString(128, true))
	for i := 0; i < len(seed); i++ {
		if i == 0 {
			result = int(seed[i])
		} else {
			switch i % 4 {
			case 0:
				result *= int(seed[i])
			case 1:
				result -= int(seed[i])
				break
			case 2:
				result %= int(seed[i])
			case 3:
				result += int(seed[i])
				break
			}
		}
		if result <= 1 {
			continue
		}
	}
	gd.lucknum = result % maxrange
}

/*-------Border-------*/

//An interface for running game
func GameFlow() {
	kb := 0
	minnum = 1
	maxnum = gd.maxrange
	for {
		fmt.Println("\n" + "The current arrange is : " + string(minnum) + " - " + string(maxnum) + "\n")
		fmt.Print("Please enter the number : ")
		_, err := fmt.Scanf("%d", &kb)
		if err != nil {
			fmt.Println("Enter number please!")
			continue
		}
		time.Sleep(3 * time.Second)
		if ismatch(kb) {
			break
		} else {
			continue
		}
	}
	fmt.Println("You guest the \"lucky number\" : " + string(gd.lucknum) + " !")
	fmt.Println("You lose!")
}

//Check does user guest correct number
//
//If yes, he/she lose
func ismatch(userinput int) bool {
	if userinput == gd.lucknum {
		return true
	}
	if userinput > gd.lucknum {
		maxnum = userinput
	} else {
		minnum = userinput
	}
	return false
}

/*------Border------*/

func main() {
	playgame = true
	for playgame {
		GameSetup()
		GameFlow()
		valid := false
		for !valid {
			fmt.Print("Continue? (y/n) : ")
			scanner := bufio.NewReader(os.Stdin)
			yn, _, err := scanner.ReadRune()
			if err != nil {
				continue
			}
			switch yn {
			case 'N':
			case 'n':
				playgame = false
			case 'Y':
			case 'y':
				valid = true
				break
			default:
				fmt.Println("Wrong charther")
				break
			}
		}
	}
}
