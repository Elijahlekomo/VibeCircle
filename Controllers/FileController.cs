using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneDoc.Api.Data;
using OneDoc.Api.Models;
using System;

namespace OneDoc.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilesController : ControllerBase
    {
        private readonly AppDbContext _db;

        public FilesController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FileDetails>>> GetFiles()
        {
            return await _db.Files.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FileDetails>> GetFile(int id)
        {
            var file = await _db.Files.FindAsync(id);
            if (file == null)
                return NotFound();

            return file;
        }

        [HttpPost]
        public async Task<ActionResult<FileDetails>> PostFile(FileDetails file)
        {
            _db.Files.Add(file);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFile), new { id = file.Id }, file);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFile(int id, FileDetails file)
        {
            if (id != file.Id)
                return BadRequest();

            _db.Entry(file).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFile(int id)
        {
            var file = await _db.Files.FindAsync(id);
            if (file == null)
                return NotFound();

            _db.Files.Remove(file);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}