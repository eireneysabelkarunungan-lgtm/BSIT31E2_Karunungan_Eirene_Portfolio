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
                ThumbnailUrl = "/images/draftport.png"
            },
            new Project
            {
                Id = 2,
                Title = "16Personalities Copy",
                GithubUrl = "https://github.com/Kianneo/PersonalityTest",
                Description = "A practice website imitating the 16Personalities test. Returns an actual result based on your answers.",
                ThumbnailUrl = "/images/16personalities.png"
            },
            new Project
            {
                Id = 3,
                Title = "MVC Model Binding",
                GithubUrl = "https://github.com/eireneysabelkarunungan-lgtm/IT_ELECTIVE_BSIT_-31E2-_-karunungan_eirene",
                Description = "A simple login simulation using MVC model binding and data annotations to validate input.",
                ThumbnailUrl = "/images/modelbinding.png"
            },
            new Project
            {
                Id = 4,
                Title = "YouTube Playlist Builder",
                GithubUrl = "https://github.com/eireneysabelkarunungan-lgtm/IT_ELECTIVE_2_MIDTERM_Q2_karunungan_Eirene",
                Description = "A simple YouTube playlist builder web application using DTOs.",
                ThumbnailUrl = "/images/ytbuilder.png"
            },
            new Project
            {
                Id = 5,
                Title = "Vehicle Monitoring System",
                GithubUrl = "https://github.com/eireneysabelkarunungan-lgtm/IT_ELECTIVE_2_MIDTERM_EXAM_1_KarununganEirene",
                Description = "A web system used to register, log in, and monitor customer vehicles from check-in until release.",
                ThumbnailUrl = "/images/vehicle.png"
            },
            new Project
                {
                    Id = 6,
                    Title = "Retro Game Haven POS",
                    GithubUrl = "https://github.com/eireneysabelkarunungan-lgtm/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Karunungan_EireneYsabel",
                    Description = "A web-based Point of Sale application for cashiers at a retro gaming shop — browse items, build a cart, update quantities, checkout, and review past sales receipts.",
                    ThumbnailUrl = "/images/retro.png"
                },
            new Project
            {
                Id = 7,
                Title = "MVC Authentication",
                GithubUrl = "https://github.com/eireneysabelkarunungan-lgtm/IT_ELECTIVE_2_MIDTERM_Q3_Karunungan_Eirene",
                Description = "A web system that practices guarding pages by locking users out after a limited number of failed login attempts.",
                ThumbnailUrl = "/images/mvcauth.png"
            },
            new Project
            {
                Id = 8,
                Title = "EF Core Database Project",
                GithubUrl = "https://github.com/R3n3n/IT_ELECTIVE_PREFINALS_PROJECT",
                Description = "A web system that displays accurate information from a specified connected database using Entity Framework Core.",
                ThumbnailUrl = "/images/efcore.png"
            },
        };
    }
}