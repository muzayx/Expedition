using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetinhu
{
    class Program
    {
        static void placar(Pessoa personagem)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------- PLACAR ------");
            Console.ResetColor();

            Console.WriteLine();

            Console.Write("Sua vida atual: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{personagem.Vida}");
            Console.ResetColor();

            Console.Write("Sua força atual: ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{personagem.Forca}");
            Console.ResetColor();

            Console.Write("Sua pontuação atual: ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{personagem.Pontos}");
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------");

            Console.ResetColor();
            


        }
        
        static void Main(string[] args)
        {
            
            Console.Write("Olá, este código foi realizado pela ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Adrielen");
            Console.ResetColor();

            Console.Write(" e pelo ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Gabriel");
            Console.ResetColor();

            Console.WriteLine(", esperamos que gostem  :)");

            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Bem-vindo à aventura em 1500!");
            Console.ResetColor();

            Console.WriteLine("");

            bool embarcar = false;
            while (!embarcar)
            {
                Console.Write("Você quer embarcar nesta aventura para o Brasil? (S/N) ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "S")
                {
                    embarcar = true;

                    Console.Clear();
                }
                else if (resposta == "N")
                {
                    Console.Clear();

                    Console.Write("Que pena :( Obrigado pela participação.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" Até a próxima, viajante!");

                    Console.ResetColor();
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Opção inválida!!! Por favor, responda S ou N.");

                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.Write("Você está prestes a embarcar em uma viagem inesquecível de barco até o");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Brasil.");
            Console.ResetColor();

            Console.WriteLine("");


            Console.Write("Qual é o seu nome?   ");
            string nome = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Qual é o nome que você quer dar para o seu barco?   ");
            string nomeBarco = Console.ReadLine();

            Console.Clear();
           
            Pessoa personagem = new Pessoa(nome);

            Console.WriteLine($"Bem-vindo, {personagem.Nome}. Você agora está no comando da embarcação {nomeBarco}!!!!!");

            Console.WriteLine("");

            placar(personagem);

            Console.ReadKey();
            Console.Clear();

            Console.Write("O objetivo aqui é não ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("zerar");
            Console.ResetColor();

            Console.WriteLine(" o placar");

            Console.ReadKey();
            Console.Clear();

            Console.Write("A viagem começa agora! Prepare-se para enfrentar ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("monstros");
            Console.ResetColor();

            Console.Write(" e ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("perigos");
            Console.ResetColor();

            Console.WriteLine(" que irão aparecer ao longo do caminho.");


            Console.ReadKey();
            Console.Clear();

            Console.Write("Sua vida inicial é: ");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write($"{personagem.Vida}");
            Console.ResetColor();

            Console.WriteLine(". \n" +
                "\n" +
                "Ao entrar em confronto com monstros, ela reduzirá até que você fique com 0, entao tenha cuidado!\n");
            Console.Clear();
            Console.WriteLine("Lembre-se: este é um jogo de azar.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Que a sorte esteja contigo, viajante!");
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();


            Console.Write("Você está entrando no nível mais ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("fácil");
            Console.ResetColor();

            Console.WriteLine(" do jogo\nVamos começar");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Alguns dias se passaram desde que você saiu do porto.\n");

            Console.ReadKey();
            Console.Clear();

            Console.Write("Quem diria!! " +
                "Você encontrou uma espécie ");
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Write("rara");
            Console.ResetColor();

            Console.Write(" de peixe.\nSe você conseguir pegá-lo, sua força, vida e pontos podem aumentar\n" +
                "Mas cuidado, o contrário também pode acontecer\n"+
                "Vamos tentar? (S/N)");
            string peixe = Console.ReadLine().ToUpper();
            Random random = new Random();
            int forcaPeixe = random.Next(1, 15);

            Console.Clear();

            while (peixe != "S" && peixe != "N")
            {
                Console.WriteLine("Opção inválida\n" +
                    "Escolha somente S ou N");
                peixe = Console.ReadLine().ToUpper();

                Console.Clear();
            }

            if (peixe == "S")
            {
                Console.WriteLine("Você está tentando alcançá-lo...");

                Console.ReadKey();
                Console.Clear();

                Console.Write("Sua força atual: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{personagem.Forca}");
                Console.ResetColor();

                Console.Write("Força do peixe: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{forcaPeixe}");
                Console.ResetColor();

                Console.ReadKey();
                Console.Clear();

                if (personagem.Forca >= forcaPeixe)
                {
                    Console.Write("Parabéns! Você conseguiu!!\n");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("+5 de força\n" +
                        "+10 de vida\n" +
                        "+10 pontos");
                    Console.ResetColor();

                    personagem.Forca += 5;
                    personagem.Vida += 10;
                    personagem.Pontos += 10;

                    Console.ReadKey();
                    Console.Clear();

                    placar(personagem);

                    Console.ReadKey();
                    Console.Clear();
                }
                else 
                {
                    Console.WriteLine("Infelizmente, ele conseguiu escapar :(");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-3 de força\n" +
                        "-10 de vida\n" +
                        "-10 pontos");
                    Console.ResetColor();

                    personagem.Forca -= 3;
                    personagem.ReceberDano(10);
                    personagem.Pontos -= 10;

                    Console.ReadKey();
                    Console.Clear();

                    placar(personagem);

                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else if (peixe == "N")
            {
                Console.WriteLine("Você deixou o peixinho ir embora");

                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Opção inválida");

                Console.ReadKey();
            }
            Console.Clear();

            Console.WriteLine("Que interessante! O peixinho deixou um presente para você...");

            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("É um pergaminho!");
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();

            Console.Write("Prepare-se agora para o nível ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("dois");
            Console.ResetColor();
                
            Console.WriteLine(" dessa jornada");
            
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Mas o que é isso?! Os ventos estão mudando, parece que uma tempestade se aproxima!");

            
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Você deseja enfrentar (E) a tempestade ou tentar contorná-la (C)?");
            string temp = Console.ReadLine().ToUpper();

            Console.Clear();

            while (temp != "E" && temp != "C")
            {
                Console.WriteLine("Inválido." +
                    "Escolha somente E ou C");
                temp = Console.ReadLine().ToUpper();
            }
            Console.Clear();

            Random numero = new Random();
            int intensidade = numero.Next(1, 20);
            if(temp == "E")
            {
                Console.WriteLine("Segure firme! Estamos adentrando a tempestade\n" +
                    "Será que você vai conseguir?");

                Console.ReadKey();
                Console.Clear();

                Console.Write("Sua força atual: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{personagem.Forca}");
                Console.ResetColor();

                Console.Write("Intensidade da tempestade: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {intensidade}");
                Console.ResetColor();

                Console.ReadKey();
                Console.Clear();

                if(personagem.Forca >= intensidade)
                {
                    
                    Console.WriteLine("Ufa! Essa foi por pouco, mas você passou sem levar muitos danos\n" +
                        "Porém, isso foi cansativo, portanto perdeu 5 de vida\n" +
                        "Pela sua coragem de enfrentá-la, ganhou 15 pontos");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("+15 pontos");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-5 de vida");
                    Console.ResetColor();

                    personagem.Pontos += 15;
                    personagem.ReceberDano(5); 

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Essa não! A tempestade estava tão forte que você foi ferido");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("- 20 de vida");
                    Console.WriteLine("- 20 pontos");
                    Console.ResetColor();

                    personagem.ReceberDano(20);
                    personagem.Pontos -= 20;

                    Console.ReadKey();
                    Console.Clear();

                }
            }else if(temp == "C")
            {
                Console.WriteLine("Caramba! A chuva está realmente forte\n" +
                    "Seja cuidadoso ao fazer as manobras");

                Console.ReadKey();
                Console.Clear();

               


                if (personagem.Forca>= intensidade)
                { Console.Write("Sua força atual: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{personagem.Forca}");
                    Console.ResetColor();

                    Console.Write("Intensidade da tempestade: ");
                
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {intensidade}");
                    Console.ResetColor();

                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("O mar parece estar a seu favor");

                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("Conseguiu passar pela tempestade sem se ferir, ganhe");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" +10 de vida e +15 pontos");
                    Console.ResetColor();

                    Console.Write($"Porém {nomeBarco} teve algumas de suas tábuas soltas durante a turbulência\n" +
                        "Portanto");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" -3 de força");
                    Console.ResetColor();

                    personagem.Pontos += 15;
                    personagem.Vida += 10;
                    personagem.Forca -= 3;

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Que pena! Sua embarcação teve grandes estragos, mal conseguiu passar pela chuva");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-20 pontos\n" +
                        "-20 de vida\n" +
                        "-3 de força");
                    Console.ResetColor();

                    personagem.ReceberDano(20);
                    personagem.Forca -= 3;
                    personagem.Pontos -= 20;

                    Console.ReadKey();
                    Console.Clear();
                }
            }

            placar(personagem);
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Olha só! Durante a tempestade, mais um pergaminho foi encontrado");
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();

            Console.Write("Você acaba de chegar na");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" última ");
            Console.ResetColor();
            Console.WriteLine("fase");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Durante a sua navegação, você avista algo suspeito, com uma cor mais escura do que a do mar e um tamanho nunca já visto antes, e de repente... ");

            Console.ReadKey();
            Console.Clear();

            Console.Write("Sua vida atualmente: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{personagem.Vida}");
            Console.ResetColor();

            Console.Write("Sua força atualmente: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{personagem.Forca}");
            Console.ResetColor();

            Console.WriteLine("");


           Console.WriteLine("Você encontrou uma Hydra! O que deseja fazer? \n" +
           "\n" +
           "Lutar (L)? ou fugir (F)?");
            string escolha = Console.ReadLine().ToUpper();

            Console.Clear();
            while (escolha != "L" && escolha != "F")
            {
                Console.WriteLine("Escolha somente L ou F");
                escolha = Console.ReadLine().ToUpper();
            }
            
            if (escolha.ToUpper() == "L")
                {
                    Console.WriteLine("Você está lutando contra o monstro...");

                    int valorAleatorio = random.Next(1, 10);
                    int forcaMonstro = random.Next(1, 25);

                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Sua força atual: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{personagem.Forca}");
                    Console.ResetColor();

                    Console.Write("Força da Hydra: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {forcaMonstro}");
                    Console.ResetColor();

                    Console.ReadKey();
                    Console.Clear();


                if (personagem.Forca + valorAleatorio >= forcaMonstro)
                    {

                        Console.Write("Parabéns! Você venceu essa batalha, porem teve ferimentos e sangramentos. ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" -17 de vida");
                        Console.ResetColor();
                        Console.Write("Ganhou ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("+10 de força e +20 pontos");
                        Console.ResetColor();

                        personagem.Pontos += 20;
                        personagem.Forca += 10;
                        personagem.ReceberDano(17);

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu a batalha...");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(" -30 de vida");
                        Console.WriteLine(" -30 pontos");
                        Console.WriteLine(" -15 de força");
                        Console.ResetColor();

                        Console.WriteLine("");

                        personagem.ReceberDano(30);
                        personagem.Pontos -= 30;
                        personagem.Forca -= 15;

                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (escolha.ToUpper() == "F")
                {
                    Console.WriteLine("Você está fugindo do monstro...");


                    int valorAleatorio = random.Next(1, 15);

                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Sua força atual: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{personagem.Forca}");
                    Console.ResetColor();

                    Console.Write("Força do Hydra: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {valorAleatorio}");
                    Console.ResetColor();

                    Console.ReadKey();
                    Console.Clear();

                if (valorAleatorio <= personagem.Forca)
                    {
                        Console.WriteLine("Por pouco!!! Mas conseguiu fugir com leves danos no bumbum. ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("-6 de vida");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("+20 pontos");
                        Console.ResetColor();

                        personagem.Pontos += 20;
                        personagem.ReceberDano(6);

                        Console.ReadKey();

                        Console.Clear();

                    }

                    else
                    {
                        Console.WriteLine("Você foi pego pelo monstro tentando escapar... ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-30 de vida");
                        Console.WriteLine("-30 pontos");
                        Console.WriteLine("-15 de força");
                        Console.ResetColor();

                        personagem.ReceberDano(30);
                        personagem.Forca -= 15;
                        personagem.Pontos -= 30;

                        Console.ReadKey();

                        Console.Clear();


                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida!!!!!!! apenas (L) ou (F)");
                    Console.ResetColor();

                    Console.ReadKey(); 

                    Console.Clear();
                }
            placar(personagem);


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Parece que o monstro esqueceu alguma coisa...");


            Console.ReadKey();
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("É seu terceiro pergaminho!");
            Console.ResetColor();


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Você passou pela batalha");

            Console.WriteLine("");

            Console.WriteLine("E conseguiu resgatar alguns pergaminhos pelo caminho!");

            Console.ReadKey();
            Console.Clear();



            Console.Write("No total, você resgatou ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write("3");

            Console.ResetColor();

            Console.WriteLine(" pergaminhos.");

            Console.ReadKey();
            Console.Clear();


            // Cria objeto da classe Pergaminhos
            Pergaminhos pergaminhos = new Pergaminhos();


            // Loop para permitir que o usuário leia mais de um pergaminho
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Escolha um pergaminho para ler:");
                Console.WriteLine();

                Console.WriteLine("1. Pergaminho 1");
                Console.WriteLine("2. Pergaminho 2");
                Console.WriteLine("3. Pergaminho 3");
                Console.WriteLine("4. Prosseguir para as perguntas");

                string escolhaP = Console.ReadLine();

                int indicePergaminho;

                bool indiceValido = Int32.TryParse(escolhaP, out indicePergaminho);

                if (indiceValido && indicePergaminho >= 1 && indicePergaminho <= 3)
                {
                    Console.Clear();
                    
                    Console.WriteLine(pergaminhos.LerPergaminho(indicePergaminho - 1));

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (escolhaP == "4")
                {
                    continuar = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Escolha inválida. Digite qualquer tecla para adicionar um novo valor!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }

            }


            Console.Clear();


            Console.WriteLine("Agora que todos os pergaminhos foram lidos e revisados, testaremos o seu conhecimento.");
            Console.ReadKey();
            Console.Clear();



            Console.WriteLine("Aqui estão as perguntas que você precisa responder (apenas em números) para completar a sua jornada:");

            Console.WriteLine("");

            Console.WriteLine("(1): Com quantos anos Pedro Álvares Cabral morreu?");

            Console.WriteLine("");

            Console.WriteLine("(2): Em que ano o Brasil foi descoberto?");

            Console.WriteLine("");

            Console.WriteLine("(3): Quantos dias Cabral demorou para que chegasse ao Brasil?");

            Console.WriteLine("");

            int acertos = 0;
            int erros = 0;

            for (int i = 1; i <= 3; i++)
            {
                bool respostaValida = false;

                    Console.Write($"Pergunta {i}: ");
                    string resposta = Console.ReadLine();

                    if (i == 1 && resposta.ToUpper() == "53")
                    {
                        respostaValida = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correto!");
                    Console.ResetColor();

                    acertos++;
                    personagem.Pontos+=4;

                    }

                    else if (i == 2 && resposta.ToUpper() == "1500")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correto!");
                        Console.ResetColor();
                        respostaValida = true;

                        acertos++;
                        personagem.Pontos += 4;
                }

                    else if (i == 3 && resposta.ToUpper() == "44")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correto!");
                        Console.ResetColor();

                        respostaValida = true;
                        acertos++;
                        personagem.Pontos += 4;
                }
                    else
                    {
                        respostaValida = false;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Incorreto. Boa tentativa.");       

                        Console.ResetColor();
                        erros++;
                    }
            }

            Console.ReadKey();
            Console.Clear();


            Console.Write("Total de acertos");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {acertos}/3");
            Console.ResetColor();

            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------- PLACAR FINAL ------");
            Console.ResetColor();

            Console.WriteLine();

            Console.Write("Sua vida atual: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{personagem.Vida}");
            Console.ResetColor();

            Console.Write("Sua força atual: ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{personagem.Forca}");
            Console.ResetColor();

            Console.Write("Sua pontuação atual: ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{personagem.Pontos}");
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------");

            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            if(personagem.Pontos >= 50)
            {
                Console.WriteLine("Você atingiu o número necessário de pontos para desbloquear um prêmio!");

                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Parabéns! Você ganhou uma casa para desfrutar sua estadia no Brasil");
                Console.ResetColor();
                Console.WriteLine("             ____");
                Console.WriteLine("            |____| ");
                Console.WriteLine("  ___________|__|__");
                Console.WriteLine("  |               | ");
                Console.WriteLine("  |  []       []  | ");
                Console.WriteLine("  |               | ");
                Console.WriteLine("  |      |¨¨|     | ");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Parabéns! Você concluiu a sua aventura em 1500 e está pronto para desembarcar no Brasil!\n" +

               "\n" +
               $"Boa sorte na sua jornada, {personagem.Nome}. Até a próxima!");
                Console.ReadKey();

            }

            else

            {

                Console.WriteLine("Poxa :( Infelizmente você não atingiu os pontos necessários para ganhar o prêmio! Mas não fique triste. \n" +
                    $"Você pode tentar novamente, nos vemos por ai {personagem.Nome}!");
                Console.ReadKey();
            }
           

        }
    }
}
