using graphQLDemo.Schema;

namespace graphQLDemo.Mutations
{
    public class CourseResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }

        public Guid InstructorId { get; set; }
    }
}
