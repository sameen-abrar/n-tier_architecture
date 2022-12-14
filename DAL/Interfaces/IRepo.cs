using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo <CLASS, ID, RESULT>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        CLASS Add(CLASS obj);
        bool Delete(ID id);
        bool update(CLASS obj);

    }
}
