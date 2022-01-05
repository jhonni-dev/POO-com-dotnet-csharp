namespace exemplopoo.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*", SearchOption.AllDirectories);
            
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho)){ // Testa se o arquivo não existe
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo) // Append text sem stream
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoStream(string caminho, List<string> conteudo) // Append text com stream
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
       }

       public void LerArquivo(string caminho) // Ler arquivo sem stream
       {
           var conteudo = File.ReadAllLines(caminho);

           foreach (var linha in conteudo)
           {
               System.Console.WriteLine(linha);
           }
       }

       /*public void LerArquivoStream(string caminho) // Ler arquivo com stream
       {
           string linha = string.Empty;
           using (var stream = File.OpenText(caminho))
           {
               while ((linha = stream.ReadLine()) != null)
               {
                    System.Console.WriteLine(linha);
               }
           }
       }*/

       public void MoverArquivo(string caminho, string novoCaminho)
       {
           File.Move(caminho, novoCaminho);
       }

       public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
       {
           File.Copy(caminho, novoCaminho, true);
       }

       public void DeletarArquivo(string caminho)
       {
           File.Delete(caminho);
       }
    }
}