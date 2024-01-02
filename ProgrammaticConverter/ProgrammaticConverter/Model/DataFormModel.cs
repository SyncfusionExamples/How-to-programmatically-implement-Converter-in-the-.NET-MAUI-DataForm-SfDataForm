using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace ProgrammaticConverter
{
    public class DataFormModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataFormValueConverter(typeof(Converter))]
        [DataType(DataType.Date)]
        public string DateTime { get; set; }
        public string Email { get; set; }
        public string CourseCompleted { get; set; }
    }
}