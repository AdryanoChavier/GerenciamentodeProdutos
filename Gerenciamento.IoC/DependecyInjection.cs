using FluentValidation;
using FluentValidation.AspNetCore;
using Gerenciamento.Application.Mappings;
using Gerenciamento.Domain.Repositories;
using Gerenciamento.Infra.Persistence;
using Gerenciamento.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gerenciamento.IoC;

public static class DependecyInjection
{
    public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProdutoDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly(typeof(ProdutoDbContext).Assembly.FullName)).EnableSensitiveDataLogging());
        
        #region Mapeamento
        services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
        #endregion

        services.AddValidatorsFromAssembly(AppDomain.CurrentDomain.Load("Gerenciamento.Application")).AddFluentValidationAutoValidation();

        #region MediatR
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(AppDomain.CurrentDomain.Load("Gerenciamento.Application")));
        #endregion

        services.AddScoped<IProdutoRepository, ProdutoRepository>();

        return services;
    }
}