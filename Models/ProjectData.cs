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
                ThumbnailUrl = ""
            },
            new Project
            {
                Id = 2,
                Title = "16Personalities Copy",
                GithubUrl = "https://github.com/Kianneo/PersonalityTest",
                Description = "A practice website imitating the 16Personalities test. Returns an actual result based on your answers.",
                ThumbnailUrl = "https://placehold.co/600x400/FBF3E1/1F2A44?text=16Personalities"
            },
            new Project
            {
                Id = 3,
                Title = "MVC Model Binding",
                GithubUrl = "https://github.com/eireneysabelkarunungan-lgtm/IT_ELECTIVE_BSIT_-31E2-_-karunungan_eirene",
                Description = "A simple login simulation using MVC model binding and data annotations to validate input.",
                ThumbnailUrl = "https://placehold.co/600x400/FBF3E1/1F2A44?text=Model+Binding"
            },
            new Project
            {
                Id = 4,
                Title = "YouTube Playlist Builder",
                GithubUrl = "https://github.com/eireneysabelkarunungan-lgtm/IT_ELECTIVE_2_MIDTERM_Q2_karunungan_Eirene",
                Description = "A simple YouTube playlist builder web application using DTOs.",
                ThumbnailUrl = "https://placehold.co/600x400/FBF3E1/1F2A44?text=Playlist+Builder"
            },
            new Project
            {
                Id = 5,
                Title = "Vehicle Monitoring System",
                GithubUrl = "https://github.com/eireneysabelkarunungan-lgtm/IT_ELECTIVE_2_MIDTERM_EXAM_1_KarununganEirene",
                Description = "A web system used to register, log in, and monitor customer vehicles from check-in until release.",
                ThumbnailUrl = "https://placehold.co/600x400/FBF3E1/1F2A44?text=Vehicle+Monitoring"
            },

        };
    }
}