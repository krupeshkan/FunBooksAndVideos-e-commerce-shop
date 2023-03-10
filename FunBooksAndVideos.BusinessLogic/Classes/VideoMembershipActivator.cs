using FunBooksAndVideos.BusinessLogic.Interfaces;
using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Model.Interfaces;
using FunBooksAndVideos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.BusinessLogic.Classes
{
    public class VideoMembershipActivator : IMembershipActivator
    {
        private readonly IMembershipActivator _memberShipActivator;
        private readonly IMembershipActivateRepository _membershipActivateRepository;
        public VideoMembershipActivator(IMembershipActivator memberShipActivator, IMembershipActivateRepository membershipActivateRepository)
        {
            _memberShipActivator = memberShipActivator;
            _membershipActivateRepository = membershipActivateRepository;
        }
        public bool Activate(Order order)
        {
            if (order.ItemLines.Where(a => a is VideoMembership).Count() > 0)
            {
                return _membershipActivateRepository.Activate(order);
            }
            return _memberShipActivator.Activate(order);

        }
    }
}
