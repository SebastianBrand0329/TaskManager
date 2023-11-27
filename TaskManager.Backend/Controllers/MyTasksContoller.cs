using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskManager.Backend.Data;
using TaskManager.Shared.Entities;

namespace TaskManager.Backend.Controllers
{
    [Route("api/mytasks")]
    [ApiController]
    public class MyTasksContoller : ControllerBase
    {
        private readonly DataContext _context;

        public MyTasksContoller(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.MyTasks.ToList());
        }


        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var task = _context.MyTasks.FirstOrDefault(x => x.Id == id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        [HttpPost]
        public IActionResult Post(MyTask myTask)
        {
            _context.MyTasks.Add(myTask);
            _context.SaveChanges();
            return Ok(myTask);
        }

        [HttpPut]
        public IActionResult Put(MyTask myTask)
        {
            var task = _context.MyTasks.FirstOrDefault(x => x.Id == myTask.Id);

            if (task == null)
            {
                NotFound();
            }

            _context.MyTasks.Update(task!);
            _context.SaveChanges();

            return Ok(task);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var task = _context.MyTasks.FirstOrDefault(x => x.Id == id);

            if (task == null)
            {
                NotFound();
            }

            _context.MyTasks.Remove(task!);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
