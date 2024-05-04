Console.Clear();

const string senhaCorreta = "1234abcd";
string senhaGeral; 

Console.Write("ola usuario, digite sua senha: ");
senhaGeral = Console.ReadLine()!;

if(senhaGeral == senhaCorreta)
{
    Console.WriteLine("Acesso permitido");
}
else
{
    Console.WriteLine("Acesso negado");
}

