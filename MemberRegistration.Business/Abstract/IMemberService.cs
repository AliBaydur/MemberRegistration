using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
    }
}
