using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lab10_MovieList
{
    class MovieClass
    {
        //Fields 
        private string title;
        private string category;

        //properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        //Constructor
        public MovieClass() { }
        public MovieClass(string str, string str1)
        {
            title = str;
            category = str1;
        }
    }
}
