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
        [Name("CTD_GcodeClassifier")]
        private static ClassificationTypeDefinition typeDefinition;

#pragma warning restore 169


        /// <summary>
        /// Defines the Gcode_A classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_A")]
        internal static ClassificationTypeDefinition Gcode_A = null;


        /// <summary>
        /// Defines the Gcode_B classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_B")]
        internal static ClassificationTypeDefinition Gcode_B = null;


        /// <summary>
        /// Defines the Gcode_C classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_C")]
        internal static ClassificationTypeDefinition Gcode_C = null;


        /// <summary>
        /// Defines the Gcode_D classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_D")]
        internal static ClassificationTypeDefinition Gcode_D = null;


        /// <summary>
        /// Defines the Gcode_E classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_E")]
        internal static ClassificationTypeDefinition Gcode_E = null;


        /// <summary>
        /// Defines the Gcode_F classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_F")]
        internal static ClassificationTypeDefinition Gcode_F = null;


        /// <summary>
        /// Defines the Gcode_G classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_G")]
        internal static ClassificationTypeDefinition Gcode_G = null;


        /// <summary>
        /// Defines the Gcode_H classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_H")]
        internal static ClassificationTypeDefinition Gcode_H = null;


        /// <summary>
        /// Defines the Gcode_I classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_I")]
        internal static ClassificationTypeDefinition Gcode_I = null;


        /// <summary>
        /// Defines the Gcode_J classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_J")]
        internal static ClassificationTypeDefinition Gcode_J = null;


        /// <summary>
        /// Defines the Gcode_K classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_K")]
        internal static ClassificationTypeDefinition Gcode_K = null;


        /// <summary>
        /// Defines the Gcode_L classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_L")]
        internal static ClassificationTypeDefinition Gcode_L = null;


        /// <summary>
        /// Defines the Gcode_M classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_M")]
        internal static ClassificationTypeDefinition Gcode_M = null;


        /// <summary>
        /// Defines the Gcode_N classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_N")]
        internal static ClassificationTypeDefinition Gcode_N = null;


        /// <summary>
        /// Defines the Gcode_O classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_O")]
        internal static ClassificationTypeDefinition Gcode_O = null;


        /// <summary>
        /// Defines the Gcode_P classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_P")]
        internal static ClassificationTypeDefinition Gcode_P = null;


        /// <summary>
        /// Defines the Gcode_Q classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_Q")]
        internal static ClassificationTypeDefinition Gcode_Q = null;


        /// <summary>
        /// Defines the Gcode_R classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_R")]
        internal static ClassificationTypeDefinition Gcode_R = null;


        /// <summary>
        /// Defines the Gcode_S classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_S")]
        internal static ClassificationTypeDefinition Gcode_S = null;


        /// <summary>
        /// Defines the Gcode_T classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_T")]
        internal static ClassificationTypeDefinition Gcode_T = null;


        /// <summary>
        /// Defines the Gcode_U classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_U")]
        internal static ClassificationTypeDefinition Gcode_U = null;


        /// <summary>
        /// Defines the Gcode_V classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_V")]
        internal static ClassificationTypeDefinition Gcode_V = null;


        /// <summary>
        /// Defines the Gcode_W classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_W")]
        internal static ClassificationTypeDefinition Gcode_W = null;


        /// <summary>
        /// Defines the Gcode_X classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_X")]
        internal static ClassificationTypeDefinition Gcode_X = null;


        /// <summary>
        /// Defines the Gcode_Y classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_Y")]
        internal static ClassificationTypeDefinition Gcode_Y = null;


        /// <summary>
        /// Defines the Gcode_Z classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_Z")]
        internal static ClassificationTypeDefinition Gcode_Z = null;


        /// <summary>
        /// Defines the Gcode_minus classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_minus")]
        internal static ClassificationTypeDefinition Gcode_minus = null;


        /// <summary>
        /// Defines the Gcode_0 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_0")]
        internal static ClassificationTypeDefinition Gcode_0 = null;


        /// <summary>
        /// Defines the Gcode_1 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_1")]
        internal static ClassificationTypeDefinition Gcode_1 = null;


        /// <summary>
        /// Defines the Gcode_2 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_2")]
        internal static ClassificationTypeDefinition Gcode_2 = null;


        /// <summary>
        /// Defines the Gcode_3 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_3")]
        internal static ClassificationTypeDefinition Gcode_3 = null;


        /// <summary>
        /// Defines the Gcode_4 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_4")]
        internal static ClassificationTypeDefinition Gcode_4 = null;


        /// <summary>
        /// Defines the Gcode_5 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_5")]
        internal static ClassificationTypeDefinition Gcode_5 = null;


        /// <summary>
        /// Defines the Gcode_6 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_6")]
        internal static ClassificationTypeDefinition Gcode_6 = null;


        /// <summary>
        /// Defines the Gcode_7 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_7")]
        internal static ClassificationTypeDefinition Gcode_7 = null;


        /// <summary>
        /// Defines the Gcode_8 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_8")]
        internal static ClassificationTypeDefinition Gcode_8 = null;


        /// <summary>
        /// Defines the Gcode_9 classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("CTD_Gcode_9")]
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

        /// <summary>
        /// Defines the numbers classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("numbers")]
        internal static ClassificationTypeDefinition Gcode_numbers = null;

    }





}
