using System;

namespace DevIO.Business.Models
{
    /* Classe (abstract) base - Não pode ser herdada tem que ser instânciada */

    public abstract class Entity
    {
        public Guid Id { get; set; }
        public Entity()
        {
            Id = new Guid();
        }
    }
}