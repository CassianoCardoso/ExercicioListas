using System;
using System.Globalization;


namespace Aula_78_Exercicios_Listas
{
    internal class Empregados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }


        public Empregados(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementaSalario(double porcent)
        {
            Salario += Salario / 100.0;
        }

        public override string ToString()
        {
            return Id + "," + Nome + "," + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
