using System.Globalization;
using System.Text.RegularExpressions;
using ER4.Classes;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine(@$"
=========================================
|  Bem vindo ao sistema de cadastro de  |
|      Pessoas Físicas e Jurídicas      |
=========================================");

Thread.Sleep(2500);

Console.ResetColor();

Console.Clear();

Utils.BarraCarregamento("Sistema iniciando", 300, 6);

Thread.Sleep(300);
Console.Clear();

string opcao;

do
{
    Console.ForegroundColor = ConsoleColor.White;

    
Console.WriteLine(@$"
=========================================
|     Escolha uma das opções abaixo     |
|---------------------------------------|
| 1 - Pessoa Física                     |
| 2 - Pessoa Jurídica                   |
|                                       |
| 0 - Sair                              |
=========================================");
    Console.ResetColor();

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

        string opcaopf;

            do
            {
                Console.WriteLine(@"
=========================================
|     Escolha uma das opções abaixo     |
|---------------------------------------|
| 1 - Cadastrar pessoa Física           |
| 2 - Listar Pessoas Físicas            |
|                                       |
| 0 - Voltar ao menu anterior           |
=========================================");

            opcaopf = Console.ReadLine();

            PessoaFisica metodosPF = new PessoaFisica();

            PessoaFisica newPF = new PessoaFisica();

            switch (opcaopf)
            
                {
                    case "1":
                    
                        

                        Endereco newEndereco = new Endereco();
                        
                        


                        Console.WriteLine("Digite o nome do cadastrante: ");
                        newPF.Nome = Console.ReadLine();
                        Console.Clear();
                        
                        Console.WriteLine("Digite o CPF do cadastrante: ");        
                        newPF.Cpf = Console.ReadLine();
                        
                        Console.Clear();
                    
                        bool dataValida;

                        do
                        {
                        Console.WriteLine("Digite a data de nascimento do cadastrante DD/MM/AAAA: ");

                        string datanascimento = Console.ReadLine();

                        dataValida = metodosPF.ValidarDataNasc(datanascimento);

                            if (dataValida)
                            {
                                DateTime dataConvertida;

                                DateTime.TryParse(datanascimento, out dataConvertida);

                                newPF.DataNascimento = datanascimento;
                            }
                            else
                            {
                                Console.WriteLine("Data inválida, por favor insira novamente a data de nascimento no formato correto DD/MM/AAAA");
                                
                            }
                        } while (dataValida == false);
                        Console.Clear();

                        Console.WriteLine("Ditite o rendimento mensal do cadastrante: (Somente numeros)");
                        newPF.Rendimento = float.Parse(Console.ReadLine());
                        Console.Clear();
                        
                        Console.WriteLine("Digite o logradouro ");
                        newEndereco.Logradouro = Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine($"Digite o bairro da sua residencia: ");
                        newEndereco.Bairro = Console.ReadLine();
                        Console.Clear();
                        
                        Console.WriteLine("Digite o número da sua residência: ");
                        newEndereco.Numero = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine($"Digite a sua unidade deferal ex: SP, RJ, ES... : ");
                        newEndereco.Uf = Console.ReadLine();
                        Console.Clear();
                        
                        Console.WriteLine($"Digite seu CEP: ");
                        newEndereco.Cep = Console.ReadLine();
                        Console.Clear();
                        
                        Console.WriteLine($"Digite o nome de seu país: ");
                        newEndereco.Pais = Console.ReadLine();
                        Console.Clear();
                        
                        Console.WriteLine($"Este endereço é comercial? (S) para sim ou (N) para não: ");

                        string endComercial = Console.ReadLine().ToUpper();

                        if (endComercial == "S")
                        {
                            newEndereco.Comercial = true;
                        }
                        else
                        {
                            newEndereco.Comercial = false;
                        }
                        
                        newPF.Endereco = newEndereco;
                        
                        

                        metodosPF.Inserir(newPF);
        
                        Utils.BarraCarregamento("Cadastro realizado com sucesso", 800, 5);
                        Console.Clear();
                        Thread.Sleep(800);
                        Console.ResetColor();
                        break;

                    case "2":
                        
                        List<PessoaFisica> listaaPF = metodosPF.LerArqPF();

                        foreach (PessoaFisica cadaItem in listaaPF)
                        {
                            Console.WriteLine(@$"
                            Nome: {cadaItem.Nome}
                            CPF: {cadaItem.Cpf}
                            Data de Nascimento: {cadaItem.DataNascimento}
                            ");
                            Console.WriteLine($"Aperte ENTER para continuar");
                            Console.ReadLine();                        
                        }
                            if (listaaPF.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Esta lista está vazia");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }
                        break;
                    case "0":
                        break;
                    default: Console.WriteLine("Opção inválida, retorne e digite o número corretamente");
                        break;
                    }

            } while (opcaopf != "0");

            Console.ResetColor();
            Console.Clear();  
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Aperte a tecla ENTER para continuar");
            Console.ReadLine();
            break; 

    case "2": 

            PessoaJuridica metodosPJ = new PessoaJuridica();

            string opcaopj;

            bool cnpjValido;
            
            do
            {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
=========================================
|     Escolha uma das opções abaixo     |
|---------------------------------------|
| 1 - Cadastrar pessoa Jurídica         |
| 2 - Listar Pessoas Jurídicas          |
|                                       |
| 0 - Voltar ao menu anterior           |
=========================================");
            Console.ResetColor();

            opcaopj = Console.ReadLine();
            

                switch (opcaopj)
                {
                    case "1": 
                    PessoaJuridica newPJ = new PessoaJuridica();
                    Endereco newEnderecoPJ = new Endereco();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ResetColor();

                    Console.WriteLine($"Ditite o nome que deseja cadastrar: ");
                    newPJ.Nome = Console.ReadLine();

                    Console.WriteLine($"Digite sua Razão Social: ");
                    newPJ.RazaoSocial = Console.ReadLine();
                    
                    Console.WriteLine($"Digite o numero do cnpj: ");
                    newPJ.Cnpj = Console.ReadLine();
                    
                    cnpjValido = metodosPJ.ValidarCnpj(newPJ.Cnpj);
                    Console.WriteLine(cnpjValido);
                    
                    Console.WriteLine($"Digite seu Rendimento mensal (Somente Numeros): ");
                    newPJ.Rendimento = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o logradouro: ");
                    newEnderecoPJ.Logradouro =  Console.ReadLine();

                    Console.WriteLine($"Digite o bairro: ");
                    newEnderecoPJ.Bairro = Console.ReadLine();

                    Console.WriteLine($"Digite o Número: ");
                    newEnderecoPJ.Numero =  int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite a UF ex: SP, RJ, SC");
                    newEnderecoPJ.Uf = Console.ReadLine();
                    
                    Console.WriteLine($"Digite o CEP: ");
                    newEnderecoPJ.Cep = Console.ReadLine();

                    Console.WriteLine($"Digite o país: ");
                    newEnderecoPJ.Pais = Console.ReadLine();
                    
                    Console.WriteLine($"Este endereço é comercial? digite (S) para sim e (N) para não");
                    
                    string endCom = Console.ReadLine().ToUpper();

                    if (endCom == "S")
                    {
                    newEnderecoPJ.Comercial = true;
                    }
                    else
                    {
                    newEnderecoPJ.Comercial = false;
                    }
                    newPJ.Endereco = newEnderecoPJ;

                    metodosPJ.Inserir(newPJ);

                    Utils.BarraCarregamento("Cadastro realizado com sucesso", 800, 5);
                    Console.Clear();
                    Thread.Sleep(800);
                    Console.ResetColor();
                    break;

                    case "2":

                        List<PessoaJuridica> listaaPJ = metodosPJ.LerArqPJ();

                    foreach (PessoaJuridica cadaItem in listaaPJ)
                    {
                        Console.WriteLine(@$"
                        Nome Fantasia: {cadaItem.Nome}
                        CNPJ: {cadaItem.RazaoSocial}
                        Razão Social: {cadaItem.Cnpj}
                        ");
                        Console.WriteLine($"Aperte ENTER para continuar");
                        Console.ReadLine();                        
                    }
                        if (listaaPJ.Count == 0)
                        {   
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Esta lista está vazia");
                            Console.ResetColor();
                            Thread.Sleep(3000);
                        }
                        break;
                    case "0":
                        break;
                    default: Console.WriteLine($"Opção inválida, por favor digite outra opção");
                    break;
                }
            } while (opcaopj != "0");
            
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            break; 

            case "0":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigado por utilizar nosso sistema !");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida, escolha outra opção !");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");

Utils.BarraCarregamento("Finalizando", 300, 10);
