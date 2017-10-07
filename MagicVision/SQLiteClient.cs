﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKMEye
{
    class SQLiteClient
    {

        private readonly SQLiteConnection sql;

        public SQLiteClient(string SqlConString)
        {
            sql = new SQLiteConnection(SqlConString);
            sql.Open();
        }

        public DataTable dbResult(string query)
        {

            var selectDT = new DataTable();

            var dataAd = new SQLiteDataAdapter(query, sql);

            dataAd.Fill(selectDT);

            return selectDT;
        }
    }
}