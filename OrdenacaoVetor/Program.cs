void exibirVetor(int[] vetor, int tamanho)
{

    for (int i = 0; i < tamanho; i++)
    {
        Console.Write($" {vetor[i]}");
    }
}

int[] ordenarVetor(int[] vetor, int tamanho){

    int aux;
    for(int i = 0; i < tamanho -1; i++){
        int menor = i;
        for(int j = i+1; j < tamanho; j++){
            if (vetor[j] > vetor[menor]) {
                menor = j;
            }
        }
        aux = vetor[i];
        vetor[i] = vetor[menor];
        vetor[menor] = aux;  
    }
    return vetor;
}

const int tamanho = 10;
int[] numeros = new int[tamanho];
int[] ordenados = new int[tamanho];

for (int i = 0; i < tamanho; i++)
{
    numeros[i] = Random.Shared.Next(0, 100);
}

exibirVetor(numeros, tamanho);
Console.WriteLine("\n \n");

ordenados = ordenarVetor(numeros, tamanho);
exibirVetor(ordenados, tamanho);


