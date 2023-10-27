using Bogus;

namespace graphQLDemo.Schema
{
    public class Query
    {
        private readonly Faker<InstructorType> instructorFaker;
        private readonly Faker<StudentType> studentFaker;
        private readonly Faker<CourseType> courseFaker;
        public Query(){
             instructorFaker = new Faker<InstructorType>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.Salary, f => f.Random.Double(0, 100000));

             studentFaker = new Faker<StudentType>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.GPA, f => f.Random.Double(1, 4));

             courseFaker = new Faker<CourseType>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.Name, f => f.Name.JobTitle())
            .RuleFor(c => c.Subject, f => f.PickRandom<Subject>())
            .RuleFor(c => c.Instructor, f => instructorFaker.Generate()).RuleFor(c => c.Students, f => studentFaker.Generate(3));
        }
        public IEnumerable<CourseType> GetCourses()
        {
            return courseFaker.Generate(8);
        }

        public string Instructions => "THIS IS AN INSTRUCTION";
    }
}
