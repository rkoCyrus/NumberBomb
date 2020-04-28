package mainevent;

import java.util.InputMismatchException;
import java.util.Scanner;

import lib.compare.*;
import lib.getnumber.*;

public class Main {
    public static Scanner key;
    private static CurrentArange cA; 
    public static void main(String[] args) throws Exception {
        while (true) {
            try {
                key = new Scanner(System.in);
                System.out.print("Difficultty? (1-3): ");
                int lvl = key.nextInt();
                GenNum gn = new GenNum(lvl);
                if (gn.getNum()<=0) {
                    continue;
                } else {
                    cA = new CurrentArange(gn.getMaxium());
                }
            } catch (InputMismatchException e) {
                System.out.println("Number please");
                continue;
            }
        }
    }
}