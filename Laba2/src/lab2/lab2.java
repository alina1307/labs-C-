package lab2;

import java.util.Scanner;

public class lab2 {

    public static void main(String[] args) {

        Scanner f = new Scanner(System.in, "CP1251");
        System.out.println("Введите строку, состоящую из русских слов");
        String str = f.nextLine();

        String[] subStr;
        String delimeter = "\\s+";
        subStr = str.split(delimeter);

//        for (int i = 0; i < subStr.length; i++) {
//            System.out.print(subStr[i] + " ");
//        }
        //System.out.println("\n");
        for (int j = subStr.length - 1; j > -1; --j) {
            System.out.print(subStr[j] + " ");
        }
    }
}
