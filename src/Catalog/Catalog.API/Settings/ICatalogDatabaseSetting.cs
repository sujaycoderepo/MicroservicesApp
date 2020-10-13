﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Settings
{
    public interface ICatalogDatabaseSetting
    {
        string ConnectionString { get; set; }
        string  DatabaseName { get; set; }
        string  CollectionName { get; set; }
    }
}
