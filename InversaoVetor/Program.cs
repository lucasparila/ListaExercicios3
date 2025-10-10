
void exibirVetor(int[] vetor, int tamanho){

    for (int i = 0; i < tamanho; i++){
        Console.Write($" {vetor[i]}");
    }
}

const int tamanho = 6;
int[] lidos = new int[tamanho];
int[] pares = new int[tamanho];
int[] impar = new int[tamanho];

Console.WriteLine($"Digite {tamanho} números inteiros: ");


for (int i = 0; i < tamanho; i++) {
    Console.WriteLine($"Digite {i + 1}º número: "); 
    lidos[i] = int.Parse(Console.ReadLine()!);
}

int contadorPares = 0;
int contadorImpar = 0;

for (int i = 0; i < tamanho; i++){
    if (lidos[i] % 2 == 0){
        pares[contadorPares] = lidos[i];
        contadorPares++;
    }
    else{
        impar[contadorImpar] = lidos[i];
        contadorImpar++;
    }

}

exibirVetor(pares, contadorPares);
Console.WriteLine();
exibirVetor(impar, contadorImpar);
