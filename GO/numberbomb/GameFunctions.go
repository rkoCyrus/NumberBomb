package numberbomb

// Important that this struct will contain needed data for the game
type gamedata struct {
	// Maxium number
	maxnum int
	// "Lucky" number :))))))
	//
	// If guest right, you lose
	luck int
	// Check that some one require end the game
	endgame bool
}

var (
	// Make gamedata "object"
	//
	// Variable can be found on `gamedata` struct which on top one in the same files
	gd gamedata
)

// Set maxium and return if invalid
func setMax(diffcode int) {
	switch diffcode {
	case 1:
		gd.maxnum = 100
		break
	case 2:
		gd.maxnum = 250
		break
	case 3:
		gd.maxnum = 500
		break
	default:
		return
	}
}
