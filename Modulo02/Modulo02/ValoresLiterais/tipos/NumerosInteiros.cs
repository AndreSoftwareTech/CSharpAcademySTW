using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.tipos
{
    public class NumerosInteiros
    {
        public void ExecutarInt()
        {
            // Normalmente uma idade esta em int nos sistemas em geral por ai.
            // Qual a diferenca? Performance, pois o byte usa menos memoria.
            // Principalmente quando se tem milhares ou milhoes de usuarios.
            byte idade = 18; // 8bits
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue); //s = signal =  com sinal //u = unsignal =  sem sinal


            short numeroShort = -280; // 16bits - 15bits para dados e 1 bit para sinal de positivo e negativo
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            ushort numeroShortSemSinal = 18366; // 16bits
            Console.WriteLine(ushort.MinValue); //u = unsignal =  sem sinal
            Console.WriteLine(ushort.MaxValue);

            int numeroInt = -323233; // 32bits- 31bits para dados e 1 bit para sinal de positivo e negativo
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            uint numeroIntSemSinal = 131213131; //32bits
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            long numeroLong = -12212313; // 64bits- 63bits para dados e 1 bit para sinal de positivo e negativo
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            ulong numeroUlong = 123_123_132_132; // 64bits
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(numeroUlong);


        }
    }
}
