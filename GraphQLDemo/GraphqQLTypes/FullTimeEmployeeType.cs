using GraphQL.Types;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphqQLTypes
{
    public class FullTimeEmployeeType : ObjectGraphType<FullTimeEmployee>
    {
        public FullTimeEmployeeType()
        {
            Name = "FullTimeEmployee";
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Position);
            Field(x => x.Salary);
            Interface<EmployeeInterface>(); // Implementing the interface
        }
    }
}
