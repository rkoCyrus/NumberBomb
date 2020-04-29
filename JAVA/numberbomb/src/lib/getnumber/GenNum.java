package lib.getnumber;

import java.util.Random;

/**
 * This class is initalizing the number and difficulty.
 */
public class GenNum {
    private int chosen = 0;
    private int maxNum;

    /**
     * Create a class for pickout number in difference
     * @param diffGrade Dificulty, 1 = 1-100, 2 = 1 - 250, 3 = 1 - 500
     */
    public GenNum(int diffGrade) {
        thatNumber(diffGrade);
    }

    /**
     * Processing the number for the game
     * @param difficulty (Please revel GenNum constructor)
     */
    private void thatNumber(int difficulty) {
        switch (difficulty) {
            case 1:
                maxNum = 100;
                break;
            case 2:
                maxNum = 250;
                break;
            case 3:
                maxNum = 500;
                break;
            default:
                System.out.println("Please enter 1,2,3");
                return;
        }
        do {
            Random picker = new Random();
            chosen = picker.nextInt();
            if (chosen>=maxNum) {
                chosen %= maxNum;
            }
        } while (chosen<=1);
    }

    /**
     * Allow other class get which number will "pop the balloon"
     * @return "Lucky number"
     */
    public int getNum() {
        return chosen;
    }

    /**
     * Get maxium number in game
     * @return Maxium number in a range
     */
    public int getMaxium() {
        return maxNum;
    }
}