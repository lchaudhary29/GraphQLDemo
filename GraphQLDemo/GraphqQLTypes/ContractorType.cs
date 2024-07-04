using GraphQL.Types;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphqQLTypes
{
    public class ContractorType : ObjectGraphType<Contractor>
    {
        public ContractorType()
        {
            Name = "Contractor";
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Position);
            Field(x => x.ContractDuration);
            Interface<EmployeeInterface>(); // Implementing the interface
        }
    }
}
