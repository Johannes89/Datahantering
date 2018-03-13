using Datahantering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Datahantering
{
    public class MovieViewModel 
    {
        private int id;
        private string name;
        private int? grade;
        private int length;
        private string summary;
        private string actor;
        

        public int ID { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int? Grade { get { return this.grade; } set { this.grade = value; } }
        public int Length { get { return this.length; } set { this.length = value; } }
        public string Summary { get { return this.summary; } set { this.summary = value; } }
        public string Actor { get { return this.actor; } set { this.actor = value; } }
        public bool isChecked { get; set; }


        public MovieViewModel(int id, string name, int grade, int length, string summary, string actor)
        {
            this.id = id;
            this.name = name;
            this.grade = grade;
            this.length = length;
            this.summary = summary;
            this.actor = actor;


        }
        public MovieViewModel()
        {

        }
    }
}