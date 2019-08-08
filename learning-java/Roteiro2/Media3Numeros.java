package com.company;
import java.util.*;

public class Media3Numeros {
    public static void main(String[] args){
        Scanner S1 =  new Scanner(System.in);
        int n1 = S1.nextInt();

        Scanner S2 =  new Scanner(System.in);
        int n2 = S2.nextInt();

        Scanner S3 =  new Scanner(System.in);
        int n3 = S3.nextInt();
        int media = (n1+n2+n3)/3;
        System.out.println("Média: "+media);
    }
}
