package lab2;

import java.util.Scanner;

public class NewClass {
    public String Input (){
        Scanner f = new Scanner(System.in, "CP1251");
        System.out.println("Введите строку, состоящую из русских слов");
        String str = f.nextLine();    
        return str;
    }
    public String[] ReverseString(String str) {
        String[] subStr;
        String delimeter = "\\s+";
        subStr = str.split(delimeter);
        
        for (int j = subStr.length - 1; j > -1; --j) {
            System.out.print(subStr[j] + " ");
        }
        return subStr;
}
}