package lib.compare;

public class CompareInput extends CurrentArange {
    /**
     * LLucky number :)
     */
    private int thatNum;
    public CompareInput(int maxium, int thatNum) {
        super(maxium);
        this.thatNum = thatNum;
    }
    public boolean popBallon(int userInput) {
        return (userInput==thatNum);
    }
    public String toString() {
        return super.toString();
    }
}