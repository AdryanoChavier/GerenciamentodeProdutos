using Gerenciamento.Application.DTOs;
using Gerenciamento.Application.Produtos.Commands.AdicionarProduto;
using Gerenciamento.Application.Produtos.Commands.CreateProduto;
using Gerenciamento.Application.Produtos.Commands.DeleteProduto;
using Gerenciamento.Application.Produtos.Commands.SaidaProduto;
using Gerenciamento.Application.Produtos.Commands.UpdateProduto;
using Gerenciamento.Application.Produtos.Queries.GetAllProduto;
using Gerenciamento.Application.Produtos.Queries.GetObterRelatorioProdutosGeral;
using Gerenciamento.Application.Produtos.Queries.GetProdutoBaixoEstoque;
using Gerenciamento.Application.Produtos.Queries.GetProdutoById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciamento.API.Controllers;

[ApiController]
[Route("api/produtos")]
public class ProdutoController(IMediator mediator) : Controller
{


    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetAll()
    {
        var produtos = await mediator.Send(new GetAllProdutoQuery());
        return Ok(produtos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProdutoDto>> GetById([FromRoute] Guid id)
    {
        var produto = await mediator.Send(new GetProdutoByIdQuery(id));

        return Ok(produto);
    }


    [HttpPost]
    public async Task<IActionResult> CreateProduto(CreateProdutoCommand command)
    {
        await mediator.Send(command);
        return NoContent();
    }

    [HttpPatch("{id}")]

    public async Task<IActionResult> UpdateProduto([FromRoute] Guid id, UpdateProdutoCommand command)
    {
        command.Id = id;
        await mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> DeleteProduto([FromRoute] Guid id)
    {
        await mediator.Send(new DeleteProdutoCommand(id));

        return NoContent();
    }

    [HttpPatch("removerProduto")]

    public async Task<IActionResult> SaidaProduto(SaidaProdutoCommand command)
    {
        await mediator.Send(command);
        return NoContent();
    }

    [HttpPatch("adicionarProduto")]

    public async Task<IActionResult> AdicionarProduto(AdicionarProdutoCommand command)
    {
        await mediator.Send(command);
        return NoContent();
    }


    [HttpGet("obterRelatorioBaixoEstoque")]
    public async Task<ActionResult<IEnumerable<ProdutoDto>>> ObterProdutoBaixoEstoque()
    {
        var produtos = await mediator.Send(new GetProdutoBaixoEstoqueQuery());
        return Ok(produtos);
    }

    [HttpGet("obterRelatorioProdutosGeral")]
    public async Task<ActionResult<IEnumerable<ProdutoRelatorioDto>>> ObterRelatorioProdutosGeral()
    {
        var produtos = await mediator.Send(new GetRelatorioGeralProdutosQuery());
        return Ok(produtos);
    }


}
