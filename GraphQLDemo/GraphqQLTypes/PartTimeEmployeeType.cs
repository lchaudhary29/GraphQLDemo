using GraphQL.Types;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphqQLTypes
{
    public class PartTimeEmployeeType : ObjectGraphType<PartTimeEmployee>
    {
        public PartTimeEmployeeType()
        {
            Name = "PartTimeEmployee";
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Position);
            Field(x => x.HourlyRate);
            Interface<EmployeeInterface>(); // Implementing the interface
        }
    }
}
