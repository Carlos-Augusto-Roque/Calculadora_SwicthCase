using System;

namespace Calculadora_SwicthCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lógica
            //pedir a operação
            //pedir o 1° número
            //pedir o 2° número
            //processar os dados
            //exibir o resultado

            //Entrada dos dados

            Console.WriteLine("Calculadora"); //Mensagem "calculadora"

            Console.WriteLine("Digite a operação que deseja efetuar");//Mensagem "digite a operação.."
            string operacao = Console.ReadLine();//entrada da operação ,string como texto e armazenar a operação

            Console.WriteLine("Entre com o 1° Número");//Mensagem "Entre com o 1° Número
            float num1 = float.Parse(Console.ReadLine());//float num1 = variável do tipo float (número quebrado) / float.Parse = transformar string em float
            
            Console.WriteLine("Entre com o 2° Número");//Mensagem "Entre com o 2° Número
            float num2 = float.Parse(Console.ReadLine());//float num2 = variável do tipo float (número quebrado) / float.Parse = transformar string em float

            float resultado = 0; // float resultado = variável do tipo float (número quebrado)


            //Processamento
            //Swicht / Case --- forma para descrever várias condicionais SE,substitui o (If - Else) 

            switch(operacao){//condicional switch para a variável operacao

                case "Soma"://caso for digitado "Soma"
                resultado = num1+num2;//o resultado será num1+num2
                break;//quebrar

                case "Subtracao"://caso for digitado "Subtracao"
                resultado = num1-num2;//resultado será num1-num2
                break;//quebrar

                case "Multiplicacao"://caso for digitado "Multiplicacao"
                resultado = num1*num2;//resultado será num1*num2
                break;//quebrar

                case "Divisao"://caso for digitado "Divisao"
                resultado = num1/num2;//resultado será num1/num2
                break;//quebrar

                default://se a operacao digitada não for nenhuma das operacoes acima,então
                Console.WriteLine("Operação Inválida !");//Mensagem "Operação Inválida"
                break;//quebrar
            }
            //Exibição do Resultado
            //Interpolação
            Console.WriteLine($"Cálculo: {num1} e {num2} = Resultado : {resultado}");//exibição da mensagem "Cálculo: 1°Número e 2° Número = Resultado
        }
    }
}
