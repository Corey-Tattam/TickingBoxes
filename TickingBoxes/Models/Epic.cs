using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TickingBoxes.Models
{
    public class Epic : ICompletableTask
    {

        #region " - - - - - - - ICompletableTask Implementation - - - - - - - "

        public string TaskIdentifier { get; set; }

        public TaskStateEnum TaskState { get; set; } = TaskStateEnum.ToDo;

        #endregion //ICompletableTask Implementation

        #region " - - - - - - - Properties - - - - - - - "

        public int EpicID { get; set; }

        public int ProjectID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }        


        // --------------------------------------------------------------------------------
        // Navigation Properties

        public Project Project { get; set; }

        public List<Story> Stories { get; set; }        

        #endregion //Properties

    } //Epic
}
