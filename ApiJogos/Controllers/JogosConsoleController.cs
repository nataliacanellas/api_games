using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace ApiJogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosConsoleController : ControllerBase
    {
        private JogosConsoleRepository repo;

        public JogosConsoleController()
        {
            this.repo = new();
        }

        [HttpGet("{id}")]
        public JogoConsole Get(int id)
        {
            return repo.GetById(id);
        }
        [HttpGet]
        public List<JogoConsole> GetAll()
        {
            return repo.GetAll();
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }
        [HttpPost]
        public string Create(JogoConsole model)
        {
            return repo.Create(model);
        }
        [HttpPatch]
        public string Update(JogoConsole entity)
        {
            return repo.Update(entity);
        }

        [HttpPut]
        public string Modify(JogoConsole entity)
        {
            return repo.Modify(entity);
        }
    }
}
