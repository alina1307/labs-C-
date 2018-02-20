package javaapplication7;

public class Factoriall {

    public int factorial(int n) {
        int result = 1;
        for (int i = 2; i <= n; i++) {
            result *= i;
        }
        if (n == 0 || n == 1) {
            System.out.println(" Факториал числа " + n + " равен " + result);
        } else {
            System.out.println(" Факториал числа " + n + " равен " + result);
        }
        return result;
    }
}
