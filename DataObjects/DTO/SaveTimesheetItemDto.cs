using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.DTO
{
    public class SaveTimesheetItemDto
    {
        public TimesheetDTO TimesheetData { get; set; }
        public TimesheetItemsDTO TimesheetItem { get; set; }
    }
}
