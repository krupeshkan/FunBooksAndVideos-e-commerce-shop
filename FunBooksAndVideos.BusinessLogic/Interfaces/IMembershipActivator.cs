using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.BusinessLogic.Interfaces
{
    public interface IMembershipActivator
    {
        bool Activate(Order order);
    }
}
