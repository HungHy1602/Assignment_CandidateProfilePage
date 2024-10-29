using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Candidate_BuisinessObjects;

public partial class CandidateProfile
{
    [Key]
    public string CandidateId { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public DateTime? Birthday { get; set; }

    public string? ProfileShortDescription { get; set; }

    public string? ProfileUrl { get; set; }

    public string? PostingId { get; set; }

    public virtual JobPosting? Posting { get; set; }
}
