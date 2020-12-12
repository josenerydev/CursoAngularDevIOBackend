using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;

using Microsoft.EntityFrameworkCore;

using System;
using System.Threading.Tasks;

namespace DevIO.Data.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {
        }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await DbContext.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}
