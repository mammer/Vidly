using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewCustomerViewModel
    {
        //I don't use List<T> because I don't need add or delete methode just Iterate MembershipType.
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }

    }
}