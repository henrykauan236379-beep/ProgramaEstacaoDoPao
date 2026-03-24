using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Npgsql;
using System.Configuration;
using ProgramaPadaria.Models;

namespace ProgramaPadaria.Repositories
{
    public class VendaRepository
    {
        private string _conexao;

        public VendaRepository(string connectionString)
        {
            _conexao = connectionString;
        }
        public int InserirVenda(decimal valorTotal, DateTime dataVenda)
        {
            using var conn = new NpgsqlConnection(_conexao);
            {
                string sql = "INSERT INTO venda (valor_total, data_venda) VALUES (@ValorTotal, @DataVenda) RETURNING id_venda";

                var idVenda = conn.ExecuteScalar<int>(sql, new { ValorTotal = valorTotal, DataVenda = dataVenda });
                return idVenda;
            }
        }
        public void InserirVendaCategoria(int idVenda, int idCategoria)
        {
            using (var conn = new NpgsqlConnection(_conexao))
            {
                string sql = "INSERT INTO venda_categoria (id_venda, id_categoria) VALUES (@IdVenda, @IdCategoria)";
                conn.Execute(sql, new { IdVenda = idVenda, IdCategoria = idCategoria });
            }
        }
        public List<Venda> BuscarVendasHoje()
        {
            using (var conn = new NpgsqlConnection(_conexao))
            {
                string sql = "SELECT *FROM venda WHERE DATE(data_venda) = CURRENT_DATE ORDER BY id_venda";
                return conn.Query<Venda>(sql).ToList();
            }
        }
        public decimal TotalVendas()
        {
            using (var conn = new NpgsqlConnection(_conexao))
            {
                string sql = "SELECT COALESCE(SUM(valor_total), 0) FROM venda WHERE DATE(data_venda) = CURRENT_DATE";
                return conn.ExecuteScalar<decimal>(sql);
            }
        }

    }
}

