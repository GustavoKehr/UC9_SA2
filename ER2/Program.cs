using ER2.Classes;

//Tipo nomeDoObjeto = metodoConstrutor();

//newPF nova pessoa fisica

//instancia do objeto do tipo pessoa fisica
//ou seja, estamos criando um objeto

PessoaFisica newPF = new PessoaFisica();

//atribuimos um valor para as propriedades da pessoa fisica
newPF.Nome = "Gustavo";
newPF.Cpf = "54698712399";
newPF.DataNasc = new DateTime(2002,10,05);
newPF.Rendimento = 1900.12f;

//impremimos no console os valores do objeto utilizando aprenas um Console.WriteLine, utilizando o @ antes do $
//o melhor
Console.WriteLine(@$"
Nome: {newPF.Nome}
CPF: {newPF.Cpf}
Data de Nascimento: {newPF.DataNasc}
Rendimento: R$ {newPF.Rendimento}
");

PessoaJuridica newPJ = new PessoaJuridica();

newPJ.Nome = "Valve";
newPJ.Cnpj = "08.057.063/0001-96";
newPJ.RazaoSocial = "VALVE CONSTRUTORA E COMERCIO LTDA";
newPJ.Rendimento = 730000000;

Console.WriteLine(@$"
Nome: {newPJ.Nome}
CNPJ: {newPJ.Cnpj}
Razão Social: {newPJ.RazaoSocial}
Rendimento: R$ {newPJ.Rendimento}
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
