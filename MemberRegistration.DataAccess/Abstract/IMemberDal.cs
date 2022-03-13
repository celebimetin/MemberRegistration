using DevFramework.Core.DataAccess;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.DataAccess.Abstract
{
    public interface IMemberDal : IEntityRepository<Member>
    {
    }
}