using System;
using System.Collections.Generic;
using System.Text;

namespace EventSystem.Core.Domain
{

    //Instancja klasy aby miała swój unikalny Guid
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
