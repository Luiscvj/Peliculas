using Api.Controllers;
using Core.Entities;
using Core.Interfaces;
using Infrastrucre.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class PeliculaController :BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public PeliculaController(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }



[HttpPost("AddPelicula")]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]



        public   async  Task<ActionResult<Pelicula>> Post(Pelicula entity)
        {  
                _unitOfWork.Peliculas.Add(entity);
             int num = await    _unitOfWork.SaveAsync();

             if(num == 0 )
             {
                return BadRequest();
             }
            return CreatedAtAction(nameof(Post), new { id = entity.PeliculaId },entity);
        }
}