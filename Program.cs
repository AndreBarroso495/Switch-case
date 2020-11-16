using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir a operacao
            //pedir o 1° numero
            //pedir o 2° numero

            Console.WriteLine("digite a operacao que deseja fazer \n Soma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();
            
            Console.WriteLine("Digite o 1º numero");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º numero");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = 0;

            //if else padrão
            //if(operacao == "soma"){
                //resultado = num1 + num2;
            
            //}else if(operacao == "subtracao"){
                //resultado = num1 - num2;
            
            //}else if (operacao == "Divisao"){
                //resultado = num1 / num2;
                
            //}else if (operacao == "Multiplicacao"){
                //resultado = num1 * num2;

            //}else{
                //Console.WriteLine("Operacao invalida");
                //}

            //Switch / Case
            switch(operacao){

                case "Soma":
                resultado = num1+num2;
                break;
                
                case "Subtracao":
                resultado = num1-num2;
                break;
                
                case "Multiplicacao":
                resultado = num1*num2;
                break;
                
                case "Divisao":
                resultado = num1/num2;
                break;

                default:
                Console.WriteLine("Operação inválida");
                break;

            }
            //Concatenação
            //Console.WriteLine("Calculo :"+num1+" e "+num2+" = Resultado : "+resultado);

            //Interolação
            Console.WriteLine($"Calculo: {num1} e {num2} = Resultado : {resultado}");


           

            


          


        }
    }
}
