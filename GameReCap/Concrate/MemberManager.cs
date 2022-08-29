using GameReCap.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameReCap.Concrate
{
    class MemberManager : BaseMemberManager
    {
        IRealMemberService _realMemberService;

        public MemberManager(IRealMemberService realMemberService)
        {
            _realMemberService = realMemberService;
        }

        public override void Add(Member member)
        {
            if (_realMemberService.RealMemberCheck(member))
            {
                base.Add(member);
            }
            else
            {
                throw new Exception("Kayıt Ekleme Başarısız.");
            }

           
        }
    }
}
