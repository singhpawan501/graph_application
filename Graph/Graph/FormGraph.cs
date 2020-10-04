using XmlReader;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Graph
{
    /// <summary>
    /// Draw graph on the basis of points in xml file
    /// </summary>
    public partial class FormGraph : Form
    {
        #region Variable declaration
        // To draw line, label or circle on the graph
        private Graphics m_objGraphics = null;
        
        // To store cordinates of the graph
        private double[,] m_cordinates;

        // To store gridspacing value in x axis
        private double m_dx = 0.0;

        // To store gridspacing value in y axis
        private double m_dy = 0.0;

        // To store start point x
        private double m_startPointX = 0.0;

        // To store start point y
        private double m_startPointY = 0.0;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialize the form component
        /// </summary>
        public FormGraph()
        {
            InitializeComponent();
        }
        #endregion

        #region Private method
        /// <summary>
        /// Draw line on the graph
        /// </summary>
        private void DrawLine()
        {
            try
            {
                // Store value of gridspacing and start point
                m_dx = double.Parse(textBoxDx.Text);
                m_dy = double.Parse(textBoxDy.Text);
                m_startPointX = double.Parse(textBoxX.Text);
                m_startPointY = double.Parse(textBoxY.Text);

                m_objGraphics = panelGraph.CreateGraphics();

                // Calculate grid displacement
                float xGridDisplacement = (panelGraph.Width) / ((float.Parse(textBoxXMax.Text) - 
                    float.Parse(textBoxX.Text)) / (float.Parse(textBoxDx.Text)));
                float yGridDisplacement = (panelGraph.Height) / ((float.Parse(textBoxYMax.Text) - 
                    float.Parse(textBoxY.Text)) / (float.Parse(textBoxDy.Text)));

                // Store start nad end point of grid line
                PointF startPoint = new PointF();
                PointF endPoint = new PointF();

                if (m_cordinates.GetLength(0) > 1)
                {
                    for (int i = 1; i < m_cordinates.GetLength(0); i++)
                    {
                        // Set start point of the grid line
                        startPoint.X = float.Parse((m_cordinates[i - 1, 0] - float.Parse(textBoxX.Text)).ToString()) * 
                            xGridDisplacement / float.Parse(textBoxDx.Text);
                        startPoint.Y = panelGraph.Height - float.Parse((m_cordinates[i - 1, 1] - 
                            float.Parse(textBoxY.Text)).ToString()) * yGridDisplacement / float.Parse(textBoxDy.Text);

                        // Set end point of the grid line
                        endPoint.X = float.Parse((m_cordinates[i, 0] - float.Parse(textBoxX.Text)).ToString()) * 
                            xGridDisplacement / float.Parse(textBoxDx.Text);
                        endPoint.Y = panelGraph.Height - float.Parse((m_cordinates[i, 1] - 
                            float.Parse(textBoxY.Text)).ToString()) * yGridDisplacement / float.Parse(textBoxDy.Text);

                        // Draw grid line on the graph
                        m_objGraphics.DrawLine(new Pen(Color.White, 1), startPoint, endPoint);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Draw marker on the point
        /// </summary>
        private void DrawMarker()
        {
            try
            {
                m_objGraphics = panelGraph.CreateGraphics();

                // Calculate grid displacement
                float xGridDisplacement = (panelGraph.Width) / ((float.Parse(textBoxXMax.Text) - 
                    float.Parse(textBoxX.Text)) / (float.Parse(textBoxDx.Text)));
                float yGridDisplacement = (panelGraph.Height) / ((float.Parse(textBoxYMax.Text) - 
                    float.Parse(textBoxY.Text)) / (float.Parse(textBoxDy.Text)));

                // Set radius of marker
                float radius = 5;

                // Store marker point
                PointF markerPoint = new PointF();

                for (int i = 0; i < m_cordinates.GetLength(0); i++)
                {
                    // Set start point of the line
                    markerPoint.X = float.Parse((m_cordinates[i, 0] - float.Parse(textBoxX.Text)).ToString()) * xGridDisplacement / 
                        float.Parse(textBoxDx.Text);
                    markerPoint.Y = panelGraph.Height - float.Parse((m_cordinates[i, 1] - float.Parse(textBoxY.Text)).ToString()) * 
                        yGridDisplacement / float.Parse(textBoxDy.Text);

                    if (checkBoxShowPoints.Checked == true)
                    {
                        // Draw marker on the point
                        m_objGraphics.DrawEllipse(new Pen(Color.Red, 1), markerPoint.X - radius, markerPoint.Y - 
                            radius, radius + radius, radius + radius);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Draw label on x axis
        /// </summary>
        private void DrawLabelXAxis()
        {
            try
            {
                // Starting point to draw x axis label
                System.Drawing.PointF labelPoint = new PointF();
                labelPoint.X = 1;
                labelPoint.Y = 0;

                // Store x axis label values
                double labelValue = double.Parse(textBoxX.Text);

                // Set value for label x axis displacement
                float labelXDisplacement = (float)((panelGraph.Width) / ((double.Parse(textBoxXMax.Text) - double.Parse(textBoxX.Text)) / 
                    (double.Parse(textBoxDx.Text))));
                float width = 0;

                List<double> labelValueList = new List<double>();
                
                while (width < (panelGraph.Width + 5))
                {
                    // Add x axis label value in list
                    labelValueList.Add(labelValue);
                    width += labelXDisplacement;
                    labelValue += double.Parse(textBoxDx.Text);
                }
                
                // Reverse the list
                labelValueList.Reverse();

                // Get string for label number formatting
                Operation obj = new Operation();
                string numberFormat = obj.GetNumberFormat(labelValueList);

                // Calculate number of grid line
                int numberOfGrid = (int)Math.Floor((double.Parse(textBoxXMax.Text) - double.Parse(textBoxX.Text)) / 
                    double.Parse(textBoxDx.Text));
                
                foreach (double value in labelValueList)
                {
                    m_objGraphics = panelXAxis.CreateGraphics();

                    // Create font and brush.
                    Font drawFont = new Font("Arial", 8, FontStyle.Bold);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);

                    // Set format of string.
                    StringFormat drawFormat = new StringFormat();
                    drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

                    if (labelValueList[0].ToString(numberFormat).Length > 10)
                    {
                        // Rotate the x axis label
                        m_objGraphics.TranslateTransform(labelXDisplacement * (labelValueList.Count - 1) + 18, 55);
                        m_objGraphics.RotateTransform(180);

                        // Draw string to screen.
                        m_objGraphics.DrawString(value.ToString("E1"), drawFont, drawBrush, labelPoint.X, labelPoint.Y, drawFormat);
                    }
                    else
                    {
                        // Rotate the x axis label
                        m_objGraphics.TranslateTransform((labelXDisplacement * (labelValueList.Count - 1) + 18),
                            numberFormat.Length < 5 ? numberFormat.Length * 10 : numberFormat.Length * 7);
                        m_objGraphics.RotateTransform(180);

                        // Draw string to screen.
                        m_objGraphics.DrawString(value.ToString(numberFormat), drawFont, drawBrush, labelPoint.X, labelPoint.Y, drawFormat);
                    }
                    
                    m_objGraphics.ResetTransform();
                    
                    labelPoint.X += labelXDisplacement;
                }
            }
            catch (Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Draw label on y axis
        /// </summary>
        private void DrawLabelYAxis()
        {
            try
            {
                // Starting point to draw y axis label
                System.Drawing.PointF point1 = new PointF();
                point1.Y = panelYAxis.Height - 17;

                // Store y axis label values
                double labelValue = float.Parse(textBoxY.Text);

                // Set value for label y axis displacement
                float labelYDisplacement = (panelGraph.Height) / ((float.Parse(textBoxYMax.Text) - float.Parse(textBoxY.Text)) / 
                    (float.Parse(textBoxDy.Text)));
                float height = panelGraph.Height + 10;

                // Add label values in list
                List<double> labelValueList = new List<double>();
                while (height > 0)
                {
                    labelValueList.Add(labelValue);
                    labelValue += double.Parse(textBoxDy.Text);
                    height -= labelYDisplacement;
                }

                // Reverse the list
                labelValueList.Reverse();

                // Get string for label number formatting
                Operation obj = new Operation();
                string numberFormat = obj.GetNumberFormat(labelValueList);

                // Reverse the list
                labelValueList.Reverse();

                foreach (double value in labelValueList)
                {
                    m_objGraphics = panelYAxis.CreateGraphics();

                    // Create font and brush.
                    Font drawFont = new Font("Arial", 8, FontStyle.Bold);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);

                    // Set format of string.
                    StringFormat drawFormat = new StringFormat();

                    if (labelValueList[labelValueList.Count - 1].ToString(numberFormat).Length > 10)
                    {
                        // Draw string to screen.
                        m_objGraphics.DrawString(value.ToString("E1"), drawFont, drawBrush,
                            panelYAxis.Width - 55,
                            point1.Y, drawFormat);
                    }
                    else
                    {
                        // Draw string to screen.
                        m_objGraphics.DrawString(value.ToString(numberFormat), drawFont, drawBrush,
                            panelYAxis.Width - (numberFormat.Length < 5 ? numberFormat.Length * 10f : numberFormat.Length * 7f),
                            point1.Y, drawFormat);
                    }
                    
                    point1.Y -= labelYDisplacement;
                }
            }
            catch (Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.ToString(), Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Show grid line
        /// </summary>
        private void ShowGridLine()
        {
            if (checkBoxShowGrid.Checked == true)
            {
                // Draw grid line
                DrawGridLine();
            }
        }

        /// <summary>
        /// Draw grid line on the panel
        /// </summary>
        private void DrawGridLine()
        {
            try
            {
                // Start point to draw vertical grid line
                PointF gridXStart = new PointF(0, panelGraph.Height);

                // End point to draw vertical grid line
                PointF gridXEnd = new PointF(0, 0);

                // Start point to draw horizontal grid line
                PointF gridYStart = new PointF(0, panelGraph.Height);

                // End point to draw horizontal grid line
                PointF gridYEnd = new PointF(panelGraph.Width, 0);

                m_objGraphics = panelGraph.CreateGraphics();

                // Set grid displacement
                float gridXDisplacement = panelGraph.Width / ((float.Parse(textBoxXMax.Text) - float.Parse(textBoxX.Text)) / 
                    float.Parse(textBoxDx.Text));
                float gridYDisplacement = panelGraph.Height / ((float.Parse(textBoxYMax.Text) - float.Parse(textBoxY.Text)) / 
                    float.Parse(textBoxDy.Text));
                float width = panelGraph.Width;

                // Draw x axis grid line
                while (width > 0)
                {
                    // Start point
                    gridXStart.X += gridXDisplacement;
                    gridXStart.Y = panelGraph.Height;

                    // End point
                    gridXEnd.X += gridXDisplacement;
                    gridXEnd.Y = 0;

                    // Draw x axis grid line
                    m_objGraphics.DrawLine(new Pen(Color.Green, 1), gridXStart, gridXEnd);
                    width -= gridXDisplacement;
                }

                float height = panelGraph.Height;

                // Draw y axis grid line
                while (height > 0)
                {
                    // Start point
                    gridYStart.X = 0;
                    gridYStart.Y -= gridYDisplacement;

                    // End point
                    gridYEnd.X = panelGraph.Width;
                    gridYEnd.Y = gridYStart.Y;

                    // Draw y axis grid line
                    m_objGraphics.DrawLine(new Pen(Color.Green, 1), gridYStart, gridYEnd);
                    height -= gridYDisplacement;
                }

                //m_objGraphics.Dispose();
            }
            catch (Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Perform operation to open file dialog
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event argument</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Object of open file dialog
                OpenFileDialog fileDialog = new OpenFileDialog();

                // Set xml file filter
                fileDialog.Filter = Constant.DEF_XML_FILE_FILTER;

                // Check for dialog result for ok
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hide the graph
                    ManageGraphVisibility(false);

                    // Clear the old graph and labels
                    this.Invalidate();

                    // Get path of the xml file
                    string filePath = fileDialog.FileName;

                    // Set graph title bar text as xml file name
                    this.Text = string.Format("{0} - {1}", Constant.DEF_GRAPH, Path.GetFileName(filePath));
                    FormGraph_Load(sender, e);

                    // Read xml file
                    XmlReader objXmlReader = new XmlReader();
                    Points objPoints = objXmlReader.ReadXmlFile(filePath);

                    if (objPoints == null)
                    {
                        // Show error message for invalid xml file select valid xml file 
                        MessageBox.Show(Constant.ERR_INVALID_XML_FILE_SELECT_VALID_XML_FILE, Constant.DEF_GRAPH, 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        // To show previous graph
                        buttonRefresh_Click(sender, e);
                    }
                    else
                    {
                        // Get cordinates in ascending order from xml file 
                        Operation objOperation = new Operation();
                        m_cordinates = objOperation.SortAscending(objPoints);

                        // Set default values in text boxes
                        SetDefaultValues(m_cordinates);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set default values
        /// </summary>
        private void SetDefaultValues(double[,] cordinates)
        {
            try
            {
                // Get minimum and maximum value of x cordinate and y cordinate
                Operation objOperation = new Operation();
                List<double> minMax = objOperation.GetMinMaxCordinates(cordinates);

                // Set minimum and maximum values in text boxes
                textBoxXMin.Text = minMax[0].ToString();
                textBoxXMax.Text = minMax[1].ToString();
                textBoxYMin.Text = minMax[2].ToString();
                textBoxYMax.Text = minMax[3].ToString();

                // Set start point
                textBoxX.Text = textBoxXMin.Text;
                textBoxY.Text = textBoxYMin.Text;

                // Enable the point range textboxes
                textBoxXMin.Enabled = true;
                textBoxXMax.Enabled = true;
                textBoxYMin.Enabled = true;
                textBoxYMax.Enabled = true;

                // Enable the check boxes
                checkBoxShowGrid.Enabled = true;
                checkBoxGridSpacing.Enabled = true;
                checkBoxShowPoints.Enabled = true;
                checkBoxStartPoint.Enabled = true;

                // Enable the refresh button
                buttonRefresh.Enabled = true;

                // Visible the point range text boxes
                textBoxXMin.Visible = true;
                textBoxXMax.Visible = true;
                textBoxYMin.Visible = true;
                textBoxYMax.Visible = true;

                // Uncheck the checkboxes
                checkBoxGridSpacing.Checked = false;
                checkBoxShowGrid.Checked = false;
                checkBoxShowPoints.Checked = false;
                checkBoxStartPoint.Checked = false;

                // Calculate x range
                double xRange = minMax[1] - minMax[0];
                double yRange = minMax[3] - minMax[2];

                // Calculate grid spacing
                double dx = xRange / 10;
                double dy = yRange / 10;

                // Check grid spacing for greater than zero
                if (dx <= 0 || dy <= 0)
                {
                    // Hide the graph
                    ManageGraphVisibility(false);

                    // Set start point and grid spacing text boxes to zero
                    textBoxX.Text = "0";
                    textBoxY.Text = "0";
                    textBoxDx.Text = "0";
                    textBoxDy.Text = "0";

                    // Show message dialog for default value can not be calculated
                    string message = Constant.ERR_DEFAULT_VALUE_CAN_NOT_BE_CALCULATED;
                    MessageBox.Show(message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Checked the checkboxes
                    checkBoxStartPoint.Checked = true;
                    checkBoxGridSpacing.Checked = true;
                }
                else
                {
                    // Make visible the graph
                    ManageGraphVisibility(true);

                    // Set grid spacing
                    textBoxDx.Text = dx.ToString();
                    textBoxDy.Text = dy.ToString();

                    // Draw label string for x axis
                    DrawLabelXAxis();

                    // Draw label string for y axis
                    DrawLabelYAxis();

                    // Draw line
                    DrawLine();
                }
            }
            catch(Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Manage graph visibility
        /// </summary>
        /// <param name="flag"></param>
        private void ManageGraphVisibility(bool flag)
        {
            // Make visible the panel
            panelGraph.Visible = flag;
            panelXAxis.Visible = flag;
            panelYAxis.Visible = flag;
            panelGraphName.Visible = flag;
        }

        /// <summary>
        /// Enable or disable the start point textboxes
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event argument</param>
        private void checkBoxStartPoint_CheckedChanged(object sender, EventArgs e)
        {
            // Check start point checkbox for checked or not
            if (checkBoxStartPoint.Checked == true)
            {
                // Enable the start point text box x and y
                textBoxX.Enabled = true;
                textBoxY.Enabled = true;
            }
            else
            {
                // Set default value for start point x and y
                textBoxX.Text = textBoxXMin.Text;
                textBoxY.Text = textBoxYMin.Text;

                // Disable the start point text box x and y
                textBoxX.Enabled = false;
                textBoxY.Enabled = false;
            }
        }

        /// <summary>
        /// Enable or disable the gris spacing textboxes
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event argument</param>
        private void checkBoxGridSpacing_CheckedChanged(object sender, EventArgs e)
        {
            // Check grid spacing checkbox for checked or not
            if (checkBoxGridSpacing.Checked == true)
            {
                // Enable the grid spacing textbox dx and dy
                textBoxDx.Enabled = true;
                textBoxDy.Enabled = true;
            }
            else
            {
                // Set default value for grid spacing dx and dy
                textBoxDx.Text = ((double.Parse(textBoxXMax.Text) - double.Parse(textBoxXMin.Text)) / 10).ToString();
                textBoxDy.Text = ((double.Parse(textBoxYMax.Text) - double.Parse(textBoxYMin.Text)) / 10).ToString();

                // Disable the grid spacing textbox dx and dy
                textBoxDx.Enabled = false;
                textBoxDy.Enabled = false;
            }
        }

        /// <summary>
        /// Perform exit operation
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event argument</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit from application
            Application.Exit();
        }

        /// <summary>
        /// Show information about graph application
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event argument</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About objAbout = new About();
            objAbout.ShowDialog();
        }

        /// <summary>
        /// Draw "x axis" on panel x axis
        /// </summary>
        /// <param name="sender">Objet sender</param>
        /// <param name="e">Paint event argument</param>
        private void panelXAxis_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // For displaying x axis
                String drawString = Constant.DEF_X_AXIS;

                // Create font and brush.
                Font drawFont = new Font("Arial", 10, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                // Set format of string.
                StringFormat drawFormat = new StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

                // Display x axis on the graph
                e.Graphics.DrawString(drawString, drawFont, drawBrush, (panelGraph.Width + 60) / 2 , 
                    panelXAxis.Height - (panelXAxis.Height / 5), drawFormat);

                if (panelGraph.Visible == true)
                {
                    // Draw label string for x axis
                    DrawLabelXAxis();
                }
            }
            catch (Exception ex)
            {
                // Hide the Graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Draw "y axis" on panel y axis
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Paint event argument</param>
        private void panelYAxis_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // For displaying y axis
                String drawString = Constant.DEF_Y_AXIS;

                // Create font and brush.
                Font drawFont = new Font("Arial", 10, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                // Set format of string.
                StringFormat drawFormat = new StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

                // Rotate the string as 180 degree
                e.Graphics.TranslateTransform(20, panelYAxis.Height);
                e.Graphics.RotateTransform(180);

                // Display y axis on the graph
                e.Graphics.DrawString(drawString, drawFont, drawBrush, panelYAxis.Width / 20, 
                    (panelGraph.Height / 2) - 10, drawFormat);

                if (panelGraph.Visible == true)
                {
                    // Draw label string for x axis
                    DrawLabelYAxis();
                }
                
            }
            catch (Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refresh the graph 
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event argument</param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMsg = string.Empty;

                // Validate graph setting
                if (ValidateGraphSetting(out errorMsg) == false)
                {
                    // Hide the graph
                    ManageGraphVisibility(false);

                    // Show error in message box
                    MessageBox.Show(errorMsg, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Calculate grid count
                    if (CalculateGridCount() == false)
                    {
                        //ShowGrid();

                        textBoxY.Text = m_startPointY.ToString();
                        textBoxX.Text = m_startPointX.ToString();
                        textBoxDx.Text = m_dx.ToString();
                        textBoxDy.Text = m_dy.ToString();

                        // Re draw the graph
                        panelGraph.Invalidate();
                        panelXAxis.Invalidate();
                        panelYAxis.Invalidate();
                        panelGraphName.Invalidate();

                        /*if (checkBoxShowGrid.Checked == true)
                        {
                            checkBoxShowGrid.CheckState = CheckState.Unchecked;
                        }
                        else
                        {
                            checkBoxShowGrid.CheckState = CheckState.Checked;
                        }*/

                        if (checkBoxShowGrid.Checked == true)
                        {
                            // Show grid line
                            ShowGridLine();
                        }

                        if (checkBoxShowPoints.Checked == true)
                        {
                            // Draw marker on the point
                            DrawMarker();
                        }

                        // Draw line on the graph
                        DrawLine();

                        // Make visible the graph
                        ManageGraphVisibility(true);

                        MessageBox.Show(Constant.ERR_XCOUNT_YCOUNT_HAS_TO_BE_LESS_THAN_OR_EQUAL_TO_FIFTEEN,
                            Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Make visible the graph
                    //ManageGraphVisibility(true);

                    // Re draw the graph
                    panelGraph.Invalidate();
                    panelXAxis.Invalidate();
                    panelYAxis.Invalidate();
                    panelGraphName.Invalidate();

                    /*if (checkBoxShowGrid.Checked == true)
                    {
                        // Show grid line
                        ShowGridLine();
                    }

                    if (checkBoxShowPoints.Checked == true)
                    {
                        // Draw marker on the point
                        DrawMarker();
                    }

                    // Draw line on the graph
                    DrawLine();

                    // Refresh the panel x axis
                    panelXAxis.Invalidate();
                    panelXAxis.Refresh();

                    // Refresh the panel y axis
                    panelYAxis.Invalidate();
                    panelYAxis.Refresh();

                    panelGraphName.Invalidate();

                    // Refresh the panel graph
                    panelGraph.Invalidate();
                    panelGraph.Refresh();*/
                }
            }
            catch(Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Calculate grid count
        /// </summary>
        private bool CalculateGridCount()
        {
            // Calculate x count and y count
            double xCount = Math.Round((double.Parse(textBoxXMax.Text) -
                double.Parse(textBoxX.Text)) / double.Parse(textBoxDx.Text));
            double yCount = Math.Round((double.Parse(textBoxYMax.Text) -
                double.Parse(textBoxY.Text)) / double.Parse(textBoxDy.Text));

            // Check x count or y count for greater than fifteen 
            if (xCount > 15.0 || yCount > 15.0)
            {
                /*// Assign the previous value of dx, dy, x, y;
                textBoxY.Text = m_startPointY.ToString();
                textBoxX.Text = m_startPointX.ToString();
                textBoxDx.Text = m_dx.ToString();
                textBoxDy.Text = m_dy.ToString();

                // Re draw the graph
                panelGraph.Invalidate();
                panelXAxis.Invalidate();
                panelYAxis.Invalidate();
                panelGraphName.Invalidate();

                if (checkBoxShowGrid.Checked == true)
                {
                    checkBoxShowGrid.CheckState = CheckState.Unchecked;
                }
                else
                {
                    checkBoxShowGrid.CheckState = CheckState.Checked;
                }

                if (checkBoxShowGrid.Checked == true)
                {
                    // Show grid line
                    ShowGridLine();
                }

                if (checkBoxShowPoints.Checked == true)
                {
                    // Draw marker on the point
                    DrawMarker();
                }

                // Draw line on the graph
                DrawLine();
            
                // Make visible the graph
                ManageGraphVisibility(true);

                MessageBox.Show(Constant.ERR_XCOUNT_YCOUNT_HAS_TO_BE_LESS_THAN_OR_EQUAL_TO_FIFTEEN,
                    Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);*/

                return false;
            }

            return true;
        }

        /// <summary>
        /// Draw "graph" on graph name panel
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Paint event argument</param>
        private void panelGraphName_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // For displaying graph name on graph
                String drawString = Constant.DEF_GRAPH;

                // Create font and brush.
                Font drawFont = new Font("Arial", 15, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                // Set format of string.
                StringFormat drawFormat = new StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

                // Display graph name on graph
                e.Graphics.DrawString(drawString, drawFont, drawBrush, ((panelGraph.Width + 60) / 2), 0, drawFormat);
            }
            catch (Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validate startpoint or grid spcing
        /// </summary>
        /// <param name="errorMsg">Error message</param>
        /// <returns>True for valid data or false for invalid data</returns>
        public bool ValidateGraphSetting(out string errorMsg)
        {
            errorMsg = string.Empty;

            try
            {
                // Check start point x for null or empty
                if (string.IsNullOrWhiteSpace(textBoxX.Text) == true)
                {
                    errorMsg = Constant.ERR_START_POINT_X_SHOULD_NOT_NULL_OR_EMPTY;
                    return false;
                }

                // Check start point x for null or empty
                if (string.IsNullOrWhiteSpace(textBoxY.Text) == true)
                {
                    errorMsg = Constant.ERR_START_POINT_Y_SHOULD_NOT_NULL_OR_EMPTY;
                    return false;
                }

                // Trimming the value
                textBoxX.Text = textBoxX.Text.Trim();
                textBoxY.Text = textBoxY.Text.Trim();

                // Check start point x for float or numeric value
                double result = 0.0;
                if (double.TryParse(textBoxX.Text, out result) == false)
                {
                    errorMsg = Constant.ERR_START_POINT_X_MUST_BE_NUMERIC_OR_FLOAT_VALUE;
                    return false;
                }

                // // Check start point y for float or numeric value
                if (double.TryParse(textBoxY.Text, out result) == false)
                {
                    errorMsg = Constant.ERR_START_POINT_Y_MUST_BE_NUMERIC_OR_FLOAT_VALUE;
                    return false;
                }

                // Check start point for less than x max and y max
                if (double.Parse(textBoxX.Text) >= double.Parse(textBoxXMax.Text) ||
                    double.Parse(textBoxY.Text) >= double.Parse(textBoxYMax.Text))
                {
                    errorMsg = Constant.ERR_START_POINT_HAS_TO_BE_LESS_THAN_XMAX_AND_YMAX;
                    return false;
                }

                // Check grid spacing dx for null or empty
                if (string.IsNullOrWhiteSpace(textBoxDx.Text) == true)
                {
                    errorMsg = Constant.ERR_GRID_SPACING_DX_SHOULD_NOT_NULL_OR_EMPTY;
                    return false;
                }

                // Check grid spacing dy for null or empty
                if (string.IsNullOrWhiteSpace(textBoxDy.Text) == true)
                {
                    errorMsg = Constant.ERR_GRID_SPACING_DY_SHOULD_NOT_NULL_OR_EMPTY; ;
                    return false;
                }

                // Trimming the value
                textBoxDy.Text = textBoxDy.Text.Trim();
                textBoxDx.Text = textBoxDx.Text.Trim();

                // Check grid spacing dx for float or numeric value
                if (double.TryParse(textBoxDx.Text, out result) == false)
                {
                    errorMsg = Constant.ERR_GRID_SPACING_DX_MUST_BE_NUMERIC_OR_FLOAT_VALUE;
                    return false;
                }

                // Check grid spacing dy for float or numeric value
                if (double.TryParse(textBoxDy.Text, out result) == false)
                {
                    errorMsg = Constant.ERR_GRID_SPACING_DY_MUST_BE_NUMERIC_OR_FLOAT_VALUE;
                    return false;
                }

                // Check grid spacing dx for less than or equal to zero
                if (double.Parse(textBoxDx.Text) <= 0.0)
                {
                    errorMsg = Constant.ERR_GRID_SPACING_DX_MUST_BE_GREATER_THAN_ZERO;
                    return false;
                }

                // Check grid spacing dy for less than or equal to zero
                if (double.Parse(textBoxDy.Text) <= 0.0)
                {
                    errorMsg = Constant.ERR_GRID_SPACING_DY_MUST_BE_GREATER_THAN_ZERO;
                    return false;
                }
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }

            return true;
        }
        
        /// <summary>
        /// Set the title of the form in center
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event argument</param>
        private void FormGraph_Load(object sender, EventArgs e)
        {
            try
            {
                m_objGraphics  = this.CreateGraphics();

                // Get starting point
                double startingPoint = (this.Width / 2) - (m_objGraphics.MeasureString(this.Text.Trim(), this.Font).Width / 2);
                double widthOfASpace = m_objGraphics.MeasureString(" ", this.Font).Width;
                string whiteSpace = " ";
                double tmpWidth = 0;

                // Add white space
                while ((tmpWidth + widthOfASpace) < startingPoint)
                {
                    whiteSpace += " ";
                    tmpWidth += widthOfASpace;
                }

                this.Text = whiteSpace + this.Text.Trim();
            }
            catch (Exception ex)
            {
                // Hide the graph
                ManageGraphVisibility(false);

                // Show message box for exception error
                MessageBox.Show(ex.Message, Constant.DEF_GRAPH, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refresh the graph over resizing the form
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event argument</param>
        private void FormGraph_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState.Equals(FormWindowState.Minimized) == false)
            {
                buttonRefresh.PerformClick();
                /*CalculateGridCount();

                // Re draw the graph
                panelGraph.Invalidate();
                panelXAxis.Invalidate();
                panelYAxis.Invalidate();
                panelGraphName.Invalidate();

               if (checkBoxShowGrid.Checked == true)
                {
                    // Show grid line
                    ShowGridLine();
                }

                // Draw line on the graph
                DrawLine();

                if (checkBoxShowPoints.Checked == true)
                {
                    // Draw marker on the point
                    DrawMarker();
                }*/
            }
        }
        
        /// <summary>
        /// Perform refresh button operation
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event argument</param>
        private void checkBoxShowPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (panelGraph.Visible == true)
            {
                buttonRefresh.PerformClick();
                /*// Calculate grid count
                CalculateGridCount();

                if (checkBoxShowPoints.Checked == true)
                {
                    // Draw marker on point
                    DrawMarker();
                }
                else
                {
                    // Clear the old graph
                    panelGraph.Invalidate();
                    panelGraph.Refresh();

                    // Show grid line
                    ShowGridLine();

                    // Draw line on the graph
                    DrawLine();
                }*/
            }
        }
        
        /// <summary>
        /// Perform refresh button operation
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event Argument</param>
        private void checkBoxShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (panelGraph.Visible == true)
            {
                buttonRefresh.PerformClick();
                /*// Calculate grid count
                CalculateGridCount();

                if (checkBoxShowGrid.Checked == true)
                {
                    // Perform click on refresh button
                    DrawGridLine();

                    // Draw line
                    DrawLine();
                }
                else
                {
                    // Refresh the panel graph
                    panelGraph.Refresh();

                    if (checkBoxShowPoints.Checked == true)
                    {
                        // Draw marker on point
                        DrawMarker();
                    }

                    // Draw line
                    DrawLine();
                }*/
            }
        }
        
        /// <summary>
        /// Validate text box start point x and y
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Key press event arguments</param>
        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digit, E, +, - or decimal point
            if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false &&
                e.KeyChar.Equals('E') == false && e.KeyChar.Equals('.') == false && e.KeyChar.Equals('-') == false && 
                e.KeyChar.Equals('+') == false)
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validate text box grid spacing dx and dy
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Key press event argument</param>
        private void textBoxDx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digit, E, + or decimal point
            if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false &&
                e.KeyChar.Equals('E') == false && e.KeyChar.Equals('.') == false && e.KeyChar.Equals('+') == false)
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
        /// <summary>
        /// Draw drawing on the panel graph
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Paint event argument</param>
        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            if (panelGraph.Visible == true)
            {
                if (checkBoxShowGrid.Checked == true)
                {
                    // Show grid line
                    ShowGridLine();
                }

                if (checkBoxShowPoints.Checked == true)
                {
                    // Draw marker on the point
                    DrawMarker();
                }

                // Draw line on the graph
                DrawLine();
            }
        }
        #endregion

        private void checkBoxShowGrid_Click(object sender, EventArgs e)
        {
            if (panelGraph.Visible == true)
            {
                buttonRefresh.PerformClick();
            }
        }

        private void ShowGrid()
        {
            if (m_dx != double.Parse(textBoxDx.Text))
            {
                if (checkBoxShowGrid.Checked == true)
                {
                    checkBoxShowGrid.CheckState = CheckState.Unchecked;
                }
                else
                {
                    checkBoxShowGrid.CheckState = CheckState.Checked;
                }
            }
        }
    }
}
