using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{

    public partial class BasicCalculator : Form
    {
        public BasicCalculator()
        {
            InitializeComponent();
        }

        #region Math Operators
        /// <summary>
        /// Inputs a slash(for division) in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void divideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs an asterisk (for multiplication) in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a minus (for reduction) in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void minusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a plus (for sum) in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void plusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a slash(for division) in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void equalsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

        #endregion

        #region Number Methods

        /// <summary>
        /// Inputs a one in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void oneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a two in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void twoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a three in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void threeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a four in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void fourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a five in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void fiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a six in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void sixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a seven in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void sevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs an eight in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void eightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a nine in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void nineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            //focuses back to the text box
            FocusInputText();
        }

        /// <summary>
        /// Inputs a zero in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void zeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            //focuses back to the text box
            FocusInputText();
        }


        /// <summary>
        /// Inputs a point in the current selection/focus in the text box.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void pointButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            //focuses back to the text box
            FocusInputText();

        }
        #endregion

        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CButton_Click(object sender, EventArgs e)
        {
            this.UserInputBox.Text = string.Empty;
            
            //focuses back to the text box
            FocusInputText();
        }
        /// <summary>
        /// Deletes the character before the cursor. 
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Event Arguments</param>
        private void DelButton_Click(object sender, EventArgs e)
        {
            // deletes char to the right
            DeleteCharacter();

            //focuses back to the text box
            FocusInputText();
        }


        /// <summary>
        /// Deletes character to the right of the selection and keeps the cursor on the same location. Does nothing if there is no character to the right. 
        /// </summary>
        private void DeleteCharacter()
        {
            //if there is no value, then return;
            if (this.UserInputBox.Text.Length < this.UserInputBox.SelectionStart + 1)
                return;

            // select starting location and remember it; 
            var startingLocation = this.UserInputBox.SelectionStart;

            // remove the value to the right.
            this.UserInputBox.Text = this.UserInputBox.Text.Remove(this.UserInputBox.SelectionStart, 1);

            // restore selection and set it to zero
            this.UserInputBox.SelectionStart = startingLocation;
            this.UserInputBox.SelectionLength = 0;
        }

        #endregion

        #region Private Helpers
        /// <summary>
        /// Focuses back to textbox after a button has been pressed.
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputBox.Focus();
        }

        /// <summary>
        /// Inputs a string in the focused selections.
        /// </summary>
        /// <param name="value"></param>
        private void InsertTextValue(string value)
        {
            // Starting selection
            var startingLocation = this.UserInputBox.SelectionStart;
            // set new text
            this.UserInputBox.Text = this.UserInputBox.Text.Insert(this.UserInputBox.SelectionStart, value);
            // restore to selection start
            this.UserInputBox.SelectionStart = startingLocation + value.Length;
            // set selection to zero
            this.UserInputBox.SelectionLength = 0; 
        }
        /// <summary>
        /// Calulates the equation and outputs the result. 
        /// </summary>
        private void CalculateEquation()
        {
             //TODO: add implementation
        }

        #endregion
    }
}
