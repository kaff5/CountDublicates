using back.Models.TestDir;
using WEBBACK2.Models.Data;
using CheckCountDubl;

namespace back.Services
{
    public interface ITestService
    {
        public TestDto PostTest(TestModel model);
        public List<TestsDto> GetTests();
    }

    public class TestService: ITestService
    {

        private readonly ApplicationDbContext _context;

        public TestService(ApplicationDbContext context)
        {
            _context = context;
        }


        public List<TestsDto> GetTests()
        {

            return _context.Tests.Select(x => new TestsDto
            {
                id = x.id,
                Input = x.Input,
                Output = x.Output,
            }).ToList();

        }


        public TestDto PostTest(TestModel model)
        {

            CountDubl countDubl = new CountDubl();
            int output = countDubl.Count(model.Input);

            Test test = new Test
            {
                id = 0,
                Input = model.Input,
                Output = output
            };


            _context.Tests.Add(test);
            _context.SaveChanges();

            return new TestDto
            {
                Output = output,
            };

        }
    }
}
