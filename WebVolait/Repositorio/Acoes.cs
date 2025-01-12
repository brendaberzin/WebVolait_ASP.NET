﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebVolait.Models;

namespace WebVolait.Repositorio
{
    public class Acoes
    {

        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();


        public Cliente ListarCodCliente(int cod)
        {
            var comando = String.Format("select * from tb_cliente where CPFCliente = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarCodCli(DadosCodFunc).FirstOrDefault();
        }

        public List<Cliente> ListarCodCli(MySqlDataReader dt)
        {
            var AltAl = new List<Cliente>();
            while (dt.Read())
            {
                var AlTemp = new Cliente()
                {
                    CPFCliente = (dt["CPFCliente"].ToString()),
                    NomeCliente = (dt["NomeCliente"].ToString()),
                    NomeSocialCliente = (dt["NomeSocialCliente"].ToString()),
                    LoginCliente = (dt["LoginCliente"].ToString()),
                    TelefoneCliente = (dt["TelefoneCliente"].ToString()),
                    SenhaCliente = (dt["SenhaCliente"].ToString()),

                };
                AltAl.Add(AlTemp);

            }
            dt.Close();
            return AltAl;
        }

        public List<Cliente> ListarCliente()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from tb_cliente", con.ConectarBD());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosCliente(DadosCliente);
        }

        public List<Cliente> ListarTodosCliente(MySqlDataReader dt)
        {
            var TodosClientes = new List<Cliente>();
            while (dt.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    CPFCliente = (dt["CPFCliente"].ToString()),
                    NomeCliente = (dt["NomeCliente"].ToString()),
                    NomeSocialCliente = (dt["NomeSocialCliente"].ToString()),
                    LoginCliente = (dt["LoginCliente"].ToString()),
                    TelefoneCliente = (dt["TelefoneCliente"].ToString()),
                    SenhaCliente = (dt["SenhaCliente"].ToString()),

                };
                TodosClientes.Add(ClienteTemp);
            }
            dt.Close();
            return TodosClientes;
        }

        public Funcionario ListarCodFuncionario(int cod)
        {
                var comando = String.Format("select * from tb_funcionario where CPFFuncionario = {0}", cod);
                MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
                var DadosCodFunc = cmd.ExecuteReader();
                return ListarCodFunc(DadosCodFunc).FirstOrDefault();
        }

            
        public List<Funcionario>

        ListarCodFunc(MySqlDataReader dt)
            {
                var AltAl = new List<Funcionario>
                    ();
                while (dt.Read())
                {
                    var AlTemp = new Funcionario()
                    {
                        CPFFuncionario = (dt["CPFFuncionario"].ToString()),
                        NomeFuncionario = (dt["NomeFuncionario"].ToString()),
                        NomeSocialFuncionario = (dt["NomeSocialFuncionario"].ToString()),
                        LoginFuncionario = (dt["LoginFuncionario"].ToString()),
                        TelefoneFuncionario = (dt["TelefoneFuncionario"].ToString()),
                        SenhaFuncionario = (dt["SenhaFuncionario"].ToString()),
                        FuncaoFuncionario = ushort.Parse(dt["IdFuncao"].ToString()),

                    };
                    AltAl.Add(AlTemp);

                }
                dt.Close();
                return AltAl;
            }

            public List<Funcionario>
                ListarFuncionario()
            {
                MySqlCommand cmd = new MySqlCommand("Select * from tb_funcionario", con.ConectarBD());
                var DadosFuncionario = cmd.ExecuteReader();
                return ListarTodosFuncionario(DadosFuncionario);
            }

            public List<Funcionario>
                ListarTodosFuncionario(MySqlDataReader dt)
            {
                var TodosFuncionarios = new List<Funcionario>
                    ();
                while (dt.Read())
                {
                    var FuncionarioTemp = new Funcionario()
                    {
                        CPFFuncionario = (dt["CPFFuncionario"].ToString()),
                        NomeFuncionario = (dt["NomeFuncionario"].ToString()),
                        NomeSocialFuncionario = (dt["NomeSocialFuncionario"].ToString()),
                        LoginFuncionario = (dt["LoginFuncionario"].ToString()),
                        TelefoneFuncionario = (dt["TelefoneFuncionario"].ToString()),
                        SenhaFuncionario = (dt["SenhaFuncionario"].ToString()),
                        FuncaoFuncionario = ushort.Parse(dt["IdFuncao"].ToString()),

                    };
                    TodosFuncionarios.Add(FuncionarioTemp);
                }

                dt.Close();

                return TodosFuncionarios;

            }
    }
}