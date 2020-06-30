﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALSubCategoria
    {
        private DALConexao conexao;

        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                //Inclui as informações no banco.
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into subcategoria(cat_cod, scat_nome) values (@catcod, @nome); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@catcod", modelo.Catcod);
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome);
                conexao.Conectar();
                modelo.Scatcod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {               
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            
        }
        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                //Altera as informações no banco.
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update subcategoria set scat_nome = @nome, cat_cod = @catcod where scat_cod = @scatcod;";
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome);
                cmd.Parameters.AddWithValue("@catcod", modelo.Catcod);
                cmd.Parameters.AddWithValue("@scatcod", modelo.Scatcod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public void Excluir(int codigo)
        {
            try
            {
                //Exclui informações do banco.
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from subcategoria where scat_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select sc.scat_cod, sc.scat_nome, sc.scat_cod, c.cat_nome " + " from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where scat_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from subcategoria where scat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Catcod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatNome = Convert.ToString(registro["scat_nome"]);
                modelo.Scatcod = Convert.ToInt32(registro["scat_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
