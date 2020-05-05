package numberbomb

import "fmt"

var (
	diff    int
	genluck int
)

//Initalize for the game that set a range for the game
func getDifficulty() {
	for {
		fmt.Print("Difficulty: (1: 1-100, 2: 1-250, 3: 1-500)")
	}
}
