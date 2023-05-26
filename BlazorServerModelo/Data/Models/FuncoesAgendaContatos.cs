using Microsoft.EntityFrameworkCore;

namespace BlazorServerModelo.Data.Models
{
    public class FuncoesAgendaContatos 
    {
        private ModeloDbContext _dbContext;

        public FuncoesAgendaContatos()
        {
            _dbContext = new ModeloDbContext();
        }

        public async Task<List<AgendaContatos>> ListaAgenda()
        {
            return await _dbContext.AgendaContatos.ToListAsync();
        }

        public async Task CriaAgenda(AgendaContatos agenda)
        {
            await _dbContext.AgendaContatos.AddAsync(agenda);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditaAgenda(AgendaContatos agenda)
        {
            //Já grava direto - sem botão para gravar: editou, gravou.
            _dbContext.Entry(agenda).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletaAgenda(int id)
        {
            var agenda = await _dbContext.AgendaContatos.FirstOrDefaultAsync(x => x.Id == id);
            if(agenda != null) 
            { 
                //Clicou: apagou, sem confirmação
                _dbContext.AgendaContatos.Remove(agenda);
                await _dbContext.SaveChangesAsync();
            }
        }

    }
}
