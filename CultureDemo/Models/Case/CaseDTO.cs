﻿namespace CultureDemo.Models.Case
{
    public class CaseDTO
    {
        public string? ExampleObject { get; set; }
        public CaseBO Case { get; set; } = new CaseBO();
        public List<CaseBO>? CaseList { get; set; }
    }
}
