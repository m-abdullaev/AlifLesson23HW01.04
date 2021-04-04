using System;
using System.Collections.Generic;

#nullable disable

namespace AlifLesson23HW01._04.EFPersonDataContext
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string EmpCode { get; set; }
        public string Position { get; set; }
        public string OfficeLocation { get; set; }
    }
}
