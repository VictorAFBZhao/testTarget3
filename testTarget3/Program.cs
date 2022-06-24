using System;

namespace testTarget3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fatDiario = new int[7];
            int i = 0, soma=0, j=0, contador=0, x=0, maior=0, menor=0;



            fatDiario[0] = 102;
            fatDiario[1] = 30;
            fatDiario[2] = 62;
            fatDiario[3] = 40;
            fatDiario[4] = 60;
            fatDiario[5] = 45;
            fatDiario[6] = 150;

            maior = fatDiario[0];
            for(x =0; x < 7; x++)
            {
                if(fatDiario[x] > maior)
                {
                    maior = fatDiario[x];
                }
            }
            menor = fatDiario[0];
            for (x = 0; x < 7; x++)
            {
                if (fatDiario[x] < menor)
                {
                    menor = fatDiario[x];
                }
            }

            while (i < 7)
            {
                soma += fatDiario[i];
                i++;
            }
            int media = soma / 7;

            while(j < 7)
            {
                if(media < fatDiario[j])
                {
                    contador++;
                }
                j++;
            }

            Console.WriteLine("numeros de dias com valor maior que media mensal: " + contador);


            Console.WriteLine("Maior valor " + maior);
            Console.WriteLine("Menor valor " + menor);











        }
    }
}
