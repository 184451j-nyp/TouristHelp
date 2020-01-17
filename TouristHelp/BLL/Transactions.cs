using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TouristHelp.DAL;

namespace TouristHelp.BLL
{
    public class Transactions
    {
        public int voucherGen_id { get; set; }
        public string voucherStats { get; set; }
        public DateTime voucherExpiry { get; set; }
        public bool filterTransaction { get; set; }
        public int confirmCode { get; set; }
        public int user_id { get; set; }
        public DateTime voucherDate { get; set; }
        public int voucherTotalCost { get; set; }


        public Transactions()
        {
        }



        public Transactions(int vouchergenid, string voucherstats, DateTime voucherexpiry, bool filtertransaction, int confirmcode, int id, DateTime voucherdate, int vouchertotalcost)
        {
            this.voucherGen_id = vouchergenid;
            this.voucherStats = voucherstats;
            this.voucherExpiry = voucherexpiry;
            this.filterTransaction = filtertransaction;
            this.confirmCode = confirmcode;
            this.user_id = id;
            this.voucherDate = voucherdate;
            this.voucherTotalCost = vouchertotalcost;
        }

        public Transactions GetTransactionByid(string transId)
        {
            TransactionDAO dao = new TransactionDAO();
            return dao.SelectByAccount(transId);


        }
    }

    

}