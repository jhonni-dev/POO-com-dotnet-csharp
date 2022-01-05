using exemplopoo.Helper;
using exemplopoo.Interfaces;
using exemplopoo.models;
namespace exemplopoo
{
    class Program
    {
        static void Main (string[] args)

        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "PastaTeste1");
            var caminhoArquivo = Path.Combine(caminho,"arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho,"arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho,"arquivo-teste-backup.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste2", "arquivo-teste-stream-renomeado.txt");

            var listraString = new List<string> { "linha 1", "linha 2", "linha 3" };
            var listraStringContinuacao = new List<string> { "linha 4", "linha 5", "linha 6" };

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //System.Console.WriteLine("Criando diretório "+caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listraString);
            //helper.AdicionarTextoStream(caminhoArquivo, listraStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            //Sobrecarga de métodos (Early Biding)
            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma é " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma é " + calc.Somar(10, 10, 10));

            // Sobrescrita de métodos (Late Binding)
            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento = 123456;
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "George";
            // p2.Idade = 40;
            // p2.Documento = 456789;
            // p2.Salario = 2000;
            // p2.Apresentar();

            // Valores validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // r.ObterArea();

            // Console.WriteLine($"Área: {r.ObterArea()}");
            // Console.WriteLine();

            // // Valores Inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(-1, -1);
            // r2.ObterArea();

            // Console.WriteLine("Área: Não foi possível calcular a área");



            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}