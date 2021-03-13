//////////////////////////////////////////////////////////////////////////////////////////////////////////
// Date                  Developer                  Description
// 2021-03-03            bellatn                    --followed alongside video 22 and 23 and added components to the website
// 2021-03-12            bellatn                    --added comments to added elements, took screenshots, and submitted L7mvc

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //tinfo200:[2021-03-03-bellatn-dykstra1] - began implementing the properties of the Course class entity. Similarily to the 
        // Enrollment class, these properties have been established but are not yet viewable anywhere on the webite. The Enrollments
        // property shows that the Course class has a one to many relationship with all Enrollment entities. 

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
