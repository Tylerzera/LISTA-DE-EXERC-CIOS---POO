using Disciplina;
Console.Clear();
Console.WriteLine("exericicio1");
Aluno aluno = new Aluno();
aluno.ReceberDados();
aluno.CalcularMedia();
aluno.CalcularNotaFinal();
aluno.ImprimirNotaFinal();

Console.Clear();
Console.WriteLine("exercicio2");
Calculadora calculadora = new Calculadora();
calculadora.ExecutarCalculadora();

Console.Clear();
Console.WriteLine("exercicio3");
ManipularArquivo manipulador = new ManipularArquivo();
manipulador.Conteudo = "ryan luciano de oliveira e silva";
manipulador.EnderecoNomeArquivo = @"C:\Users\043413\Desktop\novapasta\teste.txt"; // mude sempre o diretório
if (manipulador.SalvarDadosEArquivo())
    Console.WriteLine("Arquivo salvo com sucesso!");
else
    Console.WriteLine("Houve algum problema ao salvar o arquivo!");

Console.WriteLine(manipulador.PesquisarConteudoArquivo(manipulador.EnderecoNomeArquivo));

Console.Clear();
Console.WriteLine("exercicio4");
Console.Write("Quantidade de Alunos: ");
int quatidade_de_alunos = int.Parse(Console.ReadLine());
Aluno[] alunos = new Aluno[quatidade_de_alunos];

for(int i = 0; i < quatidade_de_alunos; i++){
    Console.Clear();
    alunos[i] = new Aluno();
    Console.WriteLine($"Aluno {i+1} de {quatidade_de_alunos}");
    alunos[i].ReceberDados();
    alunos[i].CalcularMedia();
}
Console.Clear();
foreach(Aluno a in alunos){
    a.ImprimirNotaFinal();
}