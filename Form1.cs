using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theatre_Booking_Brook_Harkiran
{
    public partial class Form1 : Form
    {
        public string[,] seatArray = new string[5, 9];

        public Form1()
        {
            int row, col;
            InitializeComponent();

            for (row = 0; row < 5; row = row + 1)
            {
                for (col = 0; col < 9; col = col + 1)
                {
                    seatArray[row, col] = "";
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int iRow, iSeat;
            string strName;
            double dTotal;



            strName = Convert.ToString(txtName.Text);

            iRow = Convert.ToInt32(nudRow.Value);
            iSeat = Convert.ToInt32(nudSeat.Value);

            strName = strName.Trim();
            strName = strName.ToLower();

            try
            {
                if (strName == "")
                {
                    MessageBox.Show("Please enter a name for the desired seat");
                }
                // Given values from user input are saved
                // The program errors if there is no name inputted from the user

                iRow = iRow - 1;
                iSeat = iSeat - 1;

                if (seatArray[iRow, iSeat] == "")
                {
                    seatArray[iRow, iSeat] = strName;
                    txtName.Clear();

                    if (iRow < 2 && (iSeat > 3 && iSeat < 5))
                    {
                        dTotal = 40;
                    }

                    else if (iRow == 2 && (iSeat > 3 && iSeat < 5))
                    {
                        dTotal = 30;
                    }
                    else if ((iRow < 5 && iRow > 2) && (iSeat > 3 && iSeat < 5))
                    {
                        dTotal = 20;
                    }

                    else if (iRow < 2 && (iSeat < 3 || iSeat > 5))
                    {
                        dTotal = 35;
                    }
                    else if (iRow == 2 && (iSeat < 3 || iSeat > 5))
                    {
                        dTotal = 25;
                    }
                    else
                    {
                        dTotal = 10;
                    }

                    dTotal = dTotal * 1.13;
                    txtTotal.Text = Convert.ToString(dTotal);
                }
                // Checks if the user's resired spot is empty
                //If it is, a price is given for a specific row and seat chosen. 
                // The price is then outputted (along with tax), in a textbox. 

                else
                {
                    MessageBox.Show("This seat is already taken");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("This seat does not exist.");
                return;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            int i, j;
            string strLineOutput;

            try
            {
                lbSeatOutput.Items.Clear();
                for (i = 0; i < 5; i = i + 1)
                {
                    strLineOutput = "";

                    for (j = 0; j < 9; j = j + 1)
                    {
                        if (seatArray[i, j] == "")
                        {
                            strLineOutput = strLineOutput + "O";
                        }
                        else
                        {
                            strLineOutput = strLineOutput + "X";
                        }
                    }

                    lbSeatOutput.Items.Add(strLineOutput);
                }


            }
            catch
            {
                MessageBox.Show("Could not display seats.");
                return;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int iRow, iCol;
            string strName;

            lbSeatOutput.Items.Clear();

            strName = Convert.ToString(txtName.Text);
            iRow = Convert.ToInt32(nudRow.Value);
            iCol = Convert.ToInt32(nudSeat.Value);

            try
            {
                // Sit 2: We are given the values, but the seat is empty
                if (strName == "")
                {
                    MessageBox.Show("Please enter a name to cancel.");
                }

                // Situtation 1: We are given a seat and name, to cancel
                if (strName == seatArray[iRow, iCol])
                {
                    seatArray[iRow, iCol] = "";
                    MessageBox.Show("Cancel complete.");
                    return;
                }

                // Sit 3. The inputted name does not match the name in the array 
                else
                {
                    MessageBox.Show("This seat does not belong to you.");
                    return;
                }
            }

            catch
            {
                MessageBox.Show("Please enter valid input.");
                return;
            }
        }

        private void btnWho_Click(object sender, EventArgs e)
        {
            try
            {
                int iRow, iCol;
                string strName;

                txtName.Clear();

                lbSeatOutput.Items.Clear();
                iRow = Convert.ToInt32(nudRow.Value);
                iCol = Convert.ToInt32(nudSeat.Value);
                // Gets input values from user.

                strName = seatArray[iRow - 1, iCol - 1];

                if (strName == "")
                {
                    MessageBox.Show("Sorry, nobody is sitting in that spot");
                }
                else
                {
                    MessageBox.Show("This seat belongs to " + strName);
                }
                // Tells the user whether someone is sitting in the entered seat values.
            }
            catch
            {
                MessageBox.Show("Error, that is an invalid input");
                return;
            }
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            string strName;
            int i;

            lbSeatOutput.Items.Clear();
            strName = Convert.ToString(txtName.Text);
            try
            {

                for (i = 0; i < 5; i = i + 1)
                {
                    for (int j = 0; j < 9; j = j + 1)
                    {
                        if (strName == seatArray[i, j])
                        {
                            i = i + 1;
                            j = j + 1;
                            MessageBox.Show(strName + " is sitting in row: " + i + " seat " + j);
                            return;
                        }
                       
                    }
                }

                MessageBox.Show("Sorry, this person has not bought a seat");
                return;
            }

            catch
            {
                MessageBox.Show("Error, invalid entry");
                return;
            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int i, j, iBookedSeats, iEmptySeats;

            iEmptySeats = 0;
            iBookedSeats = 0;

            try
            {
                txtName.Clear();
                lbSeatOutput.Items.Clear();

                for (i = 0; i < 5; i = i + 1)
                {
                    for (j = 0; j < 9; j = j + 1)
                    {
                        if (seatArray[i, j] == "")
                        {
                            iEmptySeats = iEmptySeats + 1;
                        }
                        else
                        {
                            iBookedSeats = iBookedSeats + 1;
                        }
                    }



                }
                MessageBox.Show("There are " + iEmptySeats + " empty seats, and " + iBookedSeats + " booked seats.");
               
            }

            catch
            {
                MessageBox.Show("Invalid input, please try again");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
