package mainevent;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {
    private static Scanner key;
    private static PreGame pg;
    private static InGame ig;
    public static void main(String[] args) throws InterruptedException {
        boolean isAgain = false;
        int inputNumber;
        do {
            pg = new PreGame();
            ig = new InGame(pg.getGameRequire());
            do {
                try {
                    key = new Scanner(System.in);
                    ig.getCurrentRange();
                    System.out.print("Please enter the number what you guest: ");
                    inputNumber = key.nextInt();
                    ig.inputLoad(inputNumber);
                } catch (InputMismatchException e) {
                    System.out.println("Please enter number, please\n");
                }
            } while (!ig.isPoped());
            System.out.println("You lose! The program picked " + pg.getTheNumber() + "!");
            boolean illegalInput = true;
            while (illegalInput) {
                System.out.print("Play again? (Y/N)");
                char yn = key.next().charAt(0);
                switch (yn) {
                    case 'Y':
                    case 'y':
                        isAgain = true;
                    case 'N':
                    case 'n':
                        illegalInput = false;
                        break;
                    default:
                        System.out.println("Sorry, please type again");
                }
            }
        } while (isAgain);
    }
}