namespace Utilizando_using3_em_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*aqui abaixo deve ser colocado o caminho do arquivo, porém nesse caso temos um  texto que o StringReader irá ler*/
            string numeros = @"Um Dois Três Quatro";
            string letras = @"A B C D";

            using (StringReader esquerda = new StringReader(numeros), direita = new StringReader(letras))
            // Acima utilizamos o using pois está instrução fornece uma abordagem melhor para destruição de arquivos
            // Criamos dois objetos do tipo String Reader esquerda e direita, que receberam o contéudo das variáveis do tipo string
            //numeros e letras
            {
                string? item; //Criamos uma variável do tipo string com o nome de item, que pode receber valores nulos como valor ("?")

                do //utilizamos a Estrutura de repetição Do while (Faça enquanto), que irá executar se o arquivo dentro de item se for direfente de nulo.
                {
                    item = esquerda.ReadLine(); //Item aqui recebe o conteudo do tipo String Reader esquerda
                    Console.WriteLine(item); //printa o conteúdo do tipo esquerda que o seu contéudo é a variável do tipo string numeros
                    item = direita.ReadLine(); //Agora item recebe o contéudo do tipo String Reader direita
                    Console.WriteLine(item); //E imprime o contéudo do tipo direita que é a variável do tipo string letras

                } while (item != null); //O que está dentro do do while só irá executar se o arquivo for dirente de nulo.
            }
        }
    }
}