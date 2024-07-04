using GraphQL.Types;
using GraphQLDemo.GraphqQLTypes;
using GraphQLDemo.Models;

namespace GraphQLDemo
{
    public class EmployeeQuery : ObjectGraphType
    {
        public EmployeeQuery()
        {
            Field<ListGraphType<EmployeeUnion>>(
                "employees",
                resolve: context =>
                {
                    // Replace this with your data retrieval logic
                    return new List<Employee>
                    {
                    new FullTimeEmployee { Id = "1", Name = "John Doe", Position = "Manager", Salary = 60000 },
                    new PartTimeEmployee { Id = "2", Name = "Jane Smith", Position = "Assistant", HourlyRate = 20 },
                    new Contractor { Id = "3", Name = "Mike Johnson", Position = "Consultant", ContractDuration = "6 months" }
                    };
                }
            );
        }
    }
}
