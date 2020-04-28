package lib.compare;

public class CurrentArange {
    protected int minRange;
    protected int maxRange;
    
    public CurrentArange(int maxium) {
        this.minRange = 1;
        this.maxRange = maxium;
    }

    public String toString() {
        return "The current arrange is: " + minRange + " to " + maxRange;
    }
}