package lib.getnumber;

import java.lang.Math;

public class GenNum {
    private int chosen = 0;
    private int maxNum;

    public GenNum(int diffGrade) {
        thatNumber(diffGrade);
    }

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
            double rawRand = Math.random();
            rawRand *= 1000;
            chosen = (int)rawRand;
        } while (chosen<=0||chosen>maxNum);
    }

    public int getNum() {
        return chosen;
    }

    public int getMaxium() {
        return maxNum;
    }
}