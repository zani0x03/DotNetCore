using Npgsql;
using System.Collections.Generic;
using System;
using PessoaAPI.Models;

namespace PessoaAPI.Dados
{

    public class DAOPessoa{

        public List<Pessoa> RetornarPessoas(){
            var connString = "Host=localhost;Username=postgres;Password=zp3;Database=DotNetCoreAPI";

            List<Pessoa> lstPessoa = new List<Pessoa>();

            try{
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT id, cpf, Nome FROM \"Pessoa\"", conn))
                    using (var reader = cmd.ExecuteReader())
                    while (reader.Read()){
                        Pessoa pessoa = new Pessoa();
                        pessoa.Id = (Int64)reader["id"];
                        pessoa.CPF = (Int64)reader["cpf"];
                        pessoa.Nome = reader.GetString(2);
                        lstPessoa.Add(pessoa);
                    }
                    conn.Close();
                }
            }catch(Exception ex){
                string teste = ex.Message;
            }       
            

            return lstPessoa; 
        }
    }
}