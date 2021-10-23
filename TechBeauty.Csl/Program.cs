using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Csl
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------------------");

            DateTime dtNascimento = new DateTime(2002, 06, 24);
            int dtDeHoje = DateTime.Now.Year;
            int dtTeste = dtDeHoje - dtNascimento.Year;
            Console.WriteLine(dtTeste);

            Console.WriteLine("---------------------------------------------------------");

            GeneroRepositorio repoGenero = new GeneroRepositorio();
            TipoContatoRepositorio repoTipoContato = new TipoContatoRepositorio();
            ContatoRepositorio repoContato = new ContatoRepositorio(repoTipoContato.TabelaTipoContato);
            CargoRepositorio repoCargo = new CargoRepositorio();

            ServicoRepositorio repoServico = new ServicoRepositorio();
            EnderecoRepositorio repoEndereco = new EnderecoRepositorio();
            RegimeContratualRepositorio regimeContratualRepositorio = new RegimeContratualRepositorio();

            var regimeContratual = regimeContratualRepositorio.TabelaRegimeContratual[0];
            var cargos = repoCargo.TabelaCargo;

            ContratoTrabalhoRepositorio repoContratoTrabalhoRepositorio = new ContratoTrabalhoRepositorio(regimeContratual, cargos);


            Console.WriteLine("---------------------------------------------------------");
            foreach (var contrato in repoContratoTrabalhoRepositorio.TabelaContratoTrabalho)
            {
                Console.WriteLine($"{contrato.Id}, " +
                    $"{contrato.RegimeContratual.Valor}, " +
                    $"{contrato.DataEntrada}, " +
                    $"{contrato.DataDesligamento}" +
                    $"Nome: {contrato.Cargos[0].Nome}, Descricao: {contrato.Cargos[0].Descricao}" +
                    $", {contrato.CnpjCTPS}" +
                    $"\n{contrato.CalcTempoNaEmpresa()}");
            }

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Repositorio Cargo:");
            foreach (Cargo cargo in repoCargo.TabelaCargo)
            {
                Console.WriteLine($"{cargo.Id}, {cargo.Nome}, {cargo.Descricao}");
            }

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Repositorio Contato:");

            foreach (Contato contato in repoContato.TabelaContato)
            {
                Console.WriteLine($"{contato.Id}, {contato.Tipo.Valor}, {contato.Valor}");
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");


        }

    }
}