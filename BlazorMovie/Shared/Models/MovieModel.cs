using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovie.Shared.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleBrief
        {
            get
            {
                if (string.IsNullOrEmpty(Title))
                    return null;

                if (Title.Length > 60)
                    return Title.Substring(0, 60) + "...";

                return Title;
            }
        }
        public DateTime Release { get; set; }
        public string Poster { get; set; }
    }
}
