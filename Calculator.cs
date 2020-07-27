using System;
using System.Windows.Forms;

/*  ID
 *      Calculator, Kaleb Ehlert, 4/1/2018
 *  Purpose
 *      The purpose of the program is to implement a calculator that can take the input of integers/integrals and output the result
 *      of the operation.
 *  Form Controls
 *      txtCommandLine: The textfield that displays the results of the operation and displays the input as it is being typed.
 *      btnNum1: The button that inputs the number one in the calculator
 *      btnNum2: The button that inputs the number two in the calculator
 *      btnNum3: The button that inputs the number three in the calculator
 *      btnNum4: The button that inputs the number four in the calculator
 *      btnNum5: The button that inputs the number five in the calculator
 *      btnNum6: The button that inputs the number six in the calculator
 *      btnNum7: The button that inputs the number seven in the calculator
 *      btnNum8: The button that inputs the number eight in the calculator
 *      btnNum9: The button that inputs the number nine in the calculator
 *      btnNum0: The button that inputs the number zero in the calculator
 *      btnPosOrNeg: The button that changes the value based on whether it is positive or negative only if you have not typed in the
 *      number yet.
 *      btnClear: The button that clears all operations.
 *      btnDivision: The button that enters in the divison operation.
 *      btnMultiplication: The button that enters in the multiplication operation.
 *      btnAddition: The button that enters in the addition operation.
 *      btnSubtraction: The button that enters in the subtraction operation.
 *      btnEquals: The button that performs the operation.
 *  Code & Logic
 *      The input is the buttons on the screen that the user can click.
 *      The processing takes two operands and performs a math operation on them.
 *      The output is the result of the math operations performed.
 */

namespace EhlertProgram9
{
    public partial class Calculator : Form
    {
        Boolean equalsClicked;

        int result;
        int operand1;
        int operand2;

        string input;
        string operation;

        public Calculator()
        {
            InitializeComponent();

            equalsClicked = false;

            result = 0;
            operand1 = 0;
            operand2 = 0;

            input = "";
            operation = "";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "1";
            txtCommandLine.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "2";
            txtCommandLine.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "3";
            txtCommandLine.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "4";
            txtCommandLine.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "5";
            txtCommandLine.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "6";
            txtCommandLine.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "7";
            txtCommandLine.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "8";
            txtCommandLine.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "9";
            txtCommandLine.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            input += "0";
            txtCommandLine.Text += "0";
        }

        private void btnPosOrNeg_Click(object sender, EventArgs e)
        {
            if (equalsClicked == true) {
                txtCommandLine.Text = "";
                equalsClicked = false;
            }

            if (input == "-")
                input = "";
            else
                input += "-";

            txtCommandLine.Text += "-";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCommandLine.Text = "";
            Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operandAssignment();

            operation = "/";

            txtCommandLine.Text += " / ";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operandAssignment();

            operation = "*";

            txtCommandLine.Text += " * ";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            operandAssignment();

            operation = "+";

            txtCommandLine.Text += " + ";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            operandAssignment();

            operation = "-";

            //operationClicked = true;

            txtCommandLine.Text += " - ";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            equalsClicked = true;

            operandAssignment();

            // Display the result
            txtCommandLine.Text = result.ToString();

            // Clear all variables
            Clear();
        }

        // Assigns an operand a value based off of what operand is filled or not
        private void operandAssignment()
        {
            if (operand1 == 0) {
                operand1 = int.Parse(input);
                input = "";

                operandCalculation();
            } else {
                operand2 = int.Parse(input);
                input = "";

                operandCalculation();
            }
        }

        // Performs the math on the two operands
        private void operandCalculation()
        {
            if (operand1 != 0 && operand2 != 0) {
                if (operation == "/") {
                    try {
                        result = operand1 / operand2;
                    } catch {
                        MessageBox.Show("Error! Divide by zero exception.");
                    }

                    operation = "";
                    operand1 = result;
                    operand2 = 0;
                }
                else if (operation == "*") {
                    result = operand1 * operand2;

                    operation = "";
                    operand1 = result;
                    operand2 = 0;
                }
                else if (operation == "+") {
                    result = operand1 + operand2;

                    operation = "";
                    operand1 = result;
                    operand2 = 0;
                }
                else if (operation == "-") {
                    result = operand1 - operand2;

                    operation = "";
                    operand1 = result;
                    operand2 = 0;
                }
            }
        }

        // Clears all variables as it is only called when the enter button is clicked
        private void Clear()
        {
            result = 0;
            operand1 = 0;
            operand2 = 0;

            equalsClicked = false;

            input = "";
        }
    }
}
