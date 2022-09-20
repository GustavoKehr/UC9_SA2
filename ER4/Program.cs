using System.Globalization;
using ER4.Classes;

Endereco newEndereco = new Endereco();

newEndereco.Logradouro = "Rua Deodato Wertheim";
newEndereco.Bairro = "Vila Mogilar";
newEndereco.Numero = 19;
newEndereco.Uf = "SP";
newEndereco.Cep = "08773-090";
newEndereco.Pais = "Brasil";
newEndereco.Comercial = true;

Endereco newEnderecoPJ = new Endereco();

newEnderecoPJ.Logradouro = "Bellevue Way NE";
newEnderecoPJ.Bairro = "Bellevue";
newEnderecoPJ.Numero = 575;
newEnderecoPJ.Uf = "WA";
newEnderecoPJ.Cep = "98004";
newEnderecoPJ.Pais = "Estados Unidos";
newEnderecoPJ.Comercial = true;

PessoaFisica newPF = new PessoaFisica();

newPF.Nome = "Gustavo";
newPF.Cpf = "54698712399";
newPF.DataNasc = new DateTime(2002,10,05);
newPF.Rendimento = 1900.12f;
newPF.Endereco = newEndereco;

PessoaFisica metodosPF = new PessoaFisica();

Console.WriteLine(@$"
Nome: {newPF.Nome}
CPF: {newPF.Cpf}
Data de Nascimento: {newPF.DataNasc}
Rendimento: R$ {newPF.Rendimento}
Endereco: {newPF.Endereco.Logradouro}, {newPF.Endereco.Bairro}, {newPF.Endereco.Numero}, {newPF.Endereco.Uf}, {newPF.Endereco.Cep}
Maior de idade?: {(metodosPF.ValidarDataNasc(newPF.DataNasc) ? "Sim" : "Não")}
Impostos á pagar : {metodosPF.PagarImposto(newPF.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
");

PessoaJuridica newPJ = new PessoaJuridica();

newPJ.Nome = "Valve";
newPJ.Cnpj = "08057063000196";
newPJ.RazaoSocial = "VALVE CONSTRUTORA E COMERCIO LTDA";
newPJ.Rendimento = 730000000;
newPJ.Endereco = newEnderecoPJ;

PessoaJuridica metodosPJ = new PessoaJuridica();

Console.WriteLine(@$"
Nome: {newPJ.Nome}
CNPJ: {newPJ.Cnpj}
Razão Social: {newPJ.RazaoSocial}
Rendimento: R$ {newPJ.Rendimento}
Endereco: {newPJ.Endereco.Logradouro}, {newPJ.Endereco.Bairro}, {newPJ.Endereco.Numero}, {newPJ.Endereco.Uf}, {newPJ.Endereco.Cep}
Cnpj válido?: {(metodosPJ.ValidarCnpj(newPJ.Cnpj) ? "Sim" : "Não")}
Imposto á pagar :  {metodosPJ.PagarImposto(newPJ.Rendimento).ToString("C", new CultureInfo("pt-BR"))} 
");
