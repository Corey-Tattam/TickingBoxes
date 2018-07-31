using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TickingBoxes.Models
{
    interface ICompletableTask
    {

        #region " - - - - - - - Properties - - - - - - - "

        string TaskIdentifier { get; set; }

        TaskStateEnum TaskState { get; set; }
        
        #endregion //Properties

    } //ICompletableTask

    public enum TaskStateEnum
    {
        ToDo        = 0,
        InProgress  = 1,
        Complete    = 2
    } //TaskStateEnum

}