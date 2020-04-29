package mainevent;

import java.util.InputMismatchException;
import java.util.Scanner;

import lib.compare.*;
import lib.getnumber.*;

public class PreGame {
    private static Scanner key;
    private static CompareInput gameProcess;
    private int theNum;
    public PreGame() {
        while (true) {
            try {
                key = new Scanner(System.in);
                int lvl;
                System.out.print("Difficultty? (1-3): ");
                lvl = key.nextInt();
                GenNum gn = new GenNum(lvl);
                if (gn.getNum()<=1) {
                    continue;
                } else {
                    gameProcess = new CompareInput(gn.getMaxium(), gn.getNum());
                    theNum = gn.getNum();
                    System.out.println();
                    break;
                }
            } catch (InputMismatchException e) {
                System.out.println("Number please\n");
                continue;
            }
        }
    }

    public CompareInput getGameRequire() {
        return gameProcess;
    }

    public int getTheNumber() {
        return theNum;
    }
}