/*
 * Created by: Alex Mathias
 * Created on: 19-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 5-05
 * This program Shows the average in a 2D array.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDArray
{
    public partial class frmArray : Form
    {
                                         
        public frmArray()
        {
            InitializeComponent();
        }
        public int findAverage(int[,] Array, int width, int length)
        {
            Random rnd = new Random();
            int average = 0;
            int loop;
            int loopTwo;
            int loopCounter = 0;
            int total = 0;
            for (loop = 0; loop < length; loop++)
            {
                for (loopTwo = 0; loopTwo < width; loopTwo++)
                {
                    Array[loop, loopTwo] = rnd.Next(1, 11);
                    total = total + Array[loop, loopTwo];
                    loopCounter = loopCounter + 1;
                }
            }
            average = total / loopCounter;

            return average;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int width;
            int length;
            int loop;
            int loopTwo;
            this.lstArray.Items.Clear();

            width = Convert.ToInt32(this.nudWidth.Value);
            length = Convert.ToInt32(this.nudLength.Value);
             int[,] Array = new int[width, length];
            int average = findAverage(Array, width, length);
            this.lblAverage.Text = "The average is: " + Convert.ToString(average);
            for (loop = 0; loop < length; loop++)
            {
                for (loopTwo = 0; loopTwo < width; loopTwo++)
                {
                    
                    this.lstArray.Items.Add(Array[loop, loopTwo]);

                }
            }





                }
    }
}
