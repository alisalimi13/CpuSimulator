using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU
{
    public partial class CPU : Form
    {
        DataTable mem;
        int pc, ir, ac, n, adr;
        public CPU()
        {
            InitializeComponent();

            // Creating Memory
            mem = new DataTable();
            mem.Columns.Add("Address");
            mem.Columns.Add("Contain");
            for (int i = 0; i < 1000; i++)
                mem.Rows.Add();
            for (int i = 0; i < 1000; i++)
            {
                if (i < 10)
                    mem.Rows[i][0] = "00" + i.ToString();
                if (i >= 10 && i < 100)
                    mem.Rows[i][0] = "0" + i.ToString();
                if (i >= 100 && i < 1000)
                    mem.Rows[i][0] = i.ToString();
            }
            for (int i = 0; i < 1000; i++)
                mem.Rows[i][1] = "0000";

            // A Program For CPU
            mem.Rows[0][1] = "0014";
            mem.Rows[1][1] = "2015";
            mem.Rows[2][1] = "1016";
            mem.Rows[3][1] = "3015";
            mem.Rows[4][1] = "1017";
            mem.Rows[5][1] = "4015";
            mem.Rows[6][1] = "1018";
            mem.Rows[7][1] = "5015";
            mem.Rows[8][1] = "1019";
            mem.Rows[9][1] = "6015";
            mem.Rows[10][1] = "1020";
            mem.Rows[11][1] = "7013";
            mem.Rows[12][1] = "7014";
            mem.Rows[13][1] = "8000";
            mem.Rows[14][1] = "0003";
            mem.Rows[15][1] = "0002";

            Memory.DataSource = mem;

            // Initial Value
            PC.Text = "000";
            AC.Text = "0000";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            // Setting Variables and IR Register
            pc = Convert.ToInt32(PC.Text);
            IR.Text = mem.Rows[pc][1].ToString();
            ir = Convert.ToInt32( IR.Text );
            n = ir / 1000;
            adr = ir - (n * 1000);
            ac = Convert.ToInt32(AC.Text);

            // Doing Instruction
            switch (n)
            {
                case 0:
                    ac = Convert.ToInt32(mem.Rows[adr][1]);
                    break;

                case 1:
                    mem.Rows[adr][1] = AC.Text;
                    break;

                case 2:
                    ac = Convert.ToInt32(AC.Text) + Convert.ToInt32(mem.Rows[adr][1]);
                    break;

                case 3:
                    ac = Convert.ToInt32(AC.Text) - Convert.ToInt32(mem.Rows[adr][1]);
                    break;

                case 4:
                    ac = Convert.ToInt32(AC.Text) * Convert.ToInt32(mem.Rows[adr][1]);
                    break;

                case 5:
                    ac = Convert.ToInt32(AC.Text) / Convert.ToInt32(mem.Rows[adr][1]);
                    break;

                case 6:
                    ac = Convert.ToInt32(AC.Text) % Convert.ToInt32(mem.Rows[adr][1]);
                    break;

                case 7:
                    pc = adr - 1;
                    break;

                case 8:
                    pc = pc - 1;
                    break;
            }

            // Setting AC and PC Registers
            if (ac >= 10000)
            {
                int i = ac / 10000;
                ac = ac - (i * 10000);
            }
            if ( ac < 0 )
                AC.Text = "0000";
            else if (ac >= 0 && ac < 10)
                AC.Text = "000" + ac.ToString();
            else if (ac >= 10 && ac < 100)
                AC.Text = "00" + ac.ToString();
            else if (ac >= 100 && ac < 1000)
                AC.Text = "0" + ac.ToString();
            else if (ac >= 1000 && ac < 10000)
                AC.Text = ac.ToString();

            if ( pc < 0 && pc >= 999 )
                PC.Text = "000";
            else if (pc >= 0 && pc < 9)
                PC.Text = "00" + (pc + 1).ToString();
            else if (pc >= 9 && pc < 99)
                PC.Text = "0" + (pc + 1).ToString();
            else if (pc >= 99 && pc < 999)
                PC.Text = (pc + 1).ToString();
        }

        private void Memory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
