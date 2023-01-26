using FunBooksAndVideos.BusinessLogic.Interfaces;
using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Model.Interfaces;
using FunBooksAndVideos.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FunBooksAndVideos.BusinessLogic.Classes
{
    public class PremiumMembershipActivator : IMembershipActivator
    {
        private readonly IMembershipActivateRepository _membershipActivateRepository;
        public PremiumMembershipActivator(IMembershipActivateRepository membershipActivateRepository)
        {
            _membershipActivateRepository = membershipActivateRepository;
        }

        public bool Activate(Order order)
        {
            if (order.ItemLines.Where(a => a is PremiumMembership).Count() > 0)
            {
                return _membershipActivateRepository.Activate(order);
            }
            return default(bool);

        }
    }
}
