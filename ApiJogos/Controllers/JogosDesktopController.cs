using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiJogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosDesktopController : ControllerBase
    {
        private JogosDesktopRepository repo;

        public JogosDesktopController()
        {
            this.repo = new();
        }

        [HttpGet("{id}")]
        public JogoDesktop Get(int id)
        {
            return repo.GetById(id);
        }
        [HttpGet]
        public List<JogoDesktop> GetAll()
        {
            return repo.GetAll();
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }
        [HttpPost]
        public string Create(JogoDesktop model)
        {
            return repo.Create(model);
        }
        [HttpPatch]
        public string Update(JogoDesktop entity)
        {
            return repo.Update(entity);
        }
        [HttpPut]
        public string Modify(JogoDesktop entity)
        {
            return repo.Modify(entity);
        }
    }
}
