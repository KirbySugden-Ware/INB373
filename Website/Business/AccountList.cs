using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Data;

namespace Business {

    [System.ComponentModel.DataObject]
    class AccountList {

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<AccountList> getAllAccounts() {
            List<AccountList> accountsList = new List<AccountList>();
           
            return accountsList;
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        public static void insertAccount(AccountList account) {

            System.Diagnostics.Trace.WriteLine(account, "Insert");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static void deleteAccount(AccountList account) {

            System.Diagnostics.Trace.WriteLine(account, "Delete");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public static void updateAccount(AccountList account) {

            System.Diagnostics.Trace.WriteLine(account, "Update");
        }
    }
}
