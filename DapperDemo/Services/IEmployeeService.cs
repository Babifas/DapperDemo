using DapperDemo.Models;

namespace DapperDemo.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task AddEmployee(Employee employee);
    }
}
