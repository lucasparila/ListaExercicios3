const int tamanho = 10;
int[] numeros = new int[tamanho];
int busca = 0, encontrado = 0; 

for (int i = 0; i < tamanho; i++){
    numeros[i] = Random.Shared.Next(0, 5);
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("Informe o número a ser encontrado: ");
busca = Convert.ToInt32(Console.ReadLine()!);

for(int i = 0; i < tamanho; i++){
    if (numeros[i] == busca){
        encontrado++;
    }
}

Console.WriteLine($"Foram encontradas {encontrado} vezes...");
