using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace BlukuploadWinform
{
    public partial class Form1 : Form
    {
        public DataTable dts;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string url = "https://archives.nseindia.com/products/content/";
                string filetype = ".csv";
                var dates = dateTimePicker1.Value.ToString("ddMMyyyy");
                string filename = "sec_bhavdata_full_";
                string texts = url + filename + dates + filetype;
                //string Url2 = "DownloadedFile.csv";
                string Savepath = @"D:\" + dates + ".csv";

                WebClient webClient = new WebClient();
                webClient.DownloadFile(texts, Savepath);

                TbSearch.Text = texts;
                MessageBox.Show("file Downloading Successfully", "Downloading", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TbSearch.Clear();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(openFileDialog1.FileName);
                    TbSearch.Text = openFileDialog1.FileName;

                }
                BindDataCSV();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BindDataCSV()
        {

            List<string[]> rows = System.IO.File.ReadAllLines(openFileDialog1.FileName).Select(x => x.Split(',')).ToList();
            System.Data.DataTable dt = new System.Data.DataTable();
            List<string> headerNames = rows[0].ToList();
            foreach (var header in headerNames)
            {
                dt.Columns.Add(header.Trim());
            }
            foreach (var x in rows.Skip(1))
            {
                if (x.SequenceEqual(headerNames))     //linq to check if 2 lists are have the same elements (perfect for strings)
                    continue;                         //skip the row with repeated headers
                dt.Rows.Add(x);
            }
            dataGridView1.DataSource = dt;
            dts = dt;
            var d = dt.Rows.Count;
            lblTotal.Text = string.Format("Total Rows : {0}", d);

        }


        private void btnUploadDB_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CAFH5JV;Initial Catalog=crudoperation;Integrated Security=True");
            try
            {

                SqlBulkCopy blu = new SqlBulkCopy(con);



                DataTable dt = dts;

                blu.DestinationTableName = "crudoperation.dbo.Tblcsvfile";
                //blu.ColumnMappings.Add("SYMBOL", "[SYMBOL]");
                //blu.ColumnMappings.Add("SERIES", "[SERIES]");
                ////blu.ColumnMappings.Add(" ", "[SERIES]");
                //blu.ColumnMappings.Add("DATE1", "[DATE1]");
                //blu.ColumnMappings.Add("PREV_CLOSE", "[PREV_CLOSE]");
                //blu.ColumnMappings.Add("OPEN_PRICE", "[OPEN_PRICE]");
                //blu.ColumnMappings.Add("HIGH_PRICE", "[HIGH_PRICE]");
                //blu.ColumnMappings.Add("LOW_PRICE", "[LOW_PRICE]");
                //blu.ColumnMappings.Add("LAST_PRICE", "[LAST_PRICE]");
                //blu.ColumnMappings.Add("CLOSE_PRICE", "[CLOSE_PRICE]");
                //blu.ColumnMappings.Add("AVG_PRICE", "[AVG_PRICE]");
                //blu.ColumnMappings.Add("TTL_TRD_QNTY", "[TTL_TRD_QNTY]");
                //blu.ColumnMappings.Add("TURNOVER_LACS", "[TURNOVER_LACS]");
                //blu.ColumnMappings.Add("NO_OF_TRADES", "[NO_OF_TRADES]");
                //blu.ColumnMappings.Add("DELIV_QTY", "[DELIV_QTY]");
                //blu.ColumnMappings.Add("DELIV_PER", "[DELIV_PER]");


                con.Open();
                blu.WriteToServer(dt);
                con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}