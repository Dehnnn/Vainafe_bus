using System;

namespace Vainafe_bus
{
    public class Viagem
    {
        public int IdViagem { get; set; }
        public int IdOnibus { get; set; }
        public int IdRota { get; set; }
        public DateTime DataHoraSaida { get; set; }
        public DateTime DataHoraChegada { get; set; }
        public TimeSpan HorarioSaida { get; set; }
        public TimeSpan HorarioChegada { get; set; }
        public decimal Preco { get; set; }
        public int VagasDisponiveis { get; set; }
        public int VagasTotais { get; set; }
        public string Status { get; set; }

        // Propriedades para exibição (não estão no banco)
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string OnibusNumero { get; set; }

        // Propriedade computada para compatibilidade
        public DateTime DataSaida
        {
            get => DataHoraSaida;
            set => DataHoraSaida = value;
        }

        public DateTime DataChegada
        {
            get => DataHoraChegada;
            set => DataHoraChegada = value;
        }

        public int AssentosDisponiveis
        {
            get => VagasDisponiveis;
            set => VagasDisponiveis = value;
        }
    }
}