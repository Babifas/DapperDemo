using Dapper;
using DapperDemo.Models;
using System.Data;
using System.Data.SqlClient;

namespace DapperDemo.Services
{
    public class EmployeeService:IEmployeeService
    {
        public readonly IDbConnection connection;
        public EmployeeService(IConfiguration configuration)
        {
            connection = new SqlConnection(configuration["ConnectionStrings:DefaultConnection"]);
            
        }
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await connection.QueryAsync<Employee>("SELECT * FROM Employees");
        }
        public async Task AddEmployee(Employee employee)
        {
            await connection.ExecuteAsync("INSERT INTO Employees VALUES (@Name,@Position,@Salary)",employee);
        }
        
    }
}
