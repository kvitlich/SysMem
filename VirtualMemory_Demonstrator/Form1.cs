using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMemory_Demonstrator
{

    public partial class Form1 : Form
    {
        private TimerCallback cb;
        private System.Threading.Timer timer;
        private List<Array> arrays = new List<Array>();
        public enum AllocatingMode
        { 
            MB = 1, 
            KB = 2, 
            Byte = 3, 
        }      

        public enum FillMode
        {
            Full = 1,
            OnEnds = 2,
            NoFill = 3, 
            FiftyP = 4,
        }

        public Form1()
        {
            InitializeComponent();
            Load();
            statGrid.RowHeadersVisible = false;
            mainGrid.RowHeadersVisible = false;
            comboBoxMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFill.DropDownStyle = ComboBoxStyle.DropDownList;
            button_free.Enabled = false;
            comboBoxMode.Items.Add(AllocatingMode.Byte);
            comboBoxMode.Items.Add(AllocatingMode.KB);
            comboBoxMode.Items.Add(AllocatingMode.MB);
            comboBoxFill.Items.Add(FillMode.Full);
            comboBoxFill.Items.Add(FillMode.FiftyP);
            comboBoxFill.Items.Add(FillMode.NoFill);
            comboBoxFill.Items.Add(FillMode.OnEnds);
            comboBoxFill.SelectedItem = FillMode.Full;
            comboBoxMode.SelectedItem = AllocatingMode.Byte;
        }

        private void Alloc(object sender, EventArgs e)
        {
            button_alloc.Enabled = false;
            int value;
            if (!Int32.TryParse(alloc_value.Text,out value))
            {
                MessageBox.Show("Поле должно быть числом!");
                button_alloc.Enabled = true;
                return;
            }
            switch((AllocatingMode)comboBoxMode.SelectedItem)
            {
                case AllocatingMode.MB:
                    value *= 1024 * 1024;
                    break;
                case AllocatingMode.KB:
                    value *= 1024;
                    break;
                case AllocatingMode.Byte:
                    break;
            }
            value /= 2;
            char[] temp = new char[value];

            switch ((FillMode)comboBoxFill.SelectedItem)
            {
                case FillMode.Full:
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = ')';
                    }
                    break;
                case FillMode.FiftyP:
                    for (int i = 0; i < temp.Length/2; i++)
                    {
                        temp[i] = ')';
                    }
                    break;
                case FillMode.NoFill:
                    break;

                case FillMode.OnEnds:
                    temp[0] = '0';
                    temp[temp.Length - 1] = '0';
                    break;
            }

            arrays.Add(temp);
            button_free.Enabled = true;
            button_alloc.Enabled = true;
        }

        private void Free(object sender, EventArgs e)
        {
            alloc_value.Enabled = true;
            button_alloc.Enabled = true;
            button_free.Enabled = false;
            for (int i = 0; i < arrays.Count; i++)
            {
                arrays[i] = null;
            }
            arrays.Clear();
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
        }

        public delegate void InvokeDelegate(object param);
        public void Load()
        {
            cb = new TimerCallback(ShowInfo);
            timer = new System.Threading.Timer(cb, null, 0, 2000);
   
        }

        public void ShowInfo(object obj)
        {
            DataLocator locator = new DataLocator();
            string firstTemp = (locator.GetComMemoryLoad() / 1024 / 1024).ToString() + " MB";
            string secondTemp = (locator.GetAppMemoryLoad() / 1024 / 1024).ToString() + " MB";
            mainGrid.Invoke(new Action(() =>
            {
                mainGrid.Rows.Clear();
                mainGrid.Rows.Add(firstTemp, secondTemp);
                if (statGrid.Rows.Count >= 100)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        statGrid.Rows.RemoveAt(i);
                    }
                }
                statGrid.Rows.Add(firstTemp, secondTemp);
            }));
        }

        private void Refresh(object sender, EventArgs e)
        {
            ShowInfo(null);
        }

        private void mainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
