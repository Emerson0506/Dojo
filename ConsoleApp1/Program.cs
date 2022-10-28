using ConsoleApp1;

Validator validator = new Validator();

string frase = "Halloween is here";

Console.WriteLine($"Frase do desafio: {frase}");
validator.ValidaMaiuscula();
validator.ValidaMinuscula();
validator.ValidaConsoante();
validator.ValidaVogal();
validator.ValidaQtdCaracteres();
validator.ValidaQtdPalavra();
