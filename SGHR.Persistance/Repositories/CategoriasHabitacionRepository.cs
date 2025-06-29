﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGHR.Domain.InterfacesRepositories;
using SGHR.Persistance.DBContext;
using SGHR.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHR.Persistance.Repositories
{
    public class CategoriasHabitacionRepository : ICategoriasHabitacionRepository
    {
        private readonly SGHRDbContext _context;
        private readonly DbSet<CategoriasHabitacion> _categoriasHabitacion;
        public CategoriasHabitacionRepository(SGHRDbContext context) 
        { 
            _context = context; ;
            _categoriasHabitacion = _context.Set<CategoriasHabitacion>();
        }

        public async Task ActualizarCategoriaAsync(CategoriasHabitacion categoriasHabitacion)
        {
            _categoriasHabitacion.Update(categoriasHabitacion);
            await _context.SaveChangesAsync();
        }

        public async Task CrearCategoriaAsync(CategoriasHabitacion categoriasHabitacion)
        {
            await _categoriasHabitacion.AddAsync(categoriasHabitacion);
        }

        public void EliminarCategoriaAsync(CategoriasHabitacion categoriasHabitacion)
        {
           _categoriasHabitacion.Remove(categoriasHabitacion);
        }

        public async Task GuardarCambiosAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoriasHabitacion>> ObtenerTodasCategoriasAsync()
        {
            return await _categoriasHabitacion.ToListAsync();
        }
    }
}
