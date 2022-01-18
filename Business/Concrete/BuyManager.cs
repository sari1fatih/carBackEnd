using Business.Abstract;
using Business.Contants;
using Core.Aspects.Autofac.Transaction;
using Core.Utilities.Result.Base.Abstract;
using Core.Utilities.Result.Success;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Business.Concrete
{
    public class BuyManager : IBuyService
    {
        private IBuyDal _buyDal;
        private IMyTransactionDal _myTransactionDal;

        public BuyManager(IBuyDal buyDal, IMyTransactionDal myTransactionDal)
        {
            _buyDal = buyDal;
            _myTransactionDal = myTransactionDal;
        }
        [TransactionScopeAspect]
        public IResult Add(Buy buy)
        {
             _buyDal.Add(buy);
            MyTransaction myTransaction = new MyTransaction();
            myTransaction.Message = buy.Message;
            myTransaction.BuyId = buy.Id;
            _myTransactionDal.Add(myTransaction);
            return new SuccessResult(Messages.BuyAdded);

        }
    }
}
