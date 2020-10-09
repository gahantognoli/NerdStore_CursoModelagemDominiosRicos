using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NerdStore.Catalago.Application.Services;
using NerdStore.Catalogo.Data;
using NerdStore.Catalogo.Data.Repository;
using NerdStore.Catalogo.Domain;
using NerdStore.Catalogo.Domain.Events;
using NerdStore.Core.Bus;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();
        }
    }
}
