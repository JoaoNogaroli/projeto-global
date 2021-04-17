using System;
using System.Linq;

namespace projeto_global
{
    class Program
    {
        

    public static void Main(String[] args)
    {
        var limiteprocurar = 1000000000;
        var numeros = new int[] {16,9,5,7,11,13,17,19};
        var mmc = func_mmc(limiteprocurar, numeros);

        Console.WriteLine($" O MMC é: {mmc}");
    }

    private static int func_mmc(int limiteprocurar, params int[] numeros)
    {
        var defaultValue = -1;
        var maxInteger = numeros.Max();

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
