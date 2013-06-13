// Guids.cs
// MUST match guids.h
using System;

namespace SławomirRosiek.Rosieks_TeamFoundation_TeamExplorer
{
    static class GuidList
    {
        public const string guidRosieks_TeamFoundation_TeamExplorerPkgString = "68968681-4f32-4342-956c-b861e9339966";
        public const string guidRosieks_TeamFoundation_TeamExplorerCmdSetString = "1e02d3fd-4be7-44fc-9b41-65ca83cc702c";

        public static readonly Guid guidRosieks_TeamFoundation_TeamExplorerCmdSet = new Guid(guidRosieks_TeamFoundation_TeamExplorerCmdSetString);
    };
}