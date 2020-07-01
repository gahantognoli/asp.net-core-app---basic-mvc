using Gabriel.Business.Interfaces;
using Gabriel.Business.Models;
using Gabriel.Business.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public async Task Adicionar(Produto produto)
        {
            if (ExecutarValidacao(new ProdutoValidation(), produto)) return;
            
        }

        public async Task Atualizar(Produto produto)
        {
            if (ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
