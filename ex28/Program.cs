//Ex.28 Criar e Imprimir um Array

int[] numero = { 10, 20, 30, 40, 50 };

string[] nome = { "Ana", "Pedro", "Joana", "Paulo" };


for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine(numero[i]);
}

for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine(nome[i]);
}

Console.WriteLine("o nome na posição 2 é: " + nome[2]);
Console.WriteLine("o número na posição 2 é: " + numero[2]);

