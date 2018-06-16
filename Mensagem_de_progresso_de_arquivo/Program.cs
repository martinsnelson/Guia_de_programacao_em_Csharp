using System;
using Microsoft.VisualBasic.FileIO;

namespace Mensagem_de_progresso_de_arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminhoOrigem = @"C:\Users\nmartin\Downloads\origem";

            var caminhoDestino = @"C:\Users\nmartin\Downloads\destino";

            try
            {
                Console.WriteLine("Iniciando a cópia do arquivo");

                /*
                 * AllDialogs	Mostra a caixa de diálogo de progresso e qualquer caixa de 
                 * diálogo de erro
                 * 
                 * OnlyErrorDialogs	Somente mostrar caixas de diálogo de erro e ocultar as 
                 * caixas de diálogo de progresso. Padrão
                 */
                FileSystem.CopyDirectory(caminhoOrigem, caminhoDestino, UIOption.AllDialogs);
                
                /*
                 * Esse método copia o conteúdo da pasta de origem para o diretório de destino. 
                 * Se o diretório de destino não existir, ele é criado. Se um diretório com o 
                 * mesmo nome existir no local de destino, o conteúdo dos dois diretórios serão 
                 * mesclados. Você pode especificar um novo nome para o diretório durante a 
                 * operação.
                 */
                //FileSystem.CopyDirectory(caminhoOrigem, caminhoDestino, true);

                Console.WriteLine("Arquivo copiado com sucesso !");
                Console.ReadKey();
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Cópia de arquivo cancelada !");
                Console.ReadKey();
            }
            
        }
    }
}
