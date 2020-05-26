using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular iphone = new Celular();
            iphone.cor = "Branco";
            iphone.modelo = "Iphone X";
            iphone.tamanho = "Médio";
            iphone.ligado = true;
            iphone.acao = "---";
            

            Console.WriteLine(iphone.VerModelo());
            Console.WriteLine(iphone.VerCor ());
            Console.WriteLine(iphone.VerTamanho());
            Console.WriteLine(iphone.VerLigado());

            if(iphone.ligado == false){
                Console.WriteLine("Celular está desligado");
            }else{
                Console.WriteLine("O que deseja fazer? desligar, mensagem ou ligação?");
            }
            iphone.acao = Console.ReadLine();
            if(iphone.acao == "desligar"){
                Console.WriteLine("Celular Desligado");
            }else if(iphone.acao == "mensagem"){
                Console.WriteLine("Enviando Mensagem");
            }else{
                Console.WriteLine("Fazendo ligação");
            }

            
            
        }
    }
}
