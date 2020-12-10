using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NyousApi.NoSql.Domains;
using NyousApi.NoSql.Interfaces;
using NyousApi.NoSql.Repositories;

namespace NyousApi.NoSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
            private readonly IEventos _eventoRepo;

            public EventosController(EventoRepository eventoRepo)
            {
                _eventoRepo = eventoRepo;
            }

            [HttpGet]
            public ActionResult<List<EventoDomain>> Get()

            {
                try
                {
                    return _eventoRepo.Listar();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }


        [HttpGet("{id}")]
        public ActionResult GetById(string id)

        {
            try
            {
                var evento = _eventoRepo.BuscarPorId(id); 
                return Ok(evento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
            public ActionResult<EventoDomain> Create(EventoDomain evento)
            {
                try
                {
                    _eventoRepo.Adicionar(evento);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpPut("{id}")]
            public IActionResult Put(string id, EventoDomain evento)
            {
                try
                {
                    evento.Id = id;
                    _eventoRepo.Editar(id, evento);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }

            [HttpDelete("{id}")]
            public IActionResult Delete(string id)
            {
                try
                {
                    _eventoRepo.Remover(id);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }

