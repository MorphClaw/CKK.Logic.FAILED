﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public interface IStore
    {
        StoreItem AddStoreItem(Product prod, int quantity);

        StoreItem RemoveStoreItem(int id, int quantity);

        StoreItem FindStoreItemById(int id);

        List<StoreItem> GetStoreItems();
    }
}
