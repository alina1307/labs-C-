package javaapplication7;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("Введите натуральное число");
        int n = in.nextInt();
        if (n > 100) {
            System.out.println("Число больше 100");
        } else if (n < 0) {
            System.out.println("Вы ввели отрицательный факториал!");
        } else {
            Factoriall searcher = new Factoriall();
            System.out.println("2*n!" + " = " + 2 * searcher.factorial(n));
        }
    }
}
