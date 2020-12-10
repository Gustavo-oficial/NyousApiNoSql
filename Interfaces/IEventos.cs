using NyousApi.NoSql.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NyousApi.NoSql.Interfaces
{
    interface IEventos
    {
        List<EventoDomain> Listar();

        EventoDomain BuscarPorId(string id);
        void Adicionar(EventoDomain evento);

        void Editar(string id, EventoDomain evento);
        void Remover(string id);
    }
}
