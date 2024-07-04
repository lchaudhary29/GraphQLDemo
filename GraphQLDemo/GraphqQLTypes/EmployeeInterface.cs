using GraphQL.Types;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphqQLTypes
{
    public class EmployeeInterface : InterfaceGraphType<Employee>
    {
        public EmployeeInterface()
        {
            Name = "Employee";
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Position);
        }
    }
}
