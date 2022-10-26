using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算車資
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblFee.Visible = false;
			lblReason.Visible = false;
		}

		private void btnCaculate_Click(object sender, EventArgs e)
		{
			string Value = txtAge.Text;
			int age=Convert.ToInt32(Value);
			bool gender = rdBtnMale.Checked;
			int fee;

			if (age <= 3)
			{
				fee = 0;
				lblFee.Text = fee.ToString();
				lblReason.Text = "未超過3歲";
			}
			else if (gender == true && age >= 70)
			{
				fee = 2;
				lblFee.Text = fee.ToString();
				lblReason.Text = "70歲以上男性";
			}
			else if (gender == false && age >= 60)
			{
				fee = 3;
				lblFee.Text = fee.ToString();
				lblReason.Text = "60歲以上女性";
			}
			else
			{
				fee = 15;
				lblFee.Text = fee.ToString();
				lblReason.Text = "不符合優惠資格";
			}

			lblFee.Visible = true;
			lblReason.Visible = true;
		}
	}
}
