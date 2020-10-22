using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoEventHandler : INotificationHandler<PedidoRascunhoIniciadoEvent>,
        INotificationHandler<PedidoAtualizadoEvent>,
        INotificationHandler<ItemPedidoAdicionadoEvent>
    {
        public Task Handle(ItemPedidoAdicionadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PedidoAtualizadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PedidoRascunhoIniciadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
