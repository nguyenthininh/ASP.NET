using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GolfClub.Models;

namespace GolfClub.DAL
{
    public class ClubMemberDbManager
    {
       public Member CreateMember(Member memberModel)
        {
            using (var dbEntities = new GolfClubContext())
            {
                var MemberObj = new Member()
                {
                    Name = memberModel.Name,
                Gender = memberModel.Gender,
                MemberFree = memberModel.MemberFree
                };
                dbEntities.Members.Add(MemberObj);
                dbEntities.SaveChanges();
            }
                return memberModel;
        }
    }
}