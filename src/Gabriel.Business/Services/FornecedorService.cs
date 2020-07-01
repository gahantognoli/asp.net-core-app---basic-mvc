using Gabriel.Business.Interfaces;
using Gabriel.Business.Models;
using Gabriel.Business.Validations;
using System;
using System.Threading.Tasks;

namespace Gabriel.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public async Task Adicionar(Fornecedor fornecedor)
        {
            //Validar o estado da entidade
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                && !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
