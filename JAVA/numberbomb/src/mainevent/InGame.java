package mainevent;

import lib.compare.CompareInput;

public class InGame {
    private CompareInput requirment;
    private boolean pop = false;

    public InGame(CompareInput requirment) {
        this.requirment = requirment;
    }

    public boolean isPoped() {
        return pop;
    }

    public void getCurrentRange() {
        System.out.println(requirment);
    }

    public void inputLoad(int userInput) throws InterruptedException {
        pop = requirment.popBallon(userInput);
    }
}