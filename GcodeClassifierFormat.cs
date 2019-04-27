﻿using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace GcodeLanguage
{


    #region Keyword A 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "A")]
    [Name("A")]
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
    [ClassificationType(ClassificationTypeNames = "B")]
    [Name("B")]
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
    [ClassificationType(ClassificationTypeNames = "C")]
    [Name("C")]
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
    [ClassificationType(ClassificationTypeNames = "D")]
    [Name("D")]
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
    [ClassificationType(ClassificationTypeNames = "E")]
    [Name("E")]
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
    [ClassificationType(ClassificationTypeNames = "F")]
    [Name("F")]
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
    [ClassificationType(ClassificationTypeNames = "G")]
    [Name("G")]
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
            ForegroundColor = Colors.Yellow;
        }
    }
    #endregion


    #region Keyword H 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "H")]
    [Name("H")]
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
    [ClassificationType(ClassificationTypeNames = "I")]
    [Name("I")]
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
    [ClassificationType(ClassificationTypeNames = "J")]
    [Name("J")]
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
    [ClassificationType(ClassificationTypeNames = "K")]
    [Name("K")]
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
    [ClassificationType(ClassificationTypeNames = "L")]
    [Name("L")]
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
    [ClassificationType(ClassificationTypeNames = "M")]
    [Name("M")]
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
            ForegroundColor = Colors.Yellow;
        }
    }
    #endregion


    #region Keyword N 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "N")]
    [Name("N")]
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
    [ClassificationType(ClassificationTypeNames = "O")]
    [Name("O")]
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
    [ClassificationType(ClassificationTypeNames = "P")]
    [Name("P")]
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
    [ClassificationType(ClassificationTypeNames = "Q")]
    [Name("Q")]
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
    [ClassificationType(ClassificationTypeNames = "R")]
    [Name("R")]
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
    [ClassificationType(ClassificationTypeNames = "S")]
    [Name("S")]
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
    [ClassificationType(ClassificationTypeNames = "T")]
    [Name("T")]
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
    [ClassificationType(ClassificationTypeNames = "U")]
    [Name("U")]
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
    [ClassificationType(ClassificationTypeNames = "V")]
    [Name("V")]
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
    [ClassificationType(ClassificationTypeNames = "W")]
    [Name("W")]
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
    [ClassificationType(ClassificationTypeNames = "X")]
    [Name("X")]
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
            ForegroundColor = Colors.Red;
        }
    }
    #endregion


    #region Keyword Y 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Y")]
    [Name("Y")]
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
            ForegroundColor = Colors.Green;
        }
    }
    #endregion


    #region Keyword Z 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "Z")]
    [Name("Z")]
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
            ForegroundColor = Colors.Blue;
        }
    }
    #endregion


    #region Keyword minus 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "minus")]
    [Name("minus")]
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
    [ClassificationType(ClassificationTypeNames = "0")]
    [Name("0")]
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
    [ClassificationType(ClassificationTypeNames = "1")]
    [Name("1")]
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
    [ClassificationType(ClassificationTypeNames = "2")]
    [Name("2")]
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
    [ClassificationType(ClassificationTypeNames = "3")]
    [Name("3")]
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
    [ClassificationType(ClassificationTypeNames = "4")]
    [Name("4")]
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
    [ClassificationType(ClassificationTypeNames = "5")]
    [Name("5")]
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
    [ClassificationType(ClassificationTypeNames = "6")]
    [Name("6")]
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
    [ClassificationType(ClassificationTypeNames = "7")]
    [Name("7")]
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
    [ClassificationType(ClassificationTypeNames = "8")]
    [Name("8")]
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
    [ClassificationType(ClassificationTypeNames = "9")]
    [Name("9")]
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
    [ClassificationType(ClassificationTypeNames = "gComment")]
    [Name("gComment")]
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
            ForegroundColor = Colors.Cornsilk;
        }
    }
    #endregion

}