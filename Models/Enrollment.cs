//////////////////////////////////////////////////////////////////////////////////////////////////////////
// Date                  Developer                  Description
// 2021-03-03            bellatn                    --followed alongside video 22 and 23 and added components to the website
// 2021-03-12            bellatn                    --added comments to added elements, took screenshots, and submitted L7mvc

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-03-bellatn-dykstra1] - this enum Grade method represents the different grades a student can receive. 
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //tinfo200:[2021-03-03-bellatn-dykstra1] - created and implemented all the properties of the Enrollment class entity. 
        // Although these properties have been implemented and are referenced in several other classes, they are not yet viewable
        // under a tab on the website. The question mark after the Grade property indicates that the property is nullable. 

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}