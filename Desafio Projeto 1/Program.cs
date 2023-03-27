using System.Text;
using Desafio_Projeto_1.models;

Console.OutputEncoding = Encoding.UTF8;


List<Pessoa> hospedes = new List<Pessoa>();


//------------------------------------------------------------------------------------------

int opcao=0;
String nome="";
String sobrenome="";
String tipoSuite="";
String nomeCompleto="";
int capacidade=0;
decimal valorDiaria=0;
int diasReservados=0;
int i=0;

Reserva reserva= new Reserva();
Suite suite=new Suite();

do{
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1- Cadastrar hospedes");
    Console.WriteLine("2- Escolher Suíte");
    Console.WriteLine("3- Reservar Suíte");
    Console.WriteLine("4- Obter Quantidade de Hóspedes na Suíte");
    Console.WriteLine("5- Exibir o valor da diária");
    Console.WriteLine("0- Sair");
    Console.WriteLine("--------------------------------------");

    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao){
        case 1: // Cria os modelos de hóspedes e cadastra na lista de hóspedes
            hospedes.Clear();

            Console.Write("Digite a quantidade de hospedes que deseja cadastrar: ");
            int qnt=int.Parse(Console.ReadLine());
            i=0;
            while(i<qnt){
                Console.Write("Digite o primeiro nome: ");
                nome= Console.ReadLine();

                Console.Write("Digite o Sobrenome: ");
                sobrenome= Console.ReadLine();

                Pessoa p = new Pessoa(nome, sobrenome);
                hospedes.Add(p);

                Console.WriteLine($"\nHóspede {p.NomeCompleto} cadastrado com sucesso!!\n");

                i++;
            }

            break;
            
        case 2: // Cria a suíte

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Escolha uma opção de Suite:");
            Console.WriteLine("1- Premium; Capacidade: 5; Valor da Diária: R$150,00");
            Console.WriteLine("2- Básica; Capacidade: 2; Valor da Diária: R$50,00");
            Console.WriteLine("--------------------------------------");

            String opcao2= Console.ReadLine();

            if(opcao2=="1"){
                suite.TipoSuite="Premium";
                suite.Capacidade=5;
                suite.ValorDiaria=150.00M;

                
                
            }else if(opcao2=="2"){
                suite.TipoSuite="Básica";
                suite.Capacidade=2;
                suite.ValorDiaria=50.00M;
                
            }

            reserva.CadastrarSuite(suite);
            Console.WriteLine($"\nSuíte {suite.TipoSuite} cadastrada com sucesso!!\n");

            break;

        case 3:// Cria uma nova reserva, passando a suíte e os hóspedes
                Console.Write("Digite a quantidade de dias reservados para a suíte: ");
                diasReservados= Convert.ToInt32(Console.ReadLine());
                reserva.DiasReservados=diasReservados;

             
                reserva.CadastrarHospedes(suite, hospedes);
              
            break;

        case 4: //Obter a quantidade de Hospedes
           
            reserva.ObterQuantidadeHospedes();
            break;

        case 5://Calcular o valor da diaria de acordo com a quantidade de dias
           
            reserva.CalcularValorDiaria(suite);
            break;


    }

}while(opcao!=0);

