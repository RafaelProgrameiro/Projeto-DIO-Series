using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_DIO_Series.Interfaces;
using static Projeto_DIO_Series.Classes.Series;

namespace Projeto_DIO_Series.Classes
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> serieList = new List<Serie>();
        public void Create(Serie entity)
        {
            serieList.Add(entity);
        }

        public void Delete(int id)
        {
            serieList[id].Delete();
        }

        public List<Serie> List()
        {
            return serieList;            
        }

        public int NextId()
        {
             return serieList.Count;
        }

        public Serie ReturnById(int id)
        {
            return serieList[id];
        }

        public void Update(int id, Serie entity)
        {
            serieList[id] = entity;
        }
    }
} 


 

  