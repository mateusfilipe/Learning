package com.company;
import java.util.*;

public class NotasEPeso {
    public static void main(String[] args){
        double mediaPonderada = 0;
        double nota;
        double peso;
        Scanner S = new Scanner(System.in);
        for(int i = 0 ; i < 3 ; i++){
            System.out.println("Digite a nota em seguida seu peso: ");
            nota = S.nextDouble();
            peso = S.nextDouble();

            mediaPonderada+=nota*peso;
        }
        System.out.println("Meida Ponderada: "+mediaPonderada/3);

    }
}
