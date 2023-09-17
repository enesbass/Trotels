using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.BL.Abstract;
using Trotels.DAL.Repository.Abstract;
using Trotels.Entity.Concrete;

namespace Trotels.BL.Concrete
{
    public class EmployeeManager : BaseManager<Employee>, IEmployeeManager
    {
        public EmployeeManager(IEmployeeRepository repository) : base(repository)
        {
        }
    }
}
