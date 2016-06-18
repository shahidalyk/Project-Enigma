using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Domain
{
    public interface IDataSource
    {
        IQueryable<User> Users { get; }
        IQueryable<Photo> Photos { get; }
    }
}
