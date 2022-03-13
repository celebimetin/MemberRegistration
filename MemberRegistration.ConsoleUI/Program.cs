using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;
using System;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemberService memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                FirstName = "Çetin",
                LastName = "Çelebi",
                DateOfBirth = new DateTime(1994, 3, 6),
                TcNo = "50284499854",
                Email = "mcelebi@gmail.com"
            });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}