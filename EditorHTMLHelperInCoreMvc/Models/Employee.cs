using System.Reflection.Metadata.Ecma335;

namespace EditorHTMLHelperInCoreMvc.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name  { get; set; }
        public Gender Gender { get; set; }

        public int Age { get; set; }
        public bool IsNewlyAdded { get; set; }
        public DateTime? DOB { get; set; }

    }
    public enum Gender
    {
        Male, 
        Female
    }
}
