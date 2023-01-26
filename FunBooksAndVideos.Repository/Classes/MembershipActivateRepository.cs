using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Repository.Classes
{
    public class MembershipActivateRepository : IMembershipActivateRepository
    {
        public bool Activate(Order order)
        {
            return true;
        }
    }
}
