using Application.Repositorys;
using Application.Repositorys.Rooms;
using Application.Services;
using MediatR;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Rooms.ChatRooms.Commands.AddMessage
{
    public class SaveMessageCommandHandler : IRequestHandler<AddMessageCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IRealTimeMessageService _realTimeMessageService;
        //private readonly IRealTimeVideoService realTimeVideoService;

        /*Ca sa pot injecta interfata hub-ului, ar trebui sa adaug un alt layer
         * de abstractizare, deoarece Hub apartine layer-ului de infrastructura
         * Din acest motiv, voi injecta hub context-ul in controller
         */
        //private readonly IHubContext<IRealTimeMessageService, HubContext> _hubContext;

        public SaveMessageCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
     
        }
        public async Task<bool> Handle(AddMessageCommand request, CancellationToken cancellationToken)
        {

            var message = request.message;


         
        await _unitOfWork.BeginTransaction();

            await _unitOfWork.MessageRepository.CreateMessage(message);
            

            await _unitOfWork.CommitTransaction();

            return true;
        }
    }
}
