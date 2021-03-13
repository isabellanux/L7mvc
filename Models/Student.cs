//////////////////////////////////////////////////////////////////////////////////////////////////////////
// Date                  Developer                  Description
// 2021-03-03            bellatn                    --followed alongside video 22 and 23 and added components to the website
// 2021-03-12            bellatn                    --added comments to added elements, took screenshots, and submitted L7mvc

using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //tinfo200:[2021-03-03-bellatn-dykstra1] - began creating the Student class entity. all the information except for the 
        // ID is configured and can be viewed under the Students tab on the website. The Enrollments property shows that the 
        // Student class has a one to many relationship with all Enrollment entities. 

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
