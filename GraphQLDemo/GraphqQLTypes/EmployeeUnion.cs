using GraphQL.Types;

namespace GraphQLDemo.GraphqQLTypes
{
    public class EmployeeUnion : UnionGraphType
    {
        public EmployeeUnion()
        {
            Type<FullTimeEmployeeType>();
            Type<PartTimeEmployeeType>();
            Type<ContractorType>();
        }
    }
}
