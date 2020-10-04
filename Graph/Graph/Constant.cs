namespace Graph
{
    /// <summary>
    /// Constant messages and default value
    /// </summary>
    public class Constant
    {
        #region Default values
        /// <summary>
        /// Default value for graph
        /// </summary>
        internal const string DEF_GRAPH = "Graph";

        /// <summary>
        /// Default value for y axis
        /// </summary>
        internal const string DEF_Y_AXIS = "Y Axis";

        /// <summary>
        /// Default value for x axis
        /// </summary>
        internal const string DEF_X_AXIS = "X Axis";

        /// <summary>
        /// Default value for xml file filter
        /// </summary>
        internal const string DEF_XML_FILE_FILTER = "XML Files (*.xml)|*.xml";
        #endregion

        #region Error messages
        /// <summary>
        /// For displaying error message for invalid cordinate
        /// </summary>
        internal const string ERR_INVALID_CORDINATE = "Invalid cordinate";

        /// <summary>
        /// For displaying error message for grid spacing dx should not be null or empty
        /// </summary>
        internal const string ERR_GRID_SPACING_DX_SHOULD_NOT_NULL_OR_EMPTY = "Grid spacing Dx should not be null or empty.";

        /// <summary>
        /// For displaying error message for grid spacing dy should not be null or empty
        /// </summary>
        internal const string ERR_GRID_SPACING_DY_SHOULD_NOT_NULL_OR_EMPTY = "Grid spacing Dy should not be null or empty.";

        /// <summary>
        /// For displaying error message for grid spacing dx must be numeric or float value
        /// </summary>
        internal const string ERR_GRID_SPACING_DX_MUST_BE_NUMERIC_OR_FLOAT_VALUE = "Grid spacing Dx must be numeric or float value.";

        /// <summary>
        /// For displaying error message for grid spacing dy must be numeric or float value
        /// </summary>
        internal const string ERR_GRID_SPACING_DY_MUST_BE_NUMERIC_OR_FLOAT_VALUE = "Grid spacing Dy must be numeric or float value.";

        /// <summary>
        /// For displaying error message for start point x should not be null or empty
        /// </summary>
        internal const string ERR_START_POINT_X_SHOULD_NOT_NULL_OR_EMPTY = "Start point X should not be null or empty.";

        /// <summary>
        /// For displaying error message for start point y should not be null or empty
        /// </summary>
        internal const string ERR_START_POINT_Y_SHOULD_NOT_NULL_OR_EMPTY = "Start point Y should not be null or empty.";

        /// <summary>
        /// For displaying error message for start point x must be numeric or float value
        /// </summary>
        internal const string ERR_START_POINT_X_MUST_BE_NUMERIC_OR_FLOAT_VALUE = "Start point X must be numeric or float value.";

        /// <summary>
        /// For displaying error message for start point y must be numeric or float value
        /// </summary>
        internal const string ERR_START_POINT_Y_MUST_BE_NUMERIC_OR_FLOAT_VALUE = "Start point Y must be numeric or float value.";

        /// <summary>
        /// For displaying error message for for current input file default value can not be calculated please enter it yourself and press refresh
        /// </summary>
        internal const string ERR_DEFAULT_VALUE_CAN_NOT_BE_CALCULATED = "For current input file, default value can not be calculated, please enter it yourself and press refresh.";

        /// <summary>
        /// For displaying error message for for grid spacing dx must be greater than 0
        /// </summary>
        internal const string ERR_GRID_SPACING_DX_MUST_BE_GREATER_THAN_ZERO = "Grid Spacing dx must be greater than 0.";

        /// <summary>
        /// For displaying error message for for grid spacing dy must be greater than 0
        /// </summary>
        internal const string ERR_GRID_SPACING_DY_MUST_BE_GREATER_THAN_ZERO = "Grid Spacing dy must be greater than 0.";

        /// <summary>
        /// For displaying error message for for start point x and y has to be less than x max and y max respectively
        /// </summary>
        internal const string ERR_START_POINT_HAS_TO_BE_LESS_THAN_XMAX_AND_YMAX = "Start point (X,Y) has to less than X Max and Y Max respectively.";

        /// <summary>
        /// For displaying error message for for x count and y count both has to be less than or equal to 15
        /// </summary>
        internal const string ERR_XCOUNT_YCOUNT_HAS_TO_BE_LESS_THAN_OR_EQUAL_TO_FIFTEEN = "X count and Y count both has to be less than or equal to 15.";

        /// <summary>
        /// For displaying error message for for invalid xml file select valid xml file
        /// </summary>
        internal const string ERR_INVALID_XML_FILE_SELECT_VALID_XML_FILE = "Invalid Xml File! Select valid xml file.";
        #endregion
    }
}
