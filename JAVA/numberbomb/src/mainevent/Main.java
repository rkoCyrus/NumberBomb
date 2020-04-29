package mainevent;

import java.util.InputMismatchException;
import java.util.NoSuchElementException;
import java.util.Scanner;

/**
 * The main program of the game
 * The game is simple: Don;t guest right number to computer
 * @author rk0_d
 */
public class Main {
    private static Scanner key;
    private static PreGame pg;
    private static InGame ig;
    /**
     * Main event of the program
     */
    public static void main(String[] args) throws InterruptedException, NoSuchElementException {
        //Play another round or exit
        boolean isAgain = false;

        //Player input numbers
        int inputNumber;

        try {
            // Full process
            do {
                pg = new PreGame();
                ig = new InGame(pg.getGameRequire());

                // Game procecss
                do {
                    try {
                        key = new Scanner(System.in);
                        ig.getCurrentRange();
                        System.out.print("Please enter the number what you guest: ");
                        inputNumber = key.nextInt();
                        ig.inputLoad(inputNumber);
                    } catch (InputMismatchException e) {
                        // When user typed non integer
                        System.out.println("Please enter number, please\n");
                    }
                } while (!ig.isPoped()); // Until someone guest right

                // Print out lose message
                System.out.println("You lose! The program picked " + pg.getTheNumber() + "!");

                // Consider is play again or exit
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
            } while (isAgain); // Consider need play another round
        } catch (NoSuchElementException e) {
            System.exit(0);
        }
    }
}