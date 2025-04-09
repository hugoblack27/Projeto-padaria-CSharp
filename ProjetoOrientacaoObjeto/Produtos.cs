using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    internal class Produtos
    {
        private string descricao;
        private string codigo;
        private double valor;
        private int quantidade;
        private string dataEntrada;
        private string dataSaida;


        public void setdescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getdescricao() 
        {
            return this.descricao;
        }

        public void setcodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string getcodigo()
        {
            return this.codigo;
        }

        public void setvalor(double valor)
        {
            this.valor = valor;
        }

        public double getvalor()
        {
            return this.valor;
        }

        public void setquantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }

        public int getquantidade()
        {
            return this.quantidade;
        }

        public void setdataEntrada(string dataEntrada)
        {
            this.dataEntrada = dataEntrada;
        }

        public string getdataEntrada()
        {
            return this.dataEntrada;
        }

        public void setdataSaida(string dataSaida)
        {
            this.dataSaida = dataSaida;
        }

        public string getdataSaida()
        {
            return this.dataSaida;
        }
    }
}
