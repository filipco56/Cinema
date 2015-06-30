using eMovie.AppServices.DTOs;
using eMovie.Domain.Entities;
using eMovie.Infrastracture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.AppServices
{
    public class GenreService
    {
        private IGenreRepository _genreRepository;


        public GenreService(IGenreRepository genreRepository)     //deka kje raboti so entitetot od zharn
        {
            _genreRepository = genreRepository;
        }

        public void AddGenre(GenreDto dto)      //shto prima GenreDto dto ( clasa )
        {
            if(string.IsNullOrEmpty(dto.Name))          //na tuka moze nekakva logika da se stava
            {
                throw new Exception ("Name cannot be found");
            }

            // vo ovoj del se polni Genre vid na modelot
            Genre entity = new Genre();
            entity.Name = dto.Name;


            _genreRepository.Add(entity);
            _genreRepository.Save();
        }


    }
}
