using System;
using System.Collections.Generic;

namespace API2_Mission10_Lauren.Data;

public partial class MatchGame
{
    public int MatchId { get; set; }

    public short GameNumber { get; set; }

    public int? WinningTeamId { get; set; }

    public virtual TourneyMatch Match { get; set; } = null!;
}
