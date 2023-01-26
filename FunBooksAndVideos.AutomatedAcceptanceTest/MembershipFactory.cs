using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.AutomatedAcceptanceTest
{
    public class MembershipFactory
    {
        public static INonPhysicalProduct CreateMembership(string productName)
        {
            return _membershipTypes[productName];
        }


       private static Dictionary<string, INonPhysicalProduct> _membershipTypes = new Dictionary<string, INonPhysicalProduct>
       {
           {"BookMemberShip", new BookMembership()},
            {"VideoMemberShip", new VideoMembership()}
       };
           
    }
}
