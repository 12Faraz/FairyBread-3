using FluentValidation;
using graphQLDemo.Mutations;
using graphQLDemo.Schema;

namespace graphQLDemo
{
    public class MyAppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<IValidator<CourseInputType>, CreateUserInputValidator>();

            services.AddGraphQLServer()
                .AddFairyBread()
                .AddMutationType<Mutation>()
                .AddQueryType<Query>();
        }
    }
}
