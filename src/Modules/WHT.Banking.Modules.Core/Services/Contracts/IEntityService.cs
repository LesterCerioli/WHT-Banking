using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHT.Banking.Modules.Core.Models;

namespace WHT.Banking.Modules.Core.Services.Contracts
{
    public interface IEntityService
    {
        string ToSafeSlug(string slug, long entityid, string entityTypeId);

        Entity Get(long entityId, string entityTypeid);

        void Add(string name, string slug, long entityId, string entityTypeId);

        void Update(string newName, string newSlug, long entityId, string entityTypeId);

        Task Remove(long entityId, string entityTypeId);
    }
}
