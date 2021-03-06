using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Pessoa
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string CPF { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public List<Contato> Contatos { get; protected set; }

        public void AlteraId(int id)
        {
            Id = id;
        }
        
        public bool ValidaCPF()
        {
            return true; 
        }

        public int calcIdade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }
        
        // Método listar contatos


    }
}