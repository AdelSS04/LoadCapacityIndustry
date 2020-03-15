using BEL;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using DAL;

namespace SafranCotChargeCapa
{
	public partial class Test : Form
	{
		public Test()
		{
			InitializeComponent();
		}

		private void Test_Load(object sender, EventArgs e)
		{

		}
		DataTableCollection tableCollection;
		DataSet ds = null;
		public DataSet FlipDataSet(DataSet my_DataSet)
		{
			DataSet ds = new DataSet();


			foreach (System.Data.DataTable dt in my_DataSet.Tables)
			{
				System.Data.DataTable table = new System.Data.DataTable();

				for (int i = 0; i <= dt.Rows.Count; i++)
				{ table.Columns.Add(Convert.ToString(i)); }

				DataRow r;
				for (int k = 0; k < dt.Columns.Count; k++)
				{
					r = table.NewRow();
					r[0] = dt.Columns[k].ToString();
					for (int j = 1; j <= dt.Rows.Count; j++)
					{ r[j] = dt.Rows[j - 1][k]; }
					table.Rows.Add(r);
				}
				ds.Tables.Add(table);
			}

			return ds;
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			/*	Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
				Workbook myWorkBook = null;
				Worksheet mySheet = null;
				Range dataRange = null;
				string kk="";
				myWorkBook = xlapp.Workbooks.Open(@"E:\Classeur211223322.xlsx");
				mySheet = (Worksheet)myWorkBook.Sheets["F1"];
			//	MessageBox.Show(mySheet.UsedRange.Rows.Count.ToString());
				for (int row = 1; row < mySheet.UsedRange.Rows.Count; row++) // Count is 1048576 instead of 4
				{
					for (int col = 1; col < mySheet.UsedRange.Columns.Count; col++) // Count is 16384 instead of 4
					{
						dataRange = (Range)mySheet.Cells[row, col];
						kk=String.Format(dataRange.Value2.ToString() + " ");
					}
					MessageBox.Show(kk);
				}


				//Microsoft.Office.Interop.Excel ex = new Excel(@"E:\Classeur21122332.xlsx");


				 //string excelpath = @"E:\Classeur21122332.xlsx";
			Microsoft.Office.Interop.Excel.Application appp = new Microsoft.Office.Interop.Excel.Application();
			Workbook wkb = appp.Workbooks.Open(excelpath);
			Range rng1 = Worksheet.



			List < List<string> > myList = new List<List<string>>();


			List<string> dmm = new List<string>();
			//string dm;
			
			using (OleDbConnection connection = new OleDbConnection(
	   "Provider=Microsoft.ACE.OLEDB.12.0;data source=E:/Classeur21122332.xlsx;Extended Properties=Excel 12.0; "))
			using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM [F1$E:G] ", connection))
			{
				connection.Open();
				using (OleDbDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						dmm.Add(reader.ToString());

						dm = new Calendrier
						{
							DateWeek = Convert.ToInt32(reader[3]),
							DateYear = Convert.ToInt32(reader[2]),
							OpenDayPerWeek = Convert.ToInt32(reader[0]),
							DateID = Convert.ToInt32(reader[1]),


						};
						dmm.Add(dm);



						//myList.Add(dmm);
					}
				}
				//	dataGridView1.DataSource = dataTable;
				//	dataGridView1.DataBind();
				//dataGridView1.DataSource = myList; 
				*/
			OleDbConnection con = new OleDbConnection("	Provider = Microsoft.ACE.OLEDB.12.0; data source = E:/Classeur211223322.xlsx; Extended Properties = Excel 12.0; ");
			StringBuilder stbQuery = new StringBuilder();
			//stbQuery.Append("SELECT * FROM[F1$B7:BE183] ");
			/*stbQuery.Append("SELECT * FROM[F1$E4:BD4] ");
			OleDbDataAdapter adp = new OleDbDataAdapter(stbQuery.ToString(), con);
			DataSet dsXLS = new DataSet();
			adp.Fill(dsXLS);

			MessageBox.Show("yy");
			DataView dvEmp = new DataView(dsXLS.Tables[0]);
			DataSet new_ds = FlipDataSet(dsXLS);
			DataView my_DataView = new_ds.Tables[0].DefaultView;
			this.dataGridView1.DataSource = my_DataView;*/
			stbQuery.Append("SELECT * FROM[F1$B6:BD183] ");
			OleDbDataAdapter adpp = new OleDbDataAdapter(stbQuery.ToString(), con);
			DataSet dsXLSi = new DataSet();
			adpp.Fill(dsXLSi);
			DataView dvEmpi = new DataView(dsXLSi.Tables[0]);
			this.dataGridView1.DataSource = dvEmpi;
			List<string> lala = dataGridView1.DataSource as List<string>;
			DemandeDBO.DeletAllOperationTime(Convert.ToDateTime(dataGridView1.Columns[5].Name).Year);
			//DemandeDBO.Restee();
			for (int j = 1; j < (dataGridView1.RowCount - 1); j++)
			{
				for (int i = 3; i < dataGridView1.ColumnCount; i++)
				{
					Demande dd = new Demande
					{ YearDem = Convert.ToDateTime(dataGridView1.Columns[i].Name).Year,
					WeekDem = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Convert.ToDateTime(dataGridView1.Columns[i].Name), CalendarWeekRule.FirstDay, DayOfWeek.Monday) ,
					DemandeQTE = int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString()),
					ProductID = dataGridView1.Rows[j].Cells[0].Value.ToString()
					};
					try
					{
						

						DemandeDBO.AddDemande(dd);
					
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					}
			}
			MessageBox.Show("done");
			

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				OleDbConnection con = new OleDbConnection("	Provider = Microsoft.ACE.OLEDB.12.0; data source = E:/Classeur211223322.xlsx; Extended Properties = Excel 12.0; ");
				StringBuilder stbQuery = new StringBuilder();
				stbQuery.Append("SELECT * FROM[F2$A1:C53] ");
				OleDbDataAdapter adpp = new OleDbDataAdapter(stbQuery.ToString(), con);
				DataSet dsXLSi = new DataSet();
				adpp.Fill(dsXLSi);
				DataView dvEmpi = new DataView(dsXLSi.Tables[0]);
				this.dataGridView1.DataSource = dvEmpi;
				List<Calendrier> lala = new List<Calendrier>();
				Calendrier cl;
				//MessageBox.Show(dataGridView1.Rows[1].Cells[1].Value.ToString());
				CalendrierDBO.DeletAllCall(int.Parse(dataGridView1.Rows[1].Cells[1].Value.ToString()));
				for (int j = 0; j < (dataGridView1.RowCount-1 ); j++)
				{
					
						Calendrier dd = new Calendrier
						{
							DateWeek = int.Parse(dataGridView1.Rows[j].Cells[2].Value.ToString()),
							DateYear = int.Parse(dataGridView1.Rows[j].Cells[1].Value.ToString()),
							OpenDayPerWeek = int.Parse(dataGridView1.Rows[j].Cells[0].Value.ToString()),
						};

						CalendrierDBO.SetCal(dd);

					
			
				}MessageBox.Show("done");
			}


			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
				}
			}

		}