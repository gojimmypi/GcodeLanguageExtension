using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace GcodeLanguage
{

    #region Keyword Undefined
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_Undefined")]
    [Name("CTN_Gcode_Undefined")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_Undefined : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode Undefined classification type
        /// </summary>
        public Gcode_Undefined()
        {
            DisplayName = "Gcode - Undefined"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
        }
    }
    #endregion


    #region Keyword A 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_A")]
    [Name("CTN_Gcode_A")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_A : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode A  classification type
        /// </summary>
        public Gcode_A()
        {
            DisplayName = "Gcode - A"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword B 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_B")]
    [Name("CTN_Gcode_B")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_B : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode B  classification type
        /// </summary>
        public Gcode_B()
        {
            DisplayName = "Gcode - B"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword C 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_C")]
    [Name("CTN_Gcode_C")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_C : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode C  classification type
        /// </summary>
        public Gcode_C()
        {
            DisplayName = "Gcode - C"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword D 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_D")]
    [Name("CTN_Gcode_D")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_D : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode D  classification type
        /// </summary>
        public Gcode_D()
        {
            DisplayName = "Gcode - D"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword E 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_E")]
    [Name("CTN_Gcode_E")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_E : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode E  classification type
        /// </summary>
        public Gcode_E()
        {
            DisplayName = "Gcode - E"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword F 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_F")]
    [Name("CTN_Gcode_F")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_F : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode F  classification type
        /// </summary>
        public Gcode_F()
        {
            DisplayName = "Gcode - F"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword G 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_G")]
    [Name("CTN_Gcode_G")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_G : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode G  classification type
        /// </summary>
        public Gcode_G()
        {
            DisplayName = "Gcode - G"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Coral;
        }
    }
    #endregion


    #region Keyword H 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_H")]
    [Name("CTN_Gcode_H")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_H : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode H  classification type
        /// </summary>
        public Gcode_H()
        {
            DisplayName = "Gcode - H"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword I 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_I")]
    [Name("CTN_Gcode_I")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_I : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode I  classification type
        /// </summary>
        public Gcode_I()
        {
            DisplayName = "Gcode - I"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword J 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_J")]
    [Name("CTN_Gcode_J")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_J : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode J  classification type
        /// </summary>
        public Gcode_J()
        {
            DisplayName = "Gcode - J"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword K 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_K")]
    [Name("CTN_Gcode_K")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_K : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode K  classification type
        /// </summary>
        public Gcode_K()
        {
            DisplayName = "Gcode - K"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword L 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_L")]
    [Name("CTN_Gcode_L")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_L : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode L  classification type
        /// </summary>
        public Gcode_L()
        {
            DisplayName = "Gcode - L"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword M 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_M")]
    [Name("CTN_Gcode_M")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_M : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode M  classification type
        /// </summary>
        public Gcode_M()
        {
            DisplayName = "Gcode - M"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Coral;
        }
    }
    #endregion


    #region Keyword N 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_N")]
    [Name("CTN_Gcode_N")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_N : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode N  classification type
        /// </summary>
        public Gcode_N()
        {
            DisplayName = "Gcode - N"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword O 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_O")]
    [Name("CTN_Gcode_O")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_O : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode O  classification type
        /// </summary>
        public Gcode_O()
        {
            DisplayName = "Gcode - O"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword P 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_P")]
    [Name("CTN_Gcode_P")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_P : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode P  classification type
        /// </summary>
        public Gcode_P()
        {
            DisplayName = "Gcode - P"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword Q 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_Q")]
    [Name("CTN_Gcode_Q")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_Q : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode Q  classification type
        /// </summary>
        public Gcode_Q()
        {
            DisplayName = "Gcode - Q"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword R 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_R")]
    [Name("CTN_Gcode_R")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_R : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode R  classification type
        /// </summary>
        public Gcode_R()
        {
            DisplayName = "Gcode - R"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword S 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_S")]
    [Name("CTN_Gcode_S")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_S : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode S  classification type
        /// </summary>
        public Gcode_S()
        {
            DisplayName = "Gcode - S"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword T 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_T")]
    [Name("CTN_Gcode_T")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_T : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode T  classification type
        /// </summary>
        public Gcode_T()
        {
            DisplayName = "Gcode - T"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword U 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_U")]
    [Name("CTN_Gcode_U")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_U : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode U  classification type
        /// </summary>
        public Gcode_U()
        {
            DisplayName = "Gcode - U"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword V 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_V")]
    [Name("CTN_Gcode_V")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_V : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode V  classification type
        /// </summary>
        public Gcode_V()
        {
            DisplayName = "Gcode - V"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword W 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_W")]
    [Name("CTN_Gcode_W")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_W : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode W  classification type
        /// </summary>
        public Gcode_W()
        {
            DisplayName = "Gcode - W"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.BlueViolet;
        }
    }
    #endregion


    #region Keyword X 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_X")]
    [Name("CTN_Gcode_X")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_X : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode X  classification type
        /// </summary>
        public Gcode_X()
        {
            DisplayName = "Gcode - X"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Tomato;
            BackgroundColor = Colors.MidnightBlue;
        }
    }
    #endregion


    #region Keyword Y 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_Y")]
    [Name("CTN_Gcode_Y")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_Y : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode Y  classification type
        /// </summary>
        public Gcode_Y()
        {
            DisplayName = "Gcode - Y"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.LawnGreen;
            BackgroundColor = Colors.MidnightBlue;
        }
    }
    #endregion


    #region Keyword Z 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_Z")]
    [Name("CTN_Gcode_Z")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_Z : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode Z  classification type
        /// </summary>
        public Gcode_Z()
        {
            DisplayName = "Gcode - Z"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cyan;
            BackgroundColor = Colors.MidnightBlue;
        }
    }
    #endregion


    #region Keyword minus 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_minus")]
    [Name("CTN_Gcode_minus")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_minus : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode minus  classification type
        /// </summary>
        public Gcode_minus()
        {
            DisplayName = "Gcode - minus"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 0 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_0")]
    [Name("CTN_Gcode_0")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_0 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 0  classification type
        /// </summary>
        public Gcode_0()
        {
            DisplayName = "Gcode - 0"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 1 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_1")]
    [Name("CTN_Gcode_1")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_1 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 1  classification type
        /// </summary>
        public Gcode_1()
        {
            DisplayName = "Gcode - 1"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 2 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_2")]
    [Name("CTN_Gcode_2")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_2 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 2  classification type
        /// </summary>
        public Gcode_2()
        {
            DisplayName = "Gcode - 2"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 3 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_3")]
    [Name("CTN_Gcode_3")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_3 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 3  classification type
        /// </summary>
        public Gcode_3()
        {
            DisplayName = "Gcode - 3"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 4 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_4")]
    [Name("CTN_Gcode_4")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_4 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 4  classification type
        /// </summary>
        public Gcode_4()
        {
            DisplayName = "Gcode - 4"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 5 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_5")]
    [Name("CTN_Gcode_5")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_5 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 5  classification type
        /// </summary>
        public Gcode_5()
        {
            DisplayName = "Gcode - 5"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 6 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_6")]
    [Name("CTN_Gcode_6")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_6 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 6  classification type
        /// </summary>
        public Gcode_6()
        {
            DisplayName = "Gcode - 6"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 7 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_7")]
    [Name("CTN_Gcode_7")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_7 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 7  classification type
        /// </summary>
        public Gcode_7()
        {
            DisplayName = "Gcode - 7"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 8 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_8")]
    [Name("CTN_Gcode_8")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_8 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 8  classification type
        /// </summary>
        public Gcode_8()
        {
            DisplayName = "Gcode - 8"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Keyword 9 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Gcode_9")]
    [Name("CTN_Gcode_9")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_9 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 9  classification type
        /// </summary>
        public Gcode_9()
        {
            DisplayName = "Gcode - 9"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion


    #region Gcode Comment 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "CTN_Gcode_Comment")]
    [Name("Gcode_Comment")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Gcode_Comment : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 9  classification type
        /// </summary>
        public Gcode_Comment()
        {
            DisplayName = "Gcode - Comment"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.Green;
        }
    }
    #endregion

    #region ocode Comment
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "g_ocode")]
    [Name("g_ocode")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class ocode : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the gcode 9  classification type
        /// </summary>
        public ocode()
        {
            DisplayName = "Gcode - ocode"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
            ForegroundColor = Colors.DarkOrange;
        }
    }
    #endregion
}
