using System;
using MineCraft.Core;

namespace MineCraft.ApplicationLayer.Queries
{
    public class InspectQuery : SystemOperationBase, IQuery<string>
    {
        public string Id { get; }

        public InspectQuery(MiningSystem system, string id) : base(system)
        {
            this.Id = id;
        }

        public string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
