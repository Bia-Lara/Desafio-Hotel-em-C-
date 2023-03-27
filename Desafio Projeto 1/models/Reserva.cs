using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Projeto_1.models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite suite{ get; set; }
        public int DiasReservados { get; set; }
        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(Suite suite, List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (hospedes.Count > suite.Capacidade){
                Console.WriteLine("O número de hóspedes é maior que a capacidade da suíte reservada!!");
            }
            else{
                
                if(Hospedes!=null){
                    Hospedes.Clear();

                    foreach(Pessoa p in hospedes){
                        Hospedes.Add(p);
                    }
                }else if(Hospedes==null){
                     Hospedes=new List<Pessoa>();
                     
                     foreach(Pessoa p in hospedes){
                        Hospedes.Add(p);
    
                }

               
            }

            Console.WriteLine($"\nReserva Efetuada com sucesso!!\n");
        }

    }

        public void CadastrarSuite(Suite suitee)
        {
            suite= suitee;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*

           
            Console.WriteLine($"Quantidade de hospedes: {Hospedes.Count}");
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria(Suite suite)
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados*suite.ValorDiaria;
            decimal porcentagem= 10/100M;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados>=10)
            {
                decimal desconto= valor*porcentagem;
                valor = valor - desconto;
            }
            Console.WriteLine($"Valor da suíte durante {DiasReservados} dias: {valor.ToString("0.00")}");
            return valor;
        }
    }
}