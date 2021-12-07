﻿using DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Negocio.Contratos
{
    public interface IAgendaBL
    {
        Task<List<ContactoDTO>> GetListaContactos();

        Task CrearContacto(ContactoDTO contacto);
    }
}
