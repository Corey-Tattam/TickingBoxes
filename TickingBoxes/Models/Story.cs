using System.Collections.Generic;

namespace TickingBoxes.Models
{

    public class Story : ICompletableTask
    {

        #region " - - - - - - - Enumerations - - - - - - - "

        public enum StoryTypeEnum
        {
            Feature = 0,
            Bug     = 1,
            Problem = 2
        } //StoryTypeEnum

        #endregion //Enumerations

        #region " - - - - - - - ICompletableTask Implementation - - - - - - - "

        public string TaskIdentifier { get; set; }

        public TaskStateEnum TaskState { get; set; } = TaskStateEnum.ToDo;

        #endregion //ICompletableTask Implementation

        #region " - - - - - - - Properties - - - - - - - "

        public int StoryID { get; set; }

        public int? EpicID { get; set; }

        public int ProjectID { get; set; }

        public string Description { get; set; }

        public string Summary { get; set; }        


        // --------------------------------------------------------------------------------
        // Navigation Properties

        public Project Project { get; set; }

        public Epic Epic { get; set; }

        public List<SubTask> SubTasks { get; set; }

        #endregion //Properties

    } //Story
}
