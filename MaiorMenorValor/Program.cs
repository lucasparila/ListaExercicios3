float maiorNumero(float[] vetor){
    float maior = vetor[0];
	for (int i = 1; i < vetor.Length; i++){
		if (vetor[i] > maior){
			maior = vetor[i];
		}
	}
		return maior;
}

float menorNumero(float[] vetor){
    float menor = vetor[0];
    for (int i = 1; i < vetor.Length; i++)
    {
        if (vetor[i] < menor)
        {
            menor = vetor[i];
        }
    }
    return menor;
}

int tamanho = 10;
float[] numeros = new float[tamanho];

Console.WriteLine("Digite 10 números: ");

for (int i = 0; i < tamanho; i++){
    Console.WriteLine($"Digete o {i+1}º número: ");
    numeros[i] = float.Parse(Console.ReadLine()!);
}

Console.WriteLine($"O menor número digitado foi: {menorNumero(numeros)}");
Console.WriteLine($"O maior número digitado foi: {maiorNumero(numeros)}");
