using MyShoppe.Core.Models;

namespace MyShoppe.Core.Contracts
{
    internal interface IInMemoryRepository<T> where T : BaseEntity
    {
    }
}