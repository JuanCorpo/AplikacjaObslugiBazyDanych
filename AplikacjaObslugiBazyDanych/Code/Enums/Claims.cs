using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaObslugiBazyDanych.Code.Enums
{
    public enum Claims
    {
        AddProducts = 1,
        EditProducts = 2,
        RemoveProducts = 3,

        AddCustomers = 4,
        EditCustomers = 5,
        RemoveCustomers = 6,

        PlaceOrders = 7,
        EditOrders = 8,

        AddEmployee = 9,
        EditEmployee = 10,
        RemoveEmployee = 11,

        RemoveOrders = 12,

        EditRoles = 13,
        EditCategories = 14,
        EditStatuses = 15,
        EditParameterTypes = 16,
    }
}