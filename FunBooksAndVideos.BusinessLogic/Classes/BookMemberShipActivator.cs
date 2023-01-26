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
    public class BookMembershipActivator : IMembershipActivator
    {
        private readonly IMembershipActivator _memberShipActivator;
        private readonly IMembershipActivateRepository _membershipActivateRepository;
        public BookMembershipActivator(IMembershipActivator memberShipActivator, IMembershipActivateRepository membershipActivateRepository)
        {
            _memberShipActivator = memberShipActivator;
            _membershipActivateRepository = membershipActivateRepository;
        }
        public bool Activate(Order order)
        {
            if (order.ItemLines.Where(a => a is BookMembership).Count() > 0)
            {
                //BookMembership activateion logic goes here
                return _membershipActivateRepository.Activate(order);
            }

            return _memberShipActivator.Activate(order);

        }
    }
}
