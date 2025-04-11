namespace registrar_hima0013.Models
{
    public class Registration
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        // Navigation properties (optional but recommended)
        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
