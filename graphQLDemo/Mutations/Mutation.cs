using FairyBread;
using graphQLDemo.Schema;

namespace graphQLDemo.Mutations
{
    public class Mutation
    {
        private readonly List<CourseResult> _courses;

        public Mutation()
        {
            _courses = new List<CourseResult>();
        }

        //[Validate(typeof(CreateUserInputValidator)]
        [Error(typeof(CreateUserInputValidator))]
        [UseMutationConvention()]
        public List<CourseResult> CreateCourse([Validate(typeof(CreateUserInputValidator))] CourseInputType courseInputType)
        {
            CourseResult courseType = new CourseResult()
            {
                Id = Guid.NewGuid(),
                Name = courseInputType.name,
                Subject = courseInputType.subject,
                InstructorId = courseInputType.instructorId
            };
            _courses.Add(courseType);
            return _courses;
        }
    }
}
