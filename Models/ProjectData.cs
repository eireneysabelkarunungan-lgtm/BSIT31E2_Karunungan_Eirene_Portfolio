using System.Collections.Generic;

namespace BSIT31E2_Karunungan_Eirene_Portfolio.Models
{
    public static class ProjectData
    {
        public static List<Project> All { get; } = new List<Project>
        {
            // I'Ll add projects added one at a time

            new Project
            {
                Id = 1,
                Title = "Draft Portfolio",
                GithubUrl = "https://github.com/eireneysabelkarunungan-lgtm/IT_ELECTIVE_2_Midterm_A1_Karunungan_Eirene",
                Description = "A practice portfolio using Razor views and Bootstrap.",
                ThumbnailUrl = "https://placehold.co/600x400/FBF3E1/1F2A44?text=Draft+Portfolio"
            },
        };
    }
}