using System;
using System.Collections.Generic;
using System.Text;

namespace Queens_Gallery.Models
{
    public class CarouselItem
    {
        public string Title { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string ActiveEra { get; set; } = string.Empty;
        public string PrimaryLocation { get; set; } = string.Empty;
        public string InfoBlurb { get; set; } = string.Empty;
        public string wikiURL {  get; set; } = string.Empty;
    }
}
