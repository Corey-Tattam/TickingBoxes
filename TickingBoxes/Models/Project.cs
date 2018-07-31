using System.Collections.Generic;

namespace TickingBoxes.Models
{
    public class Project
    {

        #region " - - - - - - - Properties - - - - - - - "

        public int ProjectID { get; set; }

        public string Name { get; set; }

        public string Prefix { get; set; }

        public int Seed { get; set; }


        // --------------------------------------------------------------------------------
        // Navigation Properties

        public List<Epic> Epics { get; set; }

        public List<Story> Stories { get; set; }

        #endregion //Properties

    } //Project
}
