using Domain.DTOs.Customer;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Domain.Interfaces.Repositories;

public interface ICustomerRepository : IBaseRepository<Customer>
{
    Task<List<CustomerListResponseDto>> GetCustomerList();
    Task<bool> CheckCustomerNameExists(string customerName);

    Task<bool> CheckOrgNrExists(int organizationNr);
}