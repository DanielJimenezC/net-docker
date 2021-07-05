using System;
using System.Data;

namespace luzdelsur.web.domain
{
    public class DoProject
    {
        DataTable dataTable;

        public DoProject()
        {
            dataTable = new DataTable();
        }

        public DataTable GetProjects()
        {
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Supervisor");
            dataTable.Columns.Add("Business");
            dataTable.Columns.Add("Domain");
            dataTable.Columns.Add("CreatedAt");

            var row = dataTable.NewRow();
            row["Id"] = "1";
            row["Name"] = "Proyecto A";
            row["Supervisor"] = "CTAIRA";
            row["Business"] = "7";
            row["Domain"] = "LDS";
            row["CreatedAt"] = "2021-07-02";

            var row2 = dataTable.NewRow();
            row2["Id"] = "2";
            row2["Name"] = "Proyecto B";
            row2["Supervisor"] = "KCAHUANA";
            row2["Business"] = "7";
            row2["Domain"] = "LDS";
            row2["CreatedAt"] = "2021-07-02";

            var row3 = dataTable.NewRow();
            row3["Id"] = "3";
            row3["Name"] = "Proyecto C";
            row3["Supervisor"] = "DAJIMENE";
            row3["Business"] = "7";
            row3["Domain"] = "LDS";
            row3["CreatedAt"] = "2021-07-02";

            dataTable.Rows.Add(row);
            dataTable.Rows.Add(row2);
            dataTable.Rows.Add(row3);

            return dataTable;
        }
    }
}
