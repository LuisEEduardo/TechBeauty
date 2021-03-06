using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ContatoRepositorio
    {
        public List<Contato> TabelaContato { get; private set; } = new List<Contato>();
        

        public ContatoRepositorio(List<TipoContato> tiposContato)
        {
            PreencherDados(tiposContato);
        }

        public void Incluir(Contato contato)
        {
            TabelaContato.Add(contato);
        }

        public void Alterar(int id, TipoContato tipo, string valor)
        {
            TabelaContato.FirstOrDefault(x => x.Id == id).AlterarContato(tipo, valor);
        }

        public Contato SelecionarPorId(int id)
        {
            return TabelaContato.FirstOrDefault(x => x.Id == id); 
        }

        public void Excluir(int id)
        {
            TabelaContato.Remove(SelecionarPorId(id));
        }

        private void PreencherDados(List<TipoContato> tiposContato)
        {
            // select top(1) * from TipoContato Where id = 1
            var tipoContato1 = tiposContato.Where(x => x.Id == 1).FirstOrDefault();
            Incluir(Contato.Criar(1, tipoContato1, "1198864455"));

            var tipoContato2 = tiposContato.Where(x => x.Id == 2).FirstOrDefault();
            Incluir(Contato.Criar(2, tipoContato2, "@thamirysGameiro"));

            var tipoContato3 = tiposContato.FirstOrDefault(x => x.Id == 3);
            Incluir(Contato.Criar(3, tipoContato3, "@thamirysGameiro"));
        }


    }
}
