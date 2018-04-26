﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public interface IDataReaderMappper<T>
    {
        List<T> ToList(SqlDataReader dataTable);
    }
}
