﻿using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Cliente : Pessoa
    {

        public static Cliente Criar(int id, string nome, string cpf, DateTime dataNascimento, List<Contato> contatos)
        {
            Cliente cliente = new Cliente();
            cliente.AlteraId(id);
            cliente.Id = id;
            cliente.CPF = cpf;
            cliente.DataNascimento = dataNascimento;
            cliente.Contatos = contatos;
            return cliente; 
        }

        public void Alterar(string nome, string cpf, DateTime dataNascimento, List<Contato> contatos)
        {
            Nome = nome; 
            CPF = cpf;
            DataNascimento = dataNascimento;
            Contatos = contatos;
        }



    }
}