using Microsoft.AspNetCore.Mvc;
using APIonetomany.Models;
using Microsoft.EntityFrameworkCore;
namespace APIonetomany.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : Controller
    {
        private readonly OrganizationContext _context;

        public OrganizationController(OrganizationContext context)
        {
            _context = context;
        }


        // GET: api/<DepartmentsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> Get()
        {
            return await _context.Departments.Include(x=>x.Employees).ToListAsync();
        }

        // GET api/<DepartmentsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> Get(int id)
        {
            Department dt = await _context.Departments.FirstOrDefaultAsync(x => x.Deptid == id);
            return dt;
        }

        // POST api/<DepartmentsController>
        [HttpPost]
        public async Task<ActionResult<Department>> Post(Department dept)
        {
            _context.Departments.Add(dept);
            _context.SaveChanges();
            return Ok(dept);
        }

        // PUT api/<DepartmentsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Department dept)
        {

            _context.Entry(dept).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(dept);
        }

        // DELETE api/<DepartmentsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {


            var dept = await _context.Departments.FindAsync(id);


            _context.Departments.Remove(dept);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
