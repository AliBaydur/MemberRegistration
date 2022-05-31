using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.Concrete;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member{Email = "alibaydur34@gmail.com", FirstName = "Ali", LastName = "Baydur", DateOfBirth = new DateTime(1995,8,29), TcNo = "37390265184"});
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
