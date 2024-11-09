using System;
using System.Collections.Generic;

public class Claim
{
    public int ClaimID { get; set; }
    public string LecturerName { get; set; }
    public DateTime DateSubmitted { get; set; }
    public decimal HoursWorked { get; set; }
    public decimal HourlyRate { get; set; }
    public decimal TotalAmount => HoursWorked * HourlyRate;
    public ICollection<SupportingDocument> SupportingDocuments { get; set; }
}
