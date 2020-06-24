using Gabriel.Business.Interfaces;
using Gabriel.Business.Models;
using Gabriel.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Gabriel.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext db) : base(db)
        {
        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id) =>
             await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id) =>
            await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Produtos)
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
    }
}
