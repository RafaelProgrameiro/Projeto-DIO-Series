
using Projeto_DIO_Series;
using Projeto_DIO_Series.Classes;
using static Projeto_DIO_Series.Classes.Series;

SerieRepository repository = new SerieRepository();

System.Console.WriteLine(repository);


string getUserOption = GetUserOption();

while (getUserOption.ToUpper() != "X")
{
    switch (getUserOption)
    {
        case "1":
        ListSerie();
        break;

        case "2":
        CreatetSerie();
        break;
        
        case "3":
        UpdateSerie();
        break;

        case "4":
        DeleteSerie();
        break;

        case "5":
       ViewSerie();
        break;

        case "6":
        Console.Clear();
        break;

        default:
            throw new ArgumentOutOfRangeException();


    }

    getUserOption = GetUserOption();
}

void ListSerie()
{
    System.Console.WriteLine("Listar Series");

    var list = repository.List();

    if(list.Count == 0)
    {
        System.Console.WriteLine("Nenhuma série cadastrada");
        return;
    }

    foreach(var serie in list)
    {
        var deleted = serie.ReturnDeleted();
        
        System.Console.WriteLine("#ID {0} - {1} - {2}", serie.ReturnId(), serie.ReturnTitle(), (deleted ? "*Excluído*" : ""));
    }    
}

void CreatetSerie()
{
    System.Console.WriteLine("Inserir uma nova série");

    foreach(int i in Enum.GetValues(typeof(Gender)))
    {
        System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
    }
    System.Console.WriteLine("Digite o Gênero entre as opções acima: ");
    int enterGender = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Digite o Título da Série");
    string enterTitle = Console.ReadLine();

    System.Console.WriteLine("Digite o Ano de Início da Série");
    int enterYear = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Digite a Descrição da Série: ");
    string enterDescription = Console.ReadLine();

    Serie newSerie = new Serie(id: repository.NextId(),
                                gender: (Gender)enterGender,
                                title: enterTitle,
                                year: enterYear,
                                description: enterDescription);

    repository.Create(newSerie);                            
}
void UpdateSerie()
{
    System.Console.WriteLine("Digite o Id da série:");
    int serieIndex = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Digite o Gênero entre as opções acima: ");
    int enterGender = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Digite o Título da Série");
    string enterTitle = Console.ReadLine();

    System.Console.WriteLine("Digite o Ano de Início da Série");
    int enterYear = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Digite a Descrição da Série: ");
    string enterDescription = Console.ReadLine();

    Serie updateSerie = new Serie(id: serieIndex,
                                gender: (Gender)enterGender,
                                title: enterTitle,
                                year: enterYear,
                                description: enterDescription);

    repository.Update(serieIndex, updateSerie);
}
void DeleteSerie()
{
    System.Console.WriteLine("Digite o Id da série:");
    int serieIndex = int.Parse(Console.ReadLine());

    repository.Delete(serieIndex);
}
void ViewSerie()
{
    System.Console.WriteLine("Digite o Id da série:");
    int serieIndex = int.Parse(Console.ReadLine());

    var serie = repository.ReturnById(serieIndex);

    System.Console.WriteLine(serie);
}




static string GetUserOption()
{
    
    System.Console.WriteLine();
    System.Console.WriteLine("DIO Series a seu dispor!!");
    System.Console.WriteLine("Informe a opção desejada");

    System.Console.WriteLine("1 - Listar séries");
    System.Console.WriteLine("2 - Inserir nova série");
    System.Console.WriteLine("3 - Atualizar série");
    System.Console.WriteLine("4 - Excluir série");
    System.Console.WriteLine("5 - Visualizar série");
    System.Console.WriteLine("C - Limpar Tela");
    System.Console.WriteLine("X - Sair");
    System.Console.WriteLine();

    string getUserOption = Console.ReadLine().ToUpper();
    System.Console.WriteLine();
    return getUserOption;
}

