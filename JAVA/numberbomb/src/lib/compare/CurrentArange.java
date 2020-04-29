package lib.compare;

/**
 * Set maxium and minium range for the game
 */
public class CurrentArange {
    protected int minRange = 1;
    protected int maxRange;
    
    /**
     * Set value when initializing
     * @param maxium Maxium number
     */
    public CurrentArange(int maxium) {
        this.maxRange = maxium;
    }

    public String toString() {
        return "The current arrange is: " + minRange + " to " + maxRange;
    }
}