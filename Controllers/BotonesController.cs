using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChallengeTotalApi.Models;
using ChallengeTotalApi.Context;

namespace BotonesApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class BotonesController : ControllerBase
    {
        private readonly ButtonsDbContext _context;
        public BotonesController(ButtonsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<ButtonModel>>> GetButtons()
        {
            return await _context.Buttons.ToListAsync();
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> CreateButton()
        {
            ButtonModel button = new ButtonModel();
            _context.Add(button);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPatch]
        [Route("ClickButton/{id}")]
        public async Task<ActionResult> UpdateButton(int id)
        {
            var button = await _context.Buttons.FindAsync(id);
            if (button == null)
            {
                return NotFound();
            }
            button.button_count += 1;
            _context.Update(button);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteButton/{id}")]
        public async Task<ActionResult> DeleteButton(int id)
        {
            var button = await _context.Buttons.FindAsync(id);
            if (button == null)
            {
                return NotFound();
            }
            _context.Remove(button);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
