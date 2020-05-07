package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
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
func (data *pregame) GameSetup() {
	var input int
	var err error
	for {
		fmt.Print("Difficulty? (1:1-100, 2:1-250, 3:1-500) : ")
		input, err = scanint()
		if err != nil {
			fmt.Println("Number please" + "\n")
			continue
		}
		if input > 3 || input < 1 {
			fmt.Println("Please enter 1 - 3" + "\n")
			continue
		} else {
			data.setmax(input)
			data.setluck(gd.maxrange)
			break
		}
	}
}

//Set maximum number on a range
func (data *pregame) setmax(value int) {
	switch value {
	case 1:
		data.maxrange = 100
		break
	case 2:
		data.maxrange = 250
		break
	case 3:
		data.maxrange = 500
		break
	default:
		return
	}
}

//Set lucky number
func (data *pregame) setluck(max int) {
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
	data.lucknum = result % max
}

/*-------Border-------*/

//An interface for running game
func (data *pregame) GameFlow() {
	var kb int
	var err error
	minnum = 1
	maxnum = data.maxrange
	for {
		fmt.Println("\n" + "The current arrange is : " + strconv.Itoa(minnum) + " - " + strconv.Itoa(maxnum) + "\n")
		fmt.Print("Please enter the number : ")
		kb, err = scanint()
		if err != nil {
			fmt.Println("Enter number please!")
			continue
		}
		if kb >= maxnum || kb <= minnum {
			fmt.Println("You can not input out of range number")
			continue
		}
		time.Sleep(3 * time.Second)
		if data.ismatch(kb) {
			break
		} else {
			continue
		}
	}
	fmt.Println("You guest the \"lucky number\" : " + strconv.Itoa(data.lucknum) + " !")
	fmt.Println("You lose!")
}

//Check does user guest correct number
//
//If yes, he/she lose
func (data *pregame) ismatch(userinput int) bool {
	if userinput == data.lucknum {
		return true
	}
	if userinput > data.lucknum {
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
		gd.GameSetup()
		gd.GameFlow()
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
				valid = true
				break
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

//Convert to integer
func scanint() (int, error) {
	in := bufio.NewScanner(os.Stdin)
	in.Scan()
	convert, err := strconv.Atoi(in.Text())
	return convert, err
}
