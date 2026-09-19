using System.Collections.Generic;

namespace BSIT31E2_Karunungan_Eirene_Portfolio.Models
{
    public static class CommentStore
    {
        public static List<Comment> All { get; } = new List<Comment>();

        public static List<Comment> ForProject(int projectId)
        {
            return All.Where(c => c.ProjectId == projectId)
                      .OrderByDescending(c => c.PostedAt)
                      .ToList();
        }
    }
}