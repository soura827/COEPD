using System;
using System.Web.UI.WebControls;

namespace BusinessLayer
{
    public class clsUtility
    {
        public clsUtility()
        {

        }

        public enum Role
        {
            Admin = 1,
            Employee = 2,
            Participant = 3,
            // HR=6,
        }

        public void LoadDays(DropDownList ddl)
        {
            ListItem lItem;
            for (int cnt = 1; cnt <= 31; cnt++)
            {
                lItem = new ListItem(cnt.ToString(), cnt.ToString());
                ddl.Items.Add(lItem);
            }
            ddl.Items.Insert(0, new ListItem("Day", ""));
        }

        public void LoadMonths(DropDownList ddl)
        {
            ddl.Items.Add(new ListItem("Month", ""));
            ddl.Items.Add(new ListItem("1", "1"));
            ddl.Items.Add(new ListItem("2", "2"));
            ddl.Items.Add(new ListItem("3", "3"));
            ddl.Items.Add(new ListItem("4", "4"));
            ddl.Items.Add(new ListItem("5", "5"));
            ddl.Items.Add(new ListItem("6", "6"));
            ddl.Items.Add(new ListItem("7", "7"));
            ddl.Items.Add(new ListItem("8", "8"));
            ddl.Items.Add(new ListItem("9", "9"));
            ddl.Items.Add(new ListItem("10", "10"));
            ddl.Items.Add(new ListItem("11", "11"));
            ddl.Items.Add(new ListItem("12", "12"));
        }

        public void LoadDOBYear(DropDownList ddl)
        {
            int cYear;
            int tYear;
            cYear = Convert.ToInt16(DateTime.Now.Year.ToString());
            tYear = cYear - 100;

            ListItem lItem;
            for (int cnt = tYear; cnt <= cYear + 1; cnt++)
            {
                lItem = new ListItem(cnt.ToString(), cnt.ToString());
                ddl.Items.Add(lItem);
            }
            ddl.Items.Insert(0, new ListItem("Year", ""));
        }

    }
}