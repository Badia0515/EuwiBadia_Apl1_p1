using Microsoft.EntityFrameworkCore;
using Euwinbadia_P1_Apl1.Context;
using Aplicada1.Core;
using Euwinbadia_P1_Apl1.Models;
using System.Linq.Expressions;
using Microsoft.IdentityModel.Tokens;

namespace Euwinbadia_P1_Apl1.Service
{
    public class Service(IDbContextFactory<AutorContext> contextFactory) : IService<Autores,int>
    {
        public async Task<Autores?> Buscar(int id)
        {
            await using var context = await contextFactory.CreateDbContextAsync();
            return await context.Autor.FirstOrDefaultAsync(A => A.Id == id);
        }
        public async Task<bool> Existe(int id)
        {
            await using var context = await contextFactory.CreateDbContextAsync();
            return await context.Autor.AnyAsync(A => A.Id == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            await using var context = await contextFactory.CreateDbContextAsync();
            return await context.Autor.Where(A => A.Id == id).ExecuteDeleteAsync() > 0;
        }

        public async Task<List<Autores>> GetList(Expression<Func<Autores, bool>> criterio)
        {
            await using var context = await contextFactory.CreateDbContextAsync();
            return await context.Autor.Where(criterio).AsNoTracking().ToListAsync();
        }

        public async Task<bool> Insertar(Autores entidad)
        {
            await using var context = await contextFactory.CreateDbContextAsync();
            context.Autor.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Editar(Autores entidad)
        {
            await using var context = await contextFactory.CreateDbContextAsync();
            context.Autor.Update(entidad);
            return await context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Guardar(Autores entidad)
        {
            if(!await Existe(entidad.Id))
            {
                return await Guardar(entidad);
            }
            else
            {
                return await Editar(entidad);
            }
            
        }
    }
}
