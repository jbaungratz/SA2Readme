// See https://aka.ms/new-console-template for more information


using UC12_ER7.Classes;


Console.WriteLine(@$"
==============================================================================
|                   Bem vindo ao sistema de cadastro de                      |
|                      Pessoas Físicas e Jurídicas                           |
==============================================================================
");
/*
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write("Carregando");


for (var contador = 0; contador < 20; contador++)
{
    Console.Write(". ");
    Thread.Sleep(200);
}

Console.ResetColor();
*/

BarraCarregamento("Carregando", 100);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

List<PessoaJuridica> listaPj = new List<PessoaJuridica>();



string? escolha;

do
{

Console.Clear();
Console.WriteLine(@$"

==============================================================================
|                      Escolha uma das opções a seguir                       |
|____________________________________________________________________________|
|                                                                            |
|                           1 - Pessoa Físicas                               |
|                           2 - Pessoa Jurídica                              |
|                                                                            |
|                           0 - Sair                                         |
==============================================================================
");



    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();
            
            string? escolhaPf;
            
            do
            {
                Console.Clear();
                Console.WriteLine(@$"

==============================================================================
|                      Escolha uma das opções a seguir                       |
|____________________________________________________________________________|
|                                                                            |
|                           1 - Cadastrar Pessoa Física                      |
|                           2 - Mostrar Pessoa Física                        |
|                                                                            |
|                           0 - Sair                                         |
==============================================================================
");

                escolhaPf = Console.ReadLine();
                
                switch (escolhaPf)
                {
                    case "1":

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();                      

                        /*
                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento.Ex.: DD/MM/AAAA");
                            string dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                            if (dataValida){
                                novaPf.dataNascimento = dataNasc;
                            }
                            else {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada é inválida, por favor, digite uma data válida");
                                Console.ResetColor();                            
                            }
                            
                        } while (dataValida == false);
                        */
                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.cpf = Console.ReadLine();
                        /*
                        Console.WriteLine($"Digite o rendimento mensal(digite apenas números)");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEnd.logradouro = Console.ReadLine();
                        
                        Console.WriteLine($"Digite o número.");
                        novoEnd.numero = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine($"Digite o complemento. (Aperte 'ENTER' para vazio.");
                        novoEnd.complemento = Console.ReadLine();
                        
                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        //if (endCom == "S" && endCom == "s") {
                        if (endCom == "S") {                            
                            novoEnd.endComercial = true;
                        }
                        else {
                            novoEnd.endComercial = false;
                        }
                        
                        novaPf.endereco = novoEnd;

                        //listaPf.Add(novaPf);
                        */

                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        {
                          sw.WriteLine($"{novaPf.nome}");
                          sw.WriteLine($"{novaPf.cpf}");  
                        }

                        //StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt");
                        //sw.WriteLine(novaPf.nome);
                        //sw.Close();


                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com Sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(4000);
                        break;
                    case "2":

                        Console.Clear();

                        /*
                        if (listaPf.Count > 0) {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();

                                Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                                Data de Nascimento: {cadaPessoa.dataNascimento}
                                Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")} 
                                ");
                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                            }

                        }
                        else {
                            Console.WriteLine($"Lista Vazia.");
                            Thread.Sleep(3000);
                        }
                        */

                        using (StreamReader sw = new StreamReader($"Paulo.txt"))
                        {
                            string linha;
                            while((linha = sw.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                                
                            }
                        }
                        Console.WriteLine($"Aperte 'Enter' para coontinuar.");
                        Console.ReadLine();
                        

                        break;               
                    case "0":
                        break;         
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite outra opçao.");
                        Thread.Sleep(3000);
                        Console.Clear();                    
                        break;
                }

            } while (escolhaPf != "0");

            break;
            
        case "2":

            PessoaJuridica metodoPj = new PessoaJuridica();
                        
            string? escolhaPj;
            
            do
            {
                Console.Clear();
                Console.WriteLine(@$"

==============================================================================
|                      Escolha uma das opções a seguir                       |
|____________________________________________________________________________|
|                                                                            |
|                           1 - Cadastrar Pessoa Jurídica                    |
|                           2 - Mostrar Pessoa Jurídica                      |
|                                                                            |
|                           0 - Sair                                         |
==============================================================================
");

                escolhaPj = Console.ReadLine();
                
                switch (escolhaPj)
                {
                    case "1":
                        
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();
                        
                        //metodoPj.Inserir(novaPj);

                        Console.WriteLine($"Digite a razão social da pessoa jurídica que deseja cadastrar");
                        novaPj.nome = Console.ReadLine();                      

                        bool cnpjValida;

                        do
                        {
                            Console.WriteLine($"Digite somente o número do CNJP. Ex.: 00000000000000");
                            string cnpj = Console.ReadLine();

                            cnpjValida = metodoPj.ValidarCnpj(cnpj);

                            if (cnpjValida){
                                novaPj.cnpj = cnpj;
                            }
                            else {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"CNPJ digitado é inválido, por favor, digite um CNPJ válido");
                                Console.ResetColor();                            
                            }
                            
                        } while (cnpjValida == false);

                        Console.WriteLine($"Digite o rendimento mensal(digite apenas números)");
                        novaPj.rendimento = float.Parse(Console.ReadLine());
                        /*
                        Console.WriteLine($"Digite o logradouro");
                        novoEndPj.logradouro = Console.ReadLine();
                        
                        Console.WriteLine($"Digite o número.");
                        novoEndPj.numero = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine($"Digite o complemento. (Aperte 'ENTER' para vazio.");
                        novoEndPj.complemento = Console.ReadLine();
                        
                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        //if (endCom == "S" && endCom == "s") {
                        if (endCom == "S") {                            
                            novoEndPj.endComercial = true;
                        }
                        else {
                            novoEndPj.endComercial = false;
                        }
                        */
                        metodoPj.Inserir(novaPj);

                        novaPj.endereco = novoEndPj;
                        listaPj.Add(novaPj);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com Sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(4000);
                        break;
                    case "2":

                        PessoaJuridica novaPJ = new PessoaJuridica();
                        List<PessoaJuridica> listaPJ = metodoPj.Ler();
                        /*
                        foreach(PessoaJuridica cadaItem in listaPJ)
                        
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                                Razão Social: {novaPJ.nome}
                                Endereco: {novaPJ.endereco.logradouro}, {novaPJ.endereco.numero}
                                CNPJ: {novaPJ.cnpj}
                                Rendimento: {novaPJ.rendimento}
                                Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(novaPJ.rendimento).ToString("C")}
                            ");

                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();                            
                        }
                        */
                        
                        Console.Clear();
                        if (listaPj.Count > 0) {
                            foreach (PessoaJuridica cadaPJ in listaPj)
                            {
                                Console.Clear();

                                Console.WriteLine(@$"
                                Razão Social: {cadaPJ.nome}
                                Endereco: {cadaPJ.endereco.logradouro}, {cadaPJ.endereco.numero}
                                CNPJ: {cadaPJ.cnpj}
                                Rendimento: {cadaPJ.rendimento}                                
                                Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(cadaPJ.rendimento).ToString("C")}
                                ");


                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                            }

                        }
                        else {
                            Console.WriteLine($"Lista Vazia.");
                            Thread.Sleep(3000);
                        }
                        

                        break;               

                    case "0":
                        break;         

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite outra opçao.");
                        Thread.Sleep(3000);
                        Console.Clear();                    
                        break;
                }
       


            } while (escolhaPj != "0");
            break;


        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por você utilizar nosso sistema");
            /*
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Finalizando");
            for (var contador = 0; contador < 20; contador++)
                {
                    Console.Write(". ");
                    Thread.Sleep(100);
                }
            Console.ResetColor();
            */
            BarraCarregamento("Finalizando", 300);
            break;
        default:

            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opçao.");
            Thread.Sleep(3000);
            Console.Clear();
            break;
    }

} while (escolha != "0");


static void BarraCarregamento(string texto, int tempo) {
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"{texto}");        
            for (var contador = 0; contador < 20; contador++)
                {
                    Console.Write(". ");
                    Thread.Sleep(tempo);
                }
            Console.ResetColor();
}


