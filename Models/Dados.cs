namespace Projeto_quinto_semestre.Models
{
    public class Dados
    {
        public static Agendamento Agendado = new();

        public static void Cadastrar(Agendamento agenda)
        {
            Agendado.Nome = agenda.Nome;
            Agendado.Data = agenda.Data;
            Agendado.Fone = agenda.Fone;
            Agendado.Animal = agenda.Animal;
            Agendado.Necessidade = agenda.Necessidade;
        }

        public static Agendamento Listar()
        {
            return Agendado;
        }
    }
}