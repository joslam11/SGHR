﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHR.Domain.DomainServices.SharedInterfaces
{
    public interface IProveedorTarifaCategoria
    {
        Task<decimal?> ObtenerTarifaBasePorCategoriaAsync(int idCategoria);
    }
}
