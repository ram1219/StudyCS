using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinThreadExam
{
	public partial class Form1 : Form
	{
		const int MAXVALUE = 1000000;

		public Form1()
		{
			InitializeComponent();
		}

		private void btn_Click(object sender, EventArgs e)
		{
			Thread th = new Thread(new ThreadStart(Progress));
			th.Start();
			th.Join();
		}

		void Progress()
		{
			// 프로그래스바(다운로드바)의 최소값은 0
			progressBar1.Minimum = 0;
			// 최대값은 100 으로 설정
			progressBar1.Maximum = MAXVALUE;

			// 버튼을 누르면 0부터 100까지 다운로드됨.
			for (int i = 0; i <= MAXVALUE; i++)
				progressBar1.Value = i;
		}
	}
}
