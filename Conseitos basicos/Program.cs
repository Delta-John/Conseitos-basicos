try
{

}

  catch (Exception e)
{

}

 Console.WriteLine("Informe seu nome");
 string nome = Console.ReadLine();
 Console.WriteLine("Informe seu salario");
 decimal salario = decimal.Parse(Console.ReadLine());
 Console.WriteLine("Seja bem vindo(a) {0}, o salario informado foi {1}", nome, salario);

//INFORME O VALOR DO IRPF A SER PAGO DE ACORDO COM SALARIO INFORMADO. UTILIZE A TABELA DE ACORDO COM IRPF

    decimal irpfDevido;
 if (salario == 2259.20m)
    irpfDevido = 0;
 else if (salario <= 2826.65m)
    irpfDevido = salario * 0.75m - 169.21m;
 else if (salario <= 3751.05m)
    irpfDevido = salario * 0.15m - 381.44m;
 else if (salario <= 4664.68m)
    irpfDevido = salario * 0.225m - 662.77m;
 else
    irpfDevido = salario * 0.275m - 896m;

Console.WriteLine($"Para o salario de {salario} o valor a ser pago de IRPF e {irpfDevido}, então o salario com desconto de IRPF sera {salario - irpfDevido}");

  
  catch (FormatException)
 {
        Console.WriteLine("O salario deve ser informado em formato numerico");
   }
  catch (Exception e)
 {
    Console.WriteLine("Ocoreu um erro. Contate e suporte tecnico");
    Console.WriteLine(e.StackTrace);
 }
