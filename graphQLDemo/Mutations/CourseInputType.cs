using graphQLDemo.Schema;

namespace graphQLDemo.Mutations
{
    public class CourseInputType
    {
        public string? name { get; set; }
        public Subject subject { get; set; }
        public Guid instructorId { get; set; }
    }
}
