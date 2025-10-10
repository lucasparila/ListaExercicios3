using System.Net.Http.Headers;

const int tamanho = 5;
double[] precos = new double[tamanho];
double[] precosComDesconto = new double[tamanho];

for (int i = 0; i < tamanho; i++){
    precos[i] = Random.Shared.NextDouble() * 100; 
}

for (int i = 0; i < tamanho; i++){
    precosComDesconto[i] = precos[i] - (precos[i] *0.1);
}

for(int i = 0; i < tamanho; i++){
    Console.Write($"R$ {precos[i]:f2} ");
}

Console.WriteLine("\n \n");

for (int i = 0; i < tamanho; i++)
{
    Console.Write($"R$ {precosComDesconto[i]:f2} ");
}