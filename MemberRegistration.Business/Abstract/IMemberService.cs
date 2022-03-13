using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
    }
}