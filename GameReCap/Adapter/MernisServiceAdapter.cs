using GameReCap.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using TCKimlikNoDogrulama.Core;

namespace GameReCap.Adapter
{
    class MernisServiceAdapter : IRealMemberService
    {
        public bool RealMemberCheck(Member member)
        {
            bool result = new TCKimlikNoDogrulamaCORE(Convert.ToInt64(member.NationalityId),
                                                     member.FirstName.ToUpper(),
                                                     member.LastName.ToUpper(),
                                                     member.BirthDate.Year).KisiVarMi();

            return result;
        }
    }
}
