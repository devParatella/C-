using System;

class ArrayUnidimencionalVetor{
    static void Main(){
        //forma extença
        int[] n1=new int[5];

        n1[0] = 1;
        n1[1] = 2;
        n1[2] = 3;
        n1[3] = 4;
        n1[4] = 5;

        Console.WriteLine(n1[0]);

        //Atribuindo valores diretamente
        int[] n2=new int[5]{1,2,3,4,5};
        Console.WriteLine(n2[2]);

        //Forma simplificada
        int[] n3=[1, 2, 3, 4, 5];
        Console.WriteLine(n3[3]);

        //String
        string[] veiculos=["Carro","Avião","Navio"];
        Console.WriteLine(veiculos[2]);


    }
}