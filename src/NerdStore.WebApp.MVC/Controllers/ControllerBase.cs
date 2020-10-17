using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Bus;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatrHandler _mediatrHandler;
        protected Guid ClienteId = Guid.Parse("76b5d0e4-74a7-42ed-990c-bf5782d20252");

        protected ControllerBase(INotificationHandler<DomainNotification> notifications, IMediatrHandler mediatrHandler)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _mediatrHandler = mediatrHandler;
        }

        protected bool OperacaoValida()
        {
            return !_notifications.TemNotificacao();
        }

        protected IEnumerable<string> ObterMensagensErro()
        {
            return _notifications.ObterNotificacoes().Select(c => c.Value).ToList();
        }

        protected void NotificarErro(string codigo, string mensagem)
        {
            _mediatrHandler.PublicarNotificacao(new DomainNotification(codigo, mensagem));
        }

    }
}
