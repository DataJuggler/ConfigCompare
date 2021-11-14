

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Win.Controls;
using DataJuggler.UltimateHelper;
using XmlMirror.Runtime5.Objects;
using System.IO;
using DataJuggler.UltimateHelper.Objects;

#endregion

namespace ConfigCompare
{

    #region class MainForm
    /// <summary>
    ///  This is the main form for this app.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        private List<FieldValuePair> sourceValues;
        private List<FieldValuePair> targetValues;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // If you have config files you need to check often, you can set the values here.
            // I removed this for check in, but if I ever leave my own values in by accident, forgive me.
            // SourceControl.Text = @"";
            // TargetControl.Text = @"";
        }
        #endregion

        #region Events
            
            #region CompareButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CompareButton' is clicked.
            /// </summary>
            private void CompareButton_Click(object sender, EventArgs e)
            {
                // clear in case it is run again
                ResultsListBox.Items.Clear();

                // Get the source values
                SourceValues = GetValues(SourceControl.Text);

                // Get the target values
                TargetValues = GetValues(TargetControl.Text);

                // verify both lists exist, and have at least one item
                if (ListHelper.HasOneOrMoreItems(sourceValues, targetValues))
                {
                    // Iterate the collection of FieldValuePair objects
                    foreach (FieldValuePair fieldValuePair in sourceValues)
                    {
                        // attempt to find this object in the target
                        FieldValuePair target = targetValues.FirstOrDefault(x => x.FieldName == fieldValuePair.FieldName);

                        // If the target object exists
                        if (NullHelper.Exists(target))
                        {
                            // verify both objects exist, they should
                            if (NullHelper.Exists(fieldValuePair.FieldValue, target.FieldValue))
                            {
                                // if the two values are not equal
                                if (!TextHelper.IsEqual(fieldValuePair.FieldValue.ToString(), target.FieldValue.ToString()))
                                {
                                    // we have a difference                                    
                                    ResultsListBox.Items.Add("App Setting " + fieldValuePair.FieldName + " has a different value in the target file.");
                                }
                            }
                        }
                        else
                        {
                            // show a message
                            ResultsListBox.Items.Add("App Setting " + fieldValuePair.FieldName + " was not found in the target file.");
                        }
                    }
                }
                else
                {
                    // Something went wrong, show a vague message to start with.
                    MessageBox.Show("There is prfoblem loading one of the web.config files", "Configuration Not Valid");
                }

                // if there are differences
                if (ResultsListBox.Items.Count > 0)
                {
                    // show the results
                    StatusLabel.Text = "Found " + ResultsListBox.Items.Count + " differences.";
                }
                else
                {
                    // show the results
                    StatusLabel.Text = "No differences found.";
                }
            }
            #endregion
            
            #region CopiedTimer_Tick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Copied Timer _ Tick
            /// </summary>
            private void CopiedTimer_Tick(object sender, EventArgs e)
            {
                // hide
                CopiedImage.Visible = false;

                // only run once
                CopiedTimer.Stop();
            }
            #endregion
            
            #region CopyButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CopyButton' is clicked.
            /// </summary>
            private void CopyButton_Click(object sender, EventArgs e)
            {
                // Create a new instance of a 'StringBuilder' object.
                StringBuilder sb = new StringBuilder();

                foreach (object item in ResultsListBox.Items)
                {
                    sb.Append(item.ToString());
                    sb.Append(Environment.NewLine);
                }

                // Get the results
                string results = sb.ToString().Trim();

                // show
                CopiedImage.Visible = true;

                // refresh
                Refresh();
                Application.DoEvents();

                // Set the text
                Clipboard.SetText(results);

                // Start the timer
                CopiedTimer.Start();
            }
            #endregion
            
            #region SwapButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SwapButton' is clicked.
            /// </summary>
            private void SwapButton_Click(object sender, EventArgs e)
            {
                // get the value
                string temp = SourceControl.Text;

                // Set the new Source
                SourceControl.Text = TargetControl.Text;

                // Now set the target
                TargetControl.Text = temp;

                // Change the status label.
                StatusLabel.Text = "Source and Target config files were swapped.";
            }
            #endregion
            
            #region SwapButton_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Swap Button _ Mouse Enter
            /// </summary>
            private void SwapButton_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region SwapButton_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Swap Button _ Mouse Leave
            /// </summary>
            private void SwapButton_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
        #endregion

        #region Methods
            
            #region GetValues(string filePath)
            /// <summary>
            /// returns a list of Values
            /// </summary>
            public List<FieldValuePair> GetValues(string filePath)
            {
                // initial value
                List<FieldValuePair> values = new List<FieldValuePair>();

                // locals
                FieldValuePair fieldValuePair = null;
                char[] delimiter = new char[] { ' ' };
                char[] delimiter2 = new char[] { '=' };
                string temp = "";
                string temp2 = "";
                string name = "";
                string value = "";

                // if the filePath exists
                if (FileHelper.Exists(filePath))
                {
                    // get all the text
                    string fileText = File.ReadAllText(filePath);

                    // If the fileText string exists
                    if (TextHelper.Exists(fileText))
                    {
                        // Get the textLines
                        List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                        // If the textLines collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(textLines))
                        {
                            // Iterate the collection of TextLine objects
                            foreach (TextLine textLine in textLines)
                            {
                                // reset
                                name = "";
                                value = "";

                                // if this is a line with a value
                                if (textLine.Text.Trim().StartsWith("<add key="))
                                {
                                    // get the words, parsing on space only
                                    List<Word> words = TextHelper.GetWords(textLine.Text, delimiter);

                                    // if the words collection exists
                                    if (ListHelper.HasXOrMoreItems(words, 3))
                                    {
                                        // Get the 2nd and 3rd words
                                        temp = words[1].Text;
                                        temp2 = words[2].Text;

                                        // get the source words
                                        words = TextHelper.GetWords(temp, delimiter2);

                                        // if there are two words
                                        if (ListHelper.HasXOrMoreItems(words, 2))
                                        {
                                            // Set the name
                                            name = words[1].Text.Replace("\"", "");
                                        }

                                        // get the source words
                                        words = TextHelper.GetWords(temp2, delimiter2);

                                        // if there are two words
                                        if (ListHelper.HasXOrMoreItems(words, 2))
                                        {
                                            // Set the name
                                            value = words[1].Text.Replace("\"", "");
                                        }
                                    }

                                    // If the strings name and value both exist
                                    if (TextHelper.Exists(name, value))
                                    {
                                        // Create a new instance of a 'FieldValuePair' object.
                                        fieldValuePair = new FieldValuePair();

                                        // store the values
                                        fieldValuePair.FieldName = name;
                                        fieldValuePair.FieldValue = value;

                                        // Add this value
                                        values.Add(fieldValuePair);
                                    }
                                }
                            }
                        }
                    }
                }

                // sort the list here
                if (ListHelper.HasOneOrMoreItems(values))
                {
                    // sort the values by name
                    values = values.OrderBy(x => x.FieldName).ToList();
                }
                
                // return value
                return values;
            }
            #endregion
            
        #endregion

        #region Properties

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion

            #region SourceValues
            /// <summary>
            /// This property gets or sets the value for 'SourceValues'.
            /// </summary>
            public List<FieldValuePair> SourceValues
            {
                get { return sourceValues; }
                set { sourceValues = value; }
            }
            #endregion
            
            #region TargetValues
            /// <summary>
            /// This property gets or sets the value for 'TargetValues'.
            /// </summary>
            public List<FieldValuePair> TargetValues
            {
                get { return targetValues; }
                set { targetValues = value; }
            }
        #endregion

        #endregion

    }
    #endregion

}