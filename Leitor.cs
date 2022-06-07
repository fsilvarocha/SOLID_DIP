using SOLID_DIP.Interface;

namespace SOLID_DIP
{
    public class Leitor
    {
        private readonly ILeitorArquivo _leitor;

        public Leitor(ILeitorArquivo leitor)
        {
            _leitor = leitor;
        }

        public void Ler()
        {
            _leitor.Ler("caminho qualquer");
        }
    }
}