using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTracker
{
    public partial class Form1 : Form
    {
        private AccountCreator Account1;
        public string accName;
        public double calLimit;
        public double calRemains;
        public string itemName;
        public string itemCal;
        private double calToTake;

        
        public Form1()
        {
            InitializeComponent();

            itemListView.View = View.Details;
            itemListView.Columns.Add("Item Name                                      "); /// Creates the first column in the Item list
            itemListView.Columns.Add("Calorie value");                                  /// Creates the second column in the item list
            itemListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); /// Resizes the column to the size of the column content
            itemListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);    /// Resizes the column to the size of the header of the column
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
               
           
                
                accName = Convert.ToString(nameTextBox.Text);
                calLimit = Convert.ToDouble(calLimTextBox.Text);

                Account1 = new AccountCreator(accName, calLimit);
                
                welcomeMessage.Text = ("Welcome " + accName + ", your daily amount of calories is :");  /// Displays welcome message using both string 'accName' and double 'calLimit'.
                calRemainLabel.Text = Convert.ToString(calLimit);
                calRemainLabel.BackColor = (Color.LightGreen);
                calRemains = calLimit;
                 
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            

            itemName = Convert.ToString(itemTextBox.Text);
            itemCal = Convert.ToString(itemCalTextBox.Text);
            itemListView.Items.Add(new ListViewItem(new string[] { itemName, itemCal }));       /// With each button press, the item property and calorie value is added to the List View.
            calRemainLabel.Text = Convert.ToString(CalorieRemaining());         /// The Method 'CalorieRemaining' is called and updates the amount of calories left over.
            if (CalorieRemaining() > 0)
            {
                calRemainLabel.BackColor = (Color.LightGreen);
            }

            else
            {
                calRemainLabel.BackColor = (Color.Red);
            }
        }

        private double CalorieRemaining()
        {
            double remains;

            calRemains -= calToTake;
            calToTake = Convert.ToDouble(itemCal);
            remains = calRemains - calToTake;

            return remains;
        }
    }
}
