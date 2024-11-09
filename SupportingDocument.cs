public class SupportingDocument
{
    public int SupportingDocumentID { get; set; }
    public int ClaimID { get; set; }
    public string FilePath { get; set; }
    public Claim Claim { get; set; }
}
