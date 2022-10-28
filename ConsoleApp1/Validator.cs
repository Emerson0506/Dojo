namespace ConsoleApp1
{
    public class Validator
    {
        public string Frase = "Halloween is here";
        public void ValidaMaiuscula()
        {

            string maiusculo = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string minusculo = "abcdefghijklmnopqrstuvwxyz";

            int qtdMaiusculo = 0;


            for (int i = 0; i < Frase.Length; i++)
            {
                for (int j = 0; j < maiusculo.Length; j++)
                {
                    if (Frase[i] == maiusculo[j])
                    {
                        qtdMaiusculo++;
                    }
                }
            }

            Console.WriteLine("Quantidades de letras maíusculas: " + qtdMaiusculo);

        }
        public void ValidaMinuscula()
        {
            string minusculo = "abcdefghijklmnopqrstuvwxyz";
            int qtdMinusculo = 0;

            for (int i = 0; i < Frase.Length; i++)
            {
                for (int j = 0; j < minusculo.Length; j++)
                {
                    if (Frase[i] == minusculo[j])
                    {
                        qtdMinusculo++;
                    }
                }
            }

            Console.WriteLine("Quantidades de letras minúsculas: " + qtdMinusculo);
        }
        public void ValidaConsoante()
        {
            string consoantes = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxy";
            int numeroConsoantes = 0;

            for (int i = 0; i < Frase.Length; i++)
            {
                for (int j = 0; j < consoantes.Length; j++)
                {
                    if (Frase[i] == consoantes[j])
                    {
                        numeroConsoantes++;
                    }
                }
            }

            Console.WriteLine("Quantidade de consoantes: " + numeroConsoantes);

        }
        public void ValidaVogal()
        {

            string vogais = "AEIOUaeiou";
            int numeroVogais = 0;


            for (int i = 0; i < Frase.Length; i++)
            {
                for (int j = 0; j < vogais.Length; j++)
                {
                    if (Frase[i] == vogais[j])
                    {
                        numeroVogais++;
                    }
                }
            }

            Console.WriteLine("Quantidades de vogais: " + numeroVogais);
        }

        public void ValidaQtdCaracteres()
        {
            Console.WriteLine("Quantidade de caracteres na frase: " + Frase.Length);
        }
        public void ValidaQtdPalavra()
        {
            string espaco = " ";
            int qtdEspaco = 0;

            for (int i = 0; i < Frase.Length; i++)
            {
                for (int j = 0; j < espaco.Length; j++)
                {
                    if (Frase[i] == espaco[j])
                    {
                        qtdEspaco++;
                    }
                }
            }
            Console.WriteLine($"Quantidade de palavras: {qtdEspaco + 1}");
        }

        //public void ValidaQtdPalavraOpcao2()
        //{

        //    var contagem = Frase.Split(' ');

        //    Console.WriteLine(contagem.Length);
        //}
    }
}
