﻿using CultureDemo.Models.User;
using System.ComponentModel.DataAnnotations;

namespace CultureDemo.Models.Case
{
    public class CaseBO : UserBO
    {
        [Required(ErrorMessage = "CaseNameRequired")]
        [Display(Name = "CaseName")]
        public string Case_Name { get; set; } = "";

        [Required(ErrorMessage = "CaseDescriptionRequired")]
        [Display(Name = "CaseDescription")]
        public string Case_Description { get; set; } = "";

        [Display(Name = "CaseStatus")]
        public string Case_Status { get; set; } = "";

        [Display(Name = "CaseCreatedDateT")]
        public string Case_CreatedDateT { get; set; } = "";

        [Display(Name = "CaseModifiedDateT")]
        public string Case_ModifiedDateT { get; set; } = "";
    }
}
