using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_DIO_Series.Classes
{
    public class Series
    {
        public class Serie : BaseEntity
        {
            private Gender Gender {get ; set ;}
            private string Title {get ; set ;}
            private string Description {get ; set;}
            private int Year {get; set; }

            private bool Deleted {get; set;}

            public Serie (int id, Gender gender, string title, string description, int year)
            {
                this.Id = id;
                this.Gender = gender;
                this.Title = title;
                this.Description = description;
                this.Year = year;
                this.Deleted = false;
            }

            public override string ToString()
            {
                string _return = "";
                _return += "Genero: " + this.Gender + Environment.NewLine;
                _return += "Título: " + this.Title + Environment.NewLine;
                _return += "Descrição: " + this.Description + Environment.NewLine;
                _return += "Ano: " + this.Year + Environment.NewLine;
                _return += "Excluida: " + this.Deleted;
                return _return;
            }

            public string ReturnTitle()
            {
                return this.Title;
            }

            public int ReturnId()
            {
                return this.Id;
            }

            public bool ReturnDeleted()
            {
                return this.Deleted;
            }

            public void Delete()
            {
                this.Deleted = true;
            }            
            
        }
    }
}