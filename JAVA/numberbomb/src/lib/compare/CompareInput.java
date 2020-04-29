package lib.compare;

/**
 * This class is inherted by CurrentArrange which allow to focus on 
 */
public class CompareInput extends CurrentArange {
    /**
     * Lucky number :)
     */
    private int thatNum;

    /**
     * Setup the condition for the game
     * @param maxium Maxium number in a range
     * @param thatNum The number will let the player lose (except 1 and maxium number)
     */
    public CompareInput(int maxium, int thatNum) {
        super(maxium);
        this.thatNum = thatNum;
    }

    /**
     * Trigger "Pop balloon" event (Player who entered the number lose) or ask input another number again
     * Otherwise, update the range
     * @param userInput Player's input
     * @return (boolean) is match the number
     */
    public boolean popBallon(int userInput) throws InterruptedException {
        if (userInput>=super.maxRange || userInput<=super.minRange) {
            System.out.println("You can't input this number into the game!\n");
        } else {
            System.out.println("Your input is " + userInput + '\n');
            Thread.sleep(3000);
            if (userInput==thatNum) {
                return true;
            } else {
                if (userInput<thatNum)
                    super.minRange = userInput;
                else if (userInput>thatNum)
                    super.maxRange = userInput;
            }
        }
        return false;
    }

    public String toString() {
        return super.toString();
    }
}