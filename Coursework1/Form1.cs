using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private int NumValues()
        {
            return lstIntValues.Items.Count;
        }

        private int GetValAtIndex(int index)
        {
            if (index < 0 || index >= NumValues()) return -1;
            return int.Parse(lstIntValues.Items[index].ToString());
        }

        private void RemoveValAtIndex(int index)
        {
            //shift all items to the right of 'index' to the left.
            for (int i = index; i < NumValues() - 1; i++)
            {
                lstIntValues.Items[i] = lstIntValues.Items[i + 1];
            }
            //delete the last item.
            lstIntValues.Items.RemoveAt(NumValues() - 1);
        }

        private void SetValAtIndex(int value, int index)
        {
            if (index < 0 || index >= NumValues()) return;

            lstIntValues.Items[index] = value.ToString();
        }

        private void InsertValAtIndex(int value, int index)
        {
            if (NumValues() >= 30) return;
            if (index < 0 || index >= NumValues()) return;

            //create a dummy item at the back of the list, to extend it's length
            AppendValToList(100);

            //shift every item to the right by one
            for (int i = NumValues() - 2; i >= index; i--)
            {
                MessageBox.Show(
                    "Moving "
                    + GetValAtIndex(i).ToString()
                    + " to the right, replacing "
                    + GetValAtIndex(i + 1).ToString()
                );
                SetValAtIndex(GetValAtIndex(i), i + 1);
            }
            
            //overwrite the old item at the desired index
            SetValAtIndex(value, index);
        }

        private void AppendValToList(int value)
        {
            if (NumValues() >= 30) return;

            lstIntValues.Items.Add(value); // TODO: not allowed to use .add
        }

        private bool AddToList(int value)
        {
            if (optSorted.Checked == true)
            {
                // TODO: locate insersion point and insert
                // BUG: inserting into incorrect indexes (inserting
                //      1 to far to the left.
                int left_index = 0;
                int right_index = NumValues() - 1;
                int mid_index = (left_index + right_index) / 2;

                while (left_index < right_index)
                {
                    if (GetValAtIndex(mid_index) == value) return false;
                    if (GetValAtIndex(mid_index) < value) left_index = mid_index + 1;
                    if (GetValAtIndex(mid_index) > value) right_index = mid_index - 1;
                    mid_index = (left_index + right_index) / 2;
                }

                InsertValAtIndex(value, mid_index);
            }
            else
            {
                AppendValToList(value);
            }

            UpdateStats();
            btnClear.Enabled = true;
            if (NumValues() >= 2 && optUnsorted.Checked)
                btnShuffle.Enabled = true;
            if (NumValues() >= 30)
                btnAddNumber.Enabled = false;
            if (NumValues() > 0)
            {
                btnSearch.Enabled = true;
                if (lstIntValues.SelectedIndex == -1)
                {
                    lstIntValues.SelectedIndex = 0;
                    btnDeleteNumber.Enabled = true;
                }
            }

            return true;
        }

        private void SortList()
        {
            //bubble-sort currently implemented, could use merge
            //sort if performance becomes a problem.
            int left_val = 0;
            int right_val = 0;
            bool change_made = false;

            do
            {
                change_made = false;
                for (int i = 0; i < NumValues() - 1; i++)
                {
                    left_val = GetValAtIndex(i);
                    right_val = GetValAtIndex(i + 1);
                    if (left_val > right_val)
                    {
                        SetValAtIndex(right_val, i);
                        SetValAtIndex(left_val, i + 1);
                        change_made = true;
                    }
                }
            } while (change_made == true);
        }

        private void UpdateStats()
        {
            lblNumEntries.Text = NumValues().ToString() + " / 30";

            if (NumValues() == 0)
            {
                lblFirstItemTitle.Enabled = false;
                lblLastItemTitle.Enabled = false;
                lblMinValueTitle.Enabled = false;
                lblMaxValueTitle.Enabled = false;
                lblFirstItem.Text = "";
                lblLastItem.Text = "";
                lblMinValue.Text = "";
                lblMaxValue.Text = "";
            }
            else
            {
                lblFirstItemTitle.Enabled = true;
                lblLastItemTitle.Enabled = true;
                lblMinValueTitle.Enabled = true;
                lblMaxValueTitle.Enabled = true;
                lblFirstItem.Text = GetValAtIndex(0).ToString();
                lblLastItem.Text = GetValAtIndex(NumValues() - 1).ToString();
                lblMinValue.Text = MinValue().ToString();
                lblMaxValue.Text = MaxValue().ToString();
            }
        }

        private int Find(int value)
        {
            if (optLinear.Checked == true)
                return FindUsingLinear(value);
            if (optBinary.Checked == true)
                return FindUsingBinary(value);

            MessageBox.Show("DEV ERROR: neither search options checked");
            return -1;
        }

        private int FindUsingLinear(int value)
        {
            for (int i = 0; i < NumValues(); i++)
            {
                if (GetValAtIndex(i) == value) return i;
            }
            return -1;
        }

        private int FindUsingBinary(int value)
        {
            int left_index = 0;
            int right_index = NumValues() - 1;
            int mid_index = 0;

            while (left_index <= right_index)
            {
                mid_index = (left_index + right_index) / 2; //automatically floors, as all values are ints
                if (GetValAtIndex(mid_index) == value) return mid_index;
                if (GetValAtIndex(mid_index) < value) left_index = mid_index + 1; 
                if (GetValAtIndex(mid_index) > value) right_index = mid_index - 1;
            }
            return -1;
        }

        private int MinValue()
        {
            if (NumValues() == 0) return -1;
            if (optSorted.Checked) return GetValAtIndex(0);

            int minimum = 100;
            int cur_item = 0;
            for (int i = 0; i < NumValues() - 1; i++)
            {
                cur_item = GetValAtIndex(i);
                if (cur_item < minimum) minimum = cur_item;
            }
            return minimum;
        }

        private int MaxValue()
        {
            if (NumValues() == 0) return -1;
            if (optSorted.Checked) return GetValAtIndex(NumValues() - 1);

            int maximum = 0;
            int cur_item = 0;
            for (int i = 0; i < NumValues() - 1; i++)
            {
                cur_item = GetValAtIndex(i);
                if (cur_item > maximum) maximum = cur_item;
            }
            return maximum;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInitList_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int cur_value;
            lstIntValues.Items.Clear();

            for (int i = 0; i < 30; i++)
            {
                do cur_value = rnd.Next(101);
                while (Find(cur_value) != -1);

                AddToList(cur_value);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstIntValues.Items.Clear();
            lstIntValues.SelectedIndex = -1;
            btnClear.Enabled = false;
            btnShuffle.Enabled = false;
            btnAddNumber.Enabled = true;
            btnSearch.Enabled = false;
            btnDeleteNumber.Enabled = false;
            UpdateStats();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            if (txtNewNumber.Text.Equals(""))
            {
                MessageBox.Show("ERROR: no number given");
                return;
            }

            bool success = int.TryParse(txtNewNumber.Text, out int value);
            if (!success)
            {
                MessageBox.Show("ERROR: non-number value given");
                return;
            }

            if (NumValues() >= 30)
            {
                MessageBox.Show("ERROR: the list is full!");
                return;
            }

            if (value < 0 || value > 100)
            {
                MessageBox.Show("ERROR: the integer is out of range");
                return;
            }

            if (Find(value) != -1)
            {
                MessageBox.Show("ERROR: this item already exists");
                return;
            }

            AddToList(value);
        }

        private void optUnsorted_CheckedChanged(object sender, EventArgs e)
        {
            if (optUnsorted.Checked == true)
            {
                optLinear.Checked = true;
                optBinary.Enabled = false;
                if (NumValues() >= 2)
                    btnShuffle.Enabled = true;
            }

            if (optSorted.Checked == true)
            {
                SortList();
                optBinary.Enabled = true;
                btnShuffle.Enabled = false;
            }

            UpdateStats();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchItem.Text.Equals(""))
            {
                MessageBox.Show("ERROR: no number given");
                return;
            }

            bool success = int.TryParse(txtSearchItem.Text, out int value);
            if (!success)
            {
                MessageBox.Show("ERROR: non-number value given");
                return;
            }

            int result = Find(value);
            if (result == -1)
                MessageBox.Show("Item not found!", "Search Results");
            else
                MessageBox.Show("Item found at position " + result.ToString(), "Search Results");
        }

        private void btnDeleteNumber_Click(object sender, EventArgs e)
        {
            RemoveValAtIndex(lstIntValues.SelectedIndex);
            UpdateStats();
            btnAddNumber.Enabled = true;
            if (NumValues() > 0)
            {
                if (lstIntValues.SelectedIndex == -1)
                    lstIntValues.SelectedIndex = 0;
            }
            else
            {
                btnDeleteNumber.Enabled = false;
                btnSearch.Enabled = false;
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand_source;
            int rand_dest;
            int hold_val;

            for (int i = 0; i < 30; i++)
            {
                rand_source = rnd.Next(NumValues());
                rand_dest = rnd.Next(NumValues());

                hold_val = GetValAtIndex(rand_dest);
                SetValAtIndex( GetValAtIndex(rand_source) , rand_dest);
                SetValAtIndex(hold_val, rand_source);
            }
            UpdateStats();
        }

        private void lstIntValues_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstIntValues.Items.Count > 0)
                lstIntValues.DoDragDrop(lstIntValues.SelectedItem, DragDropEffects.Move);
        }

        private void picDeleteImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void picDeleteImage_DragDrop(object sender, DragEventArgs e)
        {
            //code to remove the item from the list
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            picDeleteImage.AllowDrop = true;
        }
    }
}
