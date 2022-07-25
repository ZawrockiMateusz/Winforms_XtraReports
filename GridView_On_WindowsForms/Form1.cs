using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GridView_On_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'devExpressReportTestDataSet.zamowienia' table. You can move, or remove it, as needed.
            this.zamowieniaTableAdapter.Fill(this.devExpressReportTestDataSet.zamowienia);

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Create new Reprot
            XtraReport2 report = new XtraReport2();

            //Make an instance of Data and set the properties of selected rows
            report.DataSource = CreateData2();

            //Display Report
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        public List<Data> CreateData2()
        {
            ArrayList rows = new ArrayList();

            // Add the selected rows to the list.
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
            }

            //Create a list based on Data Class
            List<Data> data = new List<Data>();

            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i] as DataRow;

                //Fill the list
                data.Add(new Data() { Id = (int)row["id"], Numer_Zamowienia = (int)row["numer_zamowienia"], Opis = (string)row["opis"], Nazwa_Klienta = (string)row["nazwa_klienta"] });

            }
            return data;
        }
    }
}
