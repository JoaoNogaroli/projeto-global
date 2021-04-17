using System;
using System.Linq;

namespace projeto_global
{
    class Program
    {
        

    public static void Main(String[] args)
    {

        //variavel que será usada para o teste de divisão
        var limiteprocurar = 1000000000;

        //coloquei resumi colocando apenas os números de maior expoente
        var numeros = new int[] {16,9,5,7,11,13,17,19};

        //chamando a função
        var mmc = func_mmc(limiteprocurar, numeros);

        //print resultado
        Console.WriteLine($" O MMC é: {mmc}");
    }

    private static int func_mmc(int limiteprocurar, params int[] numeros)
    {
        //valor usado caso o programa nao consiga achar
        var defaultValue = -1;

        //pega o último numero da lista dos numeros dado
        var maxInteger = numeros.Max();

        //por exemplo, o programa pega o último numero, 20 e tenta dividir por todos os numeros dados,
        //caso nao consiga realizar a divisão, ele soma +1.
        //agora ele tenta o mesmo com o 21
        //ele somará até o limite dado na variável "limiteprocurar"
        for(int multiple =maxInteger; multiple< limiteprocurar; multiple++)
        {
            var isMultiple = true;
            foreach(var integer in numeros)
            {
                if(multiple % integer != 0)
                {
                    isMultiple = false;
                }
            }
            if(isMultiple)
            {
                return multiple;
            }
           
        }
        return defaultValue;
    }
    }
}
