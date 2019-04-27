using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace GcodeLanguage
{
    /// <summary>
    /// Classification type definition export for GcodeClassifier
    /// </summary>
    internal static class GcodeClassifierClassificationDefinition
    {
        // This disables "The field is never used" compiler's warning. Justification: the field is used by MEF.
#pragma warning disable 169

        /// <summary>
        /// Defines the "GcodeClassifier" classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("GcodeClassifier")]
        private static ClassificationTypeDefinition typeDefinition;

#pragma warning restore 169


        /// <summary>
        /// Defines the Gcode_A classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("A")]
        internal static ClassificationTypeDefinition Gcode_A = null;


        /// <summary>
        /// Defines the Gcode_B classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("B")]
        internal static ClassificationTypeDefinition Gcode_B = null;


        /// <summary>
        /// Defines the Gcode_C classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("C")]
        internal static ClassificationTypeDefinition Gcode_C = null;


        /// <summary>
        /// Defines the Gcode_D classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("D")]
        internal static ClassificationTypeDefinition Gcode_D = null;


        /// <summary>
        /// Defines the Gcode_E classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("E")]
        internal static ClassificationTypeDefinition Gcode_E = null;


        /// <summary>
        /// Defines the Gcode_F classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("F")]
        internal static ClassificationTypeDefinition Gcode_F = null;


        /// <summary>
        /// Defines the Gcode_G classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("G")]
        internal static ClassificationTypeDefinition Gcode_G = null;


        /// <summary>
        /// Defines the Gcode_H classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("H")]
        internal static ClassificationTypeDefinition Gcode_H = null;


        /// <summary>
        /// Defines the Gcode_I classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("I")]
        internal static ClassificationTypeDefinition Gcode_I = null;


        /// <summary>
        /// Defines the Gcode_J classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("J")]
        internal static ClassificationTypeDefinition Gcode_J = null;


        /// <summary>
        /// Defines the Gcode_K classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("K")]
        internal static ClassificationTypeDefinition Gcode_K = null;


        /// <summary>
        /// Defines the Gcode_L classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("L")]
        internal static ClassificationTypeDefinition Gcode_L = null;


        /// <summary>
        /// Defines the Gcode_M classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("M")]
        internal static ClassificationTypeDefinition Gcode_M = null;


        /// <summary>
        /// Defines the Gcode_N classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("N")]
        internal static ClassificationTypeDefinition Gcode_N = null;


        /// <summary>
        /// Defines the Gcode_O classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("O")]
        internal static ClassificationTypeDefinition Gcode_O = null;


        /// <summary>
        /// Defines the Gcode_P classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("P")]
        internal static ClassificationTypeDefinition Gcode_P = null;


        /// <summary>
        /// Defines the Gcode_Q classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Q")]
        internal static ClassificationTypeDefinition Gcode_Q = null;


        /// <summary>
        /// Defines the Gcode_R classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("R")]
        internal static ClassificationTypeDefinition Gcode_R = null;


        /// <summary>
        /// Defines the Gcode_S classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("S")]
        internal static ClassificationTypeDefinition Gcode_S = null;


        /// <summary>
        /// Defines the Gcode_T classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("T")]
        internal static ClassificationTypeDefinition Gcode_T = null;


        /// <summary>
        /// Defines the Gcode_U classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("U")]
        internal static ClassificationTypeDefinition Gcode_U = null;


        /// <summary>
        /// Defines the Gcode_V classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("V")]
        internal static ClassificationTypeDefinition Gcode_V = null;


        /// <summary>
        /// Defines the Gcode_W classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("W")]
        internal static ClassificationTypeDefinition Gcode_W = null;


        /// <summary>
        /// Defines the Gcode_X classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("X")]
        internal static ClassificationTypeDefinition Gcode_X = null;


        /// <summary>
        /// Defines the Gcode_Y classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Y")]
        internal static ClassificationTypeDefinition Gcode_Y = null;


        /// <summary>
        /// Defines the Gcode_Z classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Z")]
        internal static ClassificationTypeDefinition Gcode_Z = null;


        /// <summary>
        /// Defines the Gcode_minus classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("minus")]
        internal static ClassificationTypeDefinition Gcode_minus = null;


        /// <summary>
        /// Defines the Gcode_0 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("0")]
        internal static ClassificationTypeDefinition Gcode_0 = null;


        /// <summary>
        /// Defines the Gcode_1 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("1")]
        internal static ClassificationTypeDefinition Gcode_1 = null;


        /// <summary>
        /// Defines the Gcode_2 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("2")]
        internal static ClassificationTypeDefinition Gcode_2 = null;


        /// <summary>
        /// Defines the Gcode_3 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("3")]
        internal static ClassificationTypeDefinition Gcode_3 = null;


        /// <summary>
        /// Defines the Gcode_4 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("4")]
        internal static ClassificationTypeDefinition Gcode_4 = null;


        /// <summary>
        /// Defines the Gcode_5 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("5")]
        internal static ClassificationTypeDefinition Gcode_5 = null;


        /// <summary>
        /// Defines the Gcode_6 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("6")]
        internal static ClassificationTypeDefinition Gcode_6 = null;


        /// <summary>
        /// Defines the Gcode_7 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("7")]
        internal static ClassificationTypeDefinition Gcode_7 = null;


        /// <summary>
        /// Defines the Gcode_8 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("8")]
        internal static ClassificationTypeDefinition Gcode_8 = null;


        /// <summary>
        /// Defines the Gcode_9 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("9")]
        internal static ClassificationTypeDefinition Gcode_9 = null;


        /// <summary>
        /// Defines the Comment classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("Comment")]
        internal static ClassificationTypeDefinition Gcode_Comment = null;

        /// <summary>
        /// Defines the ocode classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ocode")]
        internal static ClassificationTypeDefinition Gcode_ocode = null;



    }





}
