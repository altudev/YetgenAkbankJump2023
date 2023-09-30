using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJump.OOPConsole.Common
{
    public interface IDeletedByEntity
    {
        public string DeletedByUserId { get; set; }
        public DateTimeOffset DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
