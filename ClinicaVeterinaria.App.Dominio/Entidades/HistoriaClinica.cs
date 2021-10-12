using System;

namespace ClinicaVeterinaria.App.Dominio
{

    public class HistoriaClinica 
    {
        public int HistoriaClinicaId { get; set; } 
        public Anotacion anotacion { get; set; }
        public Chequeo  chequeo { get; set; }
        public Mascota mascota { get; set; }
        public Owner  owner { get; set; }
        public Veterinario veterinario { get; set; }
        public Auxiliar  auxiliar { get; set; }
    }
}