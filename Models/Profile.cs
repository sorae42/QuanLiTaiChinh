﻿using Microsoft.VisualBasic.ApplicationServices;
using QuanLiTaiChinh.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTaiChinh.Models
{
    public class Profile
    {
        private Profile() { }

        public static string GetName(int profileID)
        {
            string? result = DataProvider.ExecuteScalar("SELECT profileName FROM Profiles WHERE profileId = @id", profileID) as string;
            if (result != null)
                return result;
            return "Guest";
        }

        public static object? GetPrefs(int profileID) 
        {
            DataTable? result = DataProvider.ExecuteReader("SELECT profilePrefDefaultName, profilePrefSpendingLimit, profilePrefStartupTab FROM Profiles WHERE profileId = @id", profileID);

            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    return row;
                }
            }

            return null;
        }

    }
}