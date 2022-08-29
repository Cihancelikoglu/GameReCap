using System;
using System.Collections.Generic;
using System.Text;

namespace GameReCap.Abstract
{
    class BaseMemberManager : IMemberService
    {
        public virtual void Add(Member member)
        {
            Console.WriteLine(member.FirstName + " " + member.LastName + " " + "Kaydını Tamamlandı.");
        }

        public virtual void Delete(Member member)
        {
            Console.WriteLine(member.FirstName + " " + "Güncelleme Tamamlandı.");
        }

        public virtual void Update(Member member)
        {
            Console.WriteLine(member.FirstName + " " + "Kayıt Silindi.");
        }
    }
}
