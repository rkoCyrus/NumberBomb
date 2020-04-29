package mainevent;

import lib.compare.CompareInput;

/**
 * The events which trigger between main program and library
 * @author rk0_d
 */
public class InGame {
    private CompareInput requirment;
    private boolean pop = false;

    /**
     * Invoke game event
     * @param requirment All need process for <code>InGame</code> class
     */
    public InGame(CompareInput requirment) {
        this.requirment = requirment;
    }

    /**
     * @see lib.compare.CompareInput#popBalloon(int userInput)
     */
    public boolean isPoped() {
        return pop;
    }

    /**
     * Print out the current range of this round
     */
    public void getCurrentRange() {
        System.out.println(requirment);
    }

    /**
     * @see lib.compare.CompareInput#popBalloon(int userInput)
     */
    public void inputLoad(int userInput) throws InterruptedException {
        pop = requirment.popBalloon(userInput);
    }
}