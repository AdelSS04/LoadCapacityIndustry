using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace SafranCotChargeCapa
{
	public partial class IlotUpdate : Form
	// MetroFramework.Forms.MetroForm
	{
		public IlotUpdate()
		{
			InitializeComponent();
			var materialSkinManager = MaterialSkinManager.Instance;
			
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

		}
		public void sizeDGV(DataGridView dgv)
		{
			DataGridViewElementStates states = DataGridViewElementStates.None;
			dgv.ScrollBars = ScrollBars.None;
		
	var totalWidth = dgv.Columns.GetColumnsWidth(states) ;
		dgv.ClientSize = new Size(totalWidth, 180);
			groupBox1.ClientSize= new Size(totalWidth+2, 180); 
			for (int i = 0; i < dgv.RowCount ; i++)
			{
				if (i % 2 == 0)
				{
					dgv.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
			
				}
				else
					dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
			}
		
		}
		private void IlotManag_Load(object sender, EventArgs e)
		{
			try
			{
			//	GetIlot
				List<User> ur = UserDBO.GetAllUSer();
				foreach (User u in ur)
				{ checkedListBox1.Items.Add(u.UserID); }
				//
				List<Ilot> il = IlotDBO.GetAllIlot();
			foreach (Ilot i in il)
				metroComboBox1.Items.Add(i.IlotID);
					dataGridView1.DataSource = il;
				sizeDGV(dataGridView1);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void metroLabel1_Click(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			
		}

		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView1.Columns[0].ReadOnly = true;
			dataGridView1.Columns[6].ReadOnly = true;
			List<Ilot> ilF = new List<Ilot>();
			ilF.Add(IlotDBO.GetIlot(metroComboBox1.SelectedItem.ToString()));
	
			dataGridView1.DataSource = ilF;
			sizeDGV(dataGridView1);
			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				if (checkedListBox1.Items[i].ToString() == ilF[0].UserID)
				{ checkedListBox1.SetItemChecked(i, true); }
				else
				{ checkedListBox1.SetItemChecked(i, false); }

			}
			metroComboBox1.ForeColor = Color.Red;
			UpButton.Enabled = true;
			DelButton.Enabled = true;
		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count >= 1)
				e.NewValue = CheckState.Unchecked;
		}

		private void UpButton_Click(object sender, EventArgs e)
		{
			try
			{
				dataGridView1.BeginEdit(true);
				Ilot ur = new Ilot
				{
					IlotName = dataGridView1.Rows[0].Cells[1].Value.ToString(),
					IlotRejectedRate = float.Parse(dataGridView1.Rows[0].Cells[5].Value.ToString()),
					IlotID = metroComboBox1.SelectedItem.ToString(),
					TruancyRate = float.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString()),
					Efficiency = float.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString()),
					CRM = float.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString()),
					UserID = checkedListBox1.SelectedItem.ToString()


				};
				
			if(	IlotDBO.UpdateIlot(ur))
					MessageBox.Show("done !!");
			else
					MessageBox.Show("errore !!");



			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		
		}

		private void DelButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (IlotDBO.DeleteIlot(metroComboBox1.SelectedItem.ToString()))
				{
					metroComboBox1.Items.Clear();
					List<Ilot> il = IlotDBO.GetAllIlot();
					foreach (Ilot i in il)
						metroComboBox1.Items.Add(i.IlotID);
					MessageBox.Show("done");
				}
				else
					MessageBox.Show("404");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
