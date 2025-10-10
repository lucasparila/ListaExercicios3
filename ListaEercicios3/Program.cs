int somaVetor(int[] vetor){
    int soma = 0;
    for(int i = 0; i < vetor.Length; i++){

        soma += vetor[i];
    }
    return soma;
}

int calculaMedia(int[] vetor){
    return somaVetor(vetor)/vetor.Length;
}

int tamanhoVetor = 5;
int[] numerosInteiros = new int[tamanhoVetor];
Console.WriteLine($"Digite {tamanhoVetor} números inteiros: ");

for (int i = 0; i < numerosInteiros.Length; i++){
    numerosInteiros[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Soma do vetor: {somaVetor(numerosInteiros)}");
Console.WriteLine($"Media do vetor: {calculaMedia(numerosInteiros)}");
Console.WriteLine("Fim do programa.");
