﻿using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class EnderecoRepository
    {
        public static void SalveEndereco(Endereco endereco)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = endereco.Pessoa.Id;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 15).Value = endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = endereco.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = endereco.UF;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void Update(Pessoa pessoa, Endereco endereco)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_ENDERECO, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = pessoa.Id;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 15).Value = endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = endereco.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = endereco.UF;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader FetchAll()
        {

            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ENDERECO, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void Delete(Endereco endereco)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_ENDERECO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = endereco.Pessoa.Id;

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void DeletePessoa(int id_pessoa)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PESSOA, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = id_pessoa;

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLs
        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco
                                                                        (id_pessoa,
                                                                        CEP,
                                                                        rua,
                                                                        numero,
                                                                        bairro,
                                                                        cidade,
                                                                        uf)
                                                                        VALUES
                                                                        (@id_pessoa,
                                                                        @CEP,
                                                                        @rua,
                                                                        @numero,
                                                                        @bairro,
                                                                        @cidade,
                                                                        @uf)";


        private const String SQL_SELECT_ENDERECO = @"SELECT * FROM endereco";

        private const String SQL_UPDATE_ENDERECO = @"UPDATE endereco
                                                            SET
                                                            CEP = @CEP,
                                                            rua = @rua,
                                                            numero = @numero,
                                                            bairro = @bairro,
                                                            cidade = @cidade,
                                                            uf = @uf
                                                            WHERE id_pessoa = @id_pessoa";

        private const String SQL_DELETE_ENDERECO = @"DELETE FROM endereco WHERE id_pessoa = @id ";
        private const String SQL_DELETE_PESSOA = @"DELETE FROM endereco WHERE id_pessoa = @id_pessoa ";

        

    }
}
