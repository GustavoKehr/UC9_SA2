using System.Globalization;
using System.Text.RegularExpressions;
using ER4.Classes;


//Tipo nomeDoObjeto = metodoConstrutor();

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine(@$"
=========================================
|  Bem vindo ao sistema de cadastro de  |
|      Pessoas Físicas e Jurídicas      |
=========================================
");

Console.ResetColor();

Utils.BarraCarregamento("Sistema iniciando", 300, 6);

string? opcao;

do
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.WriteLine(@$"

=========================================
|     Escolha uma das opções abaixo     |
|---------------------------------------|
| 1 - Pessoa Física                     |
| 2 - Pessoa Jurídica                   |
|                                       |
| 0 - Sair                              |
=========================================
");
    Console.ResetColor();

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //instanciamos objeto do tipo endereco 
            //atribuimos valores para os atributos
            Endereco newEndereco = new Endereco();

            newEndereco.Logradouro = "Rua Deodato Wertheim";
            newEndereco.Bairro = "Vila Mogilar";
            newEndereco.Numero = 19;
            newEndereco.Uf = "SP";
            newEndereco.Cep = "08773-090";
            newEndereco.Pais = "Brasil";
            newEndereco.Comercial = true;

            //instancia do objeto do tipo pessoa fisica
            //ou seja, estamos criando um objeto
            PessoaFisica newPF = new PessoaFisica();

            newPF.Nome = "Gustavo Casanova Kehr de Oliveira";
            newPF.Cpf = "54698712399";
            newPF.DataNasc = new DateTime(2002, 10, 05);
            newPF.DataNascimento = "10/05/2002";
            newPF.Rendimento = 1900.12f;
            newPF.Endereco = newEndereco;

            PessoaFisica metodosPF = new PessoaFisica();
            Console.Clear();
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(@$"
Digite seu nome: {newPF.Nome}
Digite seu CPF: {newPF.Cpf}
Digite sua Data de Nascimento:{newPF.DataNasc}
Digite seu Rendimento:R$ {newPF.Rendimento}
Digite seu endereço Endereço: {newPF.Endereco.Logradouro}, {newPF.Endereco.Bairro}, {newPF.Endereco.Numero}, {newPF.Endereco.Uf}, {newPF.Endereco.Cep}
Data de nascimento válida?: {(metodosPF.ValidarDataNasc(newPF.DataNascimento) ? "Sim" : "Não, insira novamente a data")}
Maior de idade?: {(metodosPF.ValidarDataNasc(newPF.DataNasc) ? "Sim" : "Não")}
Impostos á pagar : {metodosPF.PagarImposto(newPF.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
");
            Console.WriteLine("Aperte a tecla ENTER para continuar");
            Console.ReadLine();
            Console.ResetColor();
            break;

        case "2":
            
            Endereco newEnderecoPJ = new Endereco();

            newEnderecoPJ.Logradouro = "Nepperhan Avenue";
            newEnderecoPJ.Bairro = "Yonkers";
            newEnderecoPJ.Numero = 700;
            newEnderecoPJ.Uf = "NY";
            newEnderecoPJ.Cep = "10703";
            newEnderecoPJ.Pais = "Estados Unidos";
            newEnderecoPJ.Comercial = true;

            PessoaJuridica newPJ = new PessoaJuridica();

            newPJ.Nome = "Valve";
            newPJ.Cnpj = "05743368000163";
            newPJ.RazaoSocial = "PRECISION VALVE CORPORATION";
            newPJ.Rendimento = 730000000;
            newPJ.Endereco = newEnderecoPJ;

            PessoaJuridica metodosPJ = new PessoaJuridica();
Console.Clear();
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(@$"
Nome: {newPJ.Nome}
CNPJ: {newPJ.Cnpj}
Razão Social: {newPJ.RazaoSocial}
Rendimento: R$ {newPJ.Rendimento}
Endereco: {newPJ.Endereco.Logradouro}, {newPJ.Endereco.Bairro}, {newPJ.Endereco.Numero}, {newPJ.Endereco.Uf}, {newPJ.Endereco.Cep}
Cpnj válido?: {(metodosPJ.ValidarCnpj(newPJ.Cnpj) ? "Sim" : "Não, insira novamente um novo cnpj")}
Imposto á pagar :  {metodosPJ.PagarImposto(newPJ.Rendimento).ToString("C", new CultureInfo("pt-BR"))} 
");
Console.WriteLine("Aperte a tecla ENTER para continuar");
Console.ReadLine();
Console.ResetColor();
            break;

        case "0":
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigado por utilizar nosso sistema");
            Console.ResetColor();
            Thread.Sleep(200);
        Console.WriteLine("Aperte a tecla ENTER para continuar");
        Console.ReadLine();
            break;

        default:
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"Opção inválida, retorne e digite o número corretamente");
            Console.ResetColor();
            Thread.Sleep(5000);
            break;
    }
} while (opcao != "0");
Console.Clear();

Utils.BarraCarregamento("Sistema finalizando", 800, 5);

//usamos para manipular os metodos



//impremimos no console os valores do objeto utilizando aprenas um Console.WriteLine, utilizando o @ antes do $
//o melhor

//string data = "16/05/2000";
//bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
//Console.WriteLine(valido ? "Sim" : "Não, insira novamente uma data");
//Data de Nascimento válida? {(metodosPF.ValidarDataNasc(newPF.DataNasc) ? "Sim" : "Não, insira novamente uma data");}

//outros meios de verificacao de idade, porem sem dizer se sim ou nao, ou o que colocar entre parenteses
//Maior de idade?: {metodosPF.ValidarDataNasc(newPF.DataNasc)}
// Maior de idade? - string : {metodosPF.ValidarDataNasc("10/05/2002")}

//imprimimos no console os valores do objeto utilizando interpolação //atalho: cwl
//mais usado em empresas

// Console.WriteLine($"Nome: {newPF.Nome}");
// Console.WriteLine($"CPF: {newPF.Cpf}");
// Console.WriteLine($"Data de Nascimento: {newPF.DataNasc}");
// Console.WriteLine($"Rendimento: R$ {newPF.Rendimento}");

//imprimimos no console  os valores do objeto utilizando a concatenação //atalho: cw

// Console.WriteLine("Nome: " + newPF.Nome);
// Console.WriteLine("CPF: " + newPF.Cpf);
// Console.WriteLine("Data de Nascimento: " + newPF.DataNasc);
// Console.WriteLine("Rendimento: R$ " + newPF.Rendimento); 



// imprimimos os valores do objeto
// Console.WriteLine(newPF.Nome);
// Console.WriteLine(newPF.Cpf);
// Console.WriteLine(newPF.DataNasc);
// Console.WriteLine(newPF.Rendimento);

// atalho ctrl k c 

//substring com dois argumentos
//startindex : da onde vamos partir
//lenght : quantos caracteres vamos obter
// string nome = "Pindamonhangaba"; 
// string substring = nome.Substring(3, 9); // ou nome.Substring(3) = damonhangaba //um argumento
// Console.WriteLine(substring);
