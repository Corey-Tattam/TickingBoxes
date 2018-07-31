namespace TickingBoxes.Models
{
    public class SubTask : ICompletableTask
    {

        #region " - - - - - - - ICompletableTask Implementation - - - - - - - "

        public string TaskIdentifier { get; set ; }

        public TaskStateEnum TaskState { get; set; } = TaskStateEnum.ToDo;

        #endregion //ICompletableTask Implementation

        #region " - - - - - - - Properties - - - - - - - "

        public int SubTaskID { get; set; }

        public int StoryID { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public string Summary { get; set; }
        

        // --------------------------------------------------------------------------------
        // Navigation Properties

        public Story Story { get; set; }

        #endregion //Properties

    } //SubTask
}
