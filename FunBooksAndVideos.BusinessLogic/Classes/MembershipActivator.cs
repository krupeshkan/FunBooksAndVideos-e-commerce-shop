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
    public class MembershipActivator : IMembershipActivator
    {
        private readonly IMembershipActivateRepository _membershipActivateRepository;
        public MembershipActivator(IMembershipActivateRepository membershipActivateRepository)
        {
            _membershipActivateRepository = membershipActivateRepository;
        }
        public bool Activate(Order order)
        {
            if (order.ItemLines.Where(a => a is INonPhysicalProduct).Count() > 0)
            {
                return _membershipActivateRepository.Activate(order);
            }
            return default(bool);
        }
    }
}
