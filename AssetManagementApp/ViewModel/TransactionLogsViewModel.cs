﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementApp.ViewModel
{
   public class TransactionLogViewModel : ViewModelBase
    {
        public string Username { get; set; }
        public string ItemName { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }

        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
