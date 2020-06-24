using Gabriel.Business.Interfaces;
using Gabriel.Business.Models;
using Gabriel.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Gabriel.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext db) : base(db)
        {
        }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId) =>
            await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
    }
}
