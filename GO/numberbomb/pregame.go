package numberbomb

import (
	"fmt"

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
)

//A flow which setup the game
func GameSetup() {
	var input int
	for {
		fmt.Print("Difficulty? (1:1-100, 2:1-250, 3:1-500")
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
