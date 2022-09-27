using System.Globalization;
using System.Text.RegularExpressions;
using ER4.Classes;


//Tipo nomeDoObjeto = metodoConstrutor();

//newPF nova pessoa fisica

//instancia do objeto do tipo pessoa fisica
//ou seja, estamos criando um objeto

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

Endereco newEnderecoPJ = new Endereco();

newEnderecoPJ.Logradouro = "Nepperhan Avenue";
newEnderecoPJ.Bairro = "Yonkers";
newEnderecoPJ.Numero = 700;
newEnderecoPJ.Uf = "NY";
newEnderecoPJ.Cep = "10703";
newEnderecoPJ.Pais = "Estados Unidos";
newEnderecoPJ.Comercial = true;

PessoaFisica newPF = new PessoaFisica();

//atribuimos um valor para as propriedades da pessoa fisica
newPF.Nome = "Gustavo";
newPF.Cpf = "54698712399";
newPF.DataNasc = new DateTime(2002,10,05);
newPF.DataNascimento = "10/05/2002";
newPF.Rendimento = 1900.12f;
newPF.Endereco = newEndereco;

//usamos para manipular os metodos

PessoaFisica metodosPF = new PessoaFisica();

//impremimos no console os valores do objeto utilizando aprenas um Console.WriteLine, utilizando o @ antes do $
//o melhor

//string data = "16/05/2000";
//bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
//Console.WriteLine(valido ? "Sim" : "Não, insira novamente uma data");
//Data de Nascimento válida? {(metodosPF.ValidarDataNasc(newPF.DataNasc) ? "Sim" : "Não, insira novamente uma data");}

Console.WriteLine(@$"
Nome: {newPF.Nome}
CPF: {newPF.Cpf}
Data de Nascimento: {newPF.DataNasc}
Rendimento: R$ {newPF.Rendimento}
Endereco: {newPF.Endereco.Logradouro}, {newPF.Endereco.Bairro}, {newPF.Endereco.Numero}, {newPF.Endereco.Uf}, {newPF.Endereco.Cep}
Data de nascimento válida?: {(metodosPF.ValidarDataNasc(newPF.DataNascimento) ? "Sim" : "Não, insira novamente a data")}
Maior de idade?: {(metodosPF.ValidarDataNasc(newPF.DataNasc) ? "Sim" : "Não")}
Impostos á pagar : {metodosPF.PagarImposto(newPF.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
");
//outros meios de verificacao de idade, porem sem dizer se sim ou nao, ou o que colocar entre parenteses
//Maior de idade?: {metodosPF.ValidarDataNasc(newPF.DataNasc)}
// Maior de idade? - string : {metodosPF.ValidarDataNasc("10/05/2002")}

PessoaJuridica newPJ = new PessoaJuridica();

newPJ.Nome = "Valve";
newPJ.Cnpj = "05743368000163";
newPJ.RazaoSocial = "PRECISION VALVE CORPORATION";
newPJ.Rendimento = 730000000;
newPJ.Endereco = newEnderecoPJ;

PessoaJuridica metodosPJ = new PessoaJuridica();


Console.WriteLine(@$"
Nome: {newPJ.Nome}
CNPJ: {newPJ.Cnpj}
Razão Social: {newPJ.RazaoSocial}
Rendimento: R$ {newPJ.Rendimento}
Endereco: {newPJ.Endereco.Logradouro}, {newPJ.Endereco.Bairro}, {newPJ.Endereco.Numero}, {newPJ.Endereco.Uf}, {newPJ.Endereco.Cep}
Cpnj válido?: {(metodosPJ.ValidarCnpj(newPJ.Cnpj) ? "Sim" : "Não, insira novamente um novo cnpj")}
Imposto á pagar :  {metodosPJ.PagarImposto(newPJ.Rendimento).ToString("C", new CultureInfo("pt-BR"))} 
");





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
