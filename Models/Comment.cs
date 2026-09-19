using System;

namespace BSIT31E2_Karunungan_Eirene_Portfolio.Models
{
    public class Comment
    {
        public int ProjectId { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime PostedAt { get; set; } = DateTime.Now;
    }
}