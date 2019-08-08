package com.company;
import java.util.*;

public class NumerosReais {
    public static void main(String[] args){
        Scanner S1 =  new Scanner(System.in);
        double n1 = S1.nextDouble();

        Scanner S2 =  new Scanner(System.in);
        double n2 = S2.nextDouble();

        Scanner S3 =  new Scanner(System.in);
        double n3 = S3.nextDouble();
        double resultado = (n1*n2)/n3;
        System.out.println("Média: "+resultado);
    }
}
