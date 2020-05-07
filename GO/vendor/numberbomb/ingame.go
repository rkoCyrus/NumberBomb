package numberbomb

import (
	"fmt"
	"time"
)

var (
	//Minimum number on this round of game
	minnum int
	//Maxium number on this round of game
	maxnum int
)

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
