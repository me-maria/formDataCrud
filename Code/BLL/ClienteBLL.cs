using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormProgramCamadas.Code.DTO;
using Projeto3Camadas.Code.DAL;

namespace FormProgramCamadas.Code.BLL  //Busines Lógic Layer = camada lógica de negócios
{
    internal class ClienteBLL
    {
        AcessoBancoDedados bd = new AcessoBancoDedados();
        public void Inserir(ClienteDTO dto)
        {
            bd.Conectar();
            string comando = "INSERT INTO cliente (nome, email, cpf, dataNasc) VALUES ('" + dto.Nome + "', '" + dto.Email + "', '" + dto.CPF + "', '" + dto.DataNascimento.ToString("yyyy-MM-dd") + "')";
            bd.ExecutarComandoSQL(comando);
        }
    }
}
