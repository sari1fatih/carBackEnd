using Core.Utilities.Result.Base.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBuyService
    {
        IResult Add(Buy buy);
    }
}
