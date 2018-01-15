using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            const int arrayCount = 10;
            Person[] person = new Person[arrayCount];
            for (int i = 0; i < arrayCount; i++)
            {
                person[i] = new Person { Age = i };
            }

            dataGridView1.DataSource = person;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.Columns[e.ColumnIndex].DataPropertyName=="Age")
            {
                e.Value = ((int)e.Value) % 2 == 0 ? "奇" : "偶";
            }
        }
    }
}
