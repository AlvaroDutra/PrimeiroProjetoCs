string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<String> listaDasBandas = new List<string> {"Pink Floyd", "AC/DC", "Metallica","The Beatles","Guns N' Roses"}; 

Dictionary<string, List<float>> bandasRegistradas = new Dictionary<string, List<float>> { };   

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}
 
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: ResgistrarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda(); 
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 5: Console.WriteLine("Tchau tchau :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void ResgistrarBanda(){

    ExibirTitulo("Registrar Banda");
    Console.Write("Banda: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<float>());
    Console.WriteLine($"{nomeBanda} foi resgistrada com sucesso!");

    VoltarMenu();
};

void MostrarBandas() {
    ExibirTitulo("Lista de Bandas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{Console.WriteLine($"{i + 1}. {listaDasBandas[i]}");};


    foreach (string banda in bandasRegistradas.Keys) {
        Console.WriteLine($".{banda}");
    };

    VoltarMenu();
    
};

void ExibirTitulo(string titulo) {
    Console.Clear();
    Console.WriteLine($"{titulo}\n");

};

void VoltarMenu() {
    
    Console.WriteLine("\nAperte enter para retornar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
};


void AvaliarBanda() {
    ExibirTitulo("Avaliar Banda");
    
    Console.Write("Digite o nome da banda que deseje avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda)) {
        Console.WriteLine($"\n{nomeDaBanda}");
        Console.Write("Nota:");
        float nota = float.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"Nota {nota} para {nomeDaBanda}.");    

    }else{
        Console.WriteLine($"\n{nomeDaBanda} não foi encontrada :(");
    };

    VoltarMenu();
};


ExibirOpcoesDoMenu();





