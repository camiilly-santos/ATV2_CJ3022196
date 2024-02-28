float salario;

//Leitura do salário
Console.WriteLine("Entre com um salário");


salario = float.Parse (Console.ReadLine());

salario = salario + (float) (25 / 100) * salario;

Console.WriteLine("O novo salário é R$ {0} ", salario);






