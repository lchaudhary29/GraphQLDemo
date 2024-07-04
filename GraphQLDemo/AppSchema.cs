using GraphQL.Types;

namespace GraphQLDemo
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<EmployeeQuery>();
        }
    }
}
