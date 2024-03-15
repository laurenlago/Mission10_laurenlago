using System;
using System.Collections.Generic;

namespace API2_Mission10_Lauren.Data;

public partial class BowlerScore
{
    public int MatchId { get; set; }

    public short GameNumber { get; set; }

    public int BowlerId { get; set; }

    public short? RawScore { get; set; }

    public short? HandiCapScore { get; set; }

    public bool WonGame { get; set; }

    public virtual Bowler Bowler { get; set; } = null!;
}
