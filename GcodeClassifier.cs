
namespace GcodeLanguage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Text.Classification;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Text.Tagging;
    using Microsoft.VisualStudio.Utilities;
    /// <summary>
                                               /// Classifier that classifies all text as an instance of the "GcodeClassifier" classification type.
                                               /// </summary>
    //    internal class GcodeClassifier : IClassifier
    //    {
    //        /// <summary>
    //        /// Classification type.
    //        /// </summary>
    //        private readonly IClassificationType classificationType;

    //        /// <summary>
    //        /// Initializes a new instance of the <see cref="GcodeClassifier"/> class.
    //        /// </summary>
    //        /// <param name="registry">Classification registry.</param>
    //        internal GcodeClassifier(IClassificationTypeRegistryService registry)
    //        {
    //            this.classificationType = registry.GetClassificationType("GcodeClassifier");
    //        }

    //        #region IClassifier

    //#pragma warning disable 67

    //        /// <summary>
    //        /// An event that occurs when the classification of a span of text has changed.
    //        /// </summary>
    //        /// <remarks>
    //        /// This event gets raised if a non-text change would affect the classification in some way,
    //        /// for example typing /* would cause the classification to change in C# without directly
    //        /// affecting the span.
    //        /// </remarks>
    //        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;

    //#pragma warning restore 67

    //        /// <summary>
    //        /// Gets all the <see cref="ClassificationSpan"/> objects that intersect with the given range of text.
    //        /// </summary>
    //        /// <remarks>
    //        /// This method scans the given SnapshotSpan for potential matches for this classification.
    //        /// In this instance, it classifies everything and returns each span as a new ClassificationSpan.
    //        /// </remarks>
    //        /// <param name="span">The span currently being classified.</param>
    //        /// <returns>A list of ClassificationSpans that represent spans identified to be of this classification.</returns>
    //        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
    //        {
    //            var result = new List<ClassificationSpan>()
    //            {
    //                new ClassificationSpan(new SnapshotSpan(span.Snapshot, new Span(span.Start, span.Length)), this.classificationType)
    //            };

    //            return result;
    //        }

    //        #endregion
    //    }
    internal sealed class GcodeClassifier : ITagger<ClassificationTag>
    {
        ITextBuffer _buffer;
        ITagAggregator<GcodeTokenTag> _aggregator;
        IDictionary<GcodeTokenTypes, IClassificationType> _GcodeTypes;

        /// <summary>
        /// Construct the classifier and define search tokens
        /// </summary>
        internal GcodeClassifier(ITextBuffer buffer,
                               ITagAggregator<GcodeTokenTag> GcodeTagAggregator,
                               IClassificationTypeRegistryService typeService)
        {
            _buffer = buffer;
            _aggregator = GcodeTagAggregator;
            _GcodeTypes = new Dictionary<GcodeTokenTypes, IClassificationType>();

            _GcodeTypes[GcodeTokenTypes.Gcode_Undefined] = typeService.GetClassificationType("Gcode_Undefined");

            _GcodeTypes[GcodeTokenTypes.Gcode_A] = typeService.GetClassificationType("Gcode_A");
            _GcodeTypes[GcodeTokenTypes.Gcode_B] = typeService.GetClassificationType("Gcode_B");
            _GcodeTypes[GcodeTokenTypes.Gcode_C] = typeService.GetClassificationType("Gcode_C");
            _GcodeTypes[GcodeTokenTypes.Gcode_D] = typeService.GetClassificationType("Gcode_D");
            _GcodeTypes[GcodeTokenTypes.Gcode_E] = typeService.GetClassificationType("Gcode_E");
            _GcodeTypes[GcodeTokenTypes.Gcode_F] = typeService.GetClassificationType("Gcode_F");
            _GcodeTypes[GcodeTokenTypes.Gcode_G] = typeService.GetClassificationType("Gcode_G");
            _GcodeTypes[GcodeTokenTypes.Gcode_H] = typeService.GetClassificationType("Gcode_H");
            _GcodeTypes[GcodeTokenTypes.Gcode_I] = typeService.GetClassificationType("Gcode_I");
            _GcodeTypes[GcodeTokenTypes.Gcode_J] = typeService.GetClassificationType("Gcode_J");
            _GcodeTypes[GcodeTokenTypes.Gcode_K] = typeService.GetClassificationType("Gcode_K");
            _GcodeTypes[GcodeTokenTypes.Gcode_L] = typeService.GetClassificationType("Gcode_L");
            _GcodeTypes[GcodeTokenTypes.Gcode_M] = typeService.GetClassificationType("Gcode_M");
            _GcodeTypes[GcodeTokenTypes.Gcode_N] = typeService.GetClassificationType("Gcode_N");
            _GcodeTypes[GcodeTokenTypes.Gcode_O] = typeService.GetClassificationType("Gcode_O");
            _GcodeTypes[GcodeTokenTypes.Gcode_P] = typeService.GetClassificationType("Gcode_P");
            _GcodeTypes[GcodeTokenTypes.Gcode_Q] = typeService.GetClassificationType("Gcode_Q");
            _GcodeTypes[GcodeTokenTypes.Gcode_R] = typeService.GetClassificationType("Gcode_R");
            _GcodeTypes[GcodeTokenTypes.Gcode_S] = typeService.GetClassificationType("Gcode_S");
            _GcodeTypes[GcodeTokenTypes.Gcode_T] = typeService.GetClassificationType("Gcode_T");
            _GcodeTypes[GcodeTokenTypes.Gcode_U] = typeService.GetClassificationType("Gcode_U");
            _GcodeTypes[GcodeTokenTypes.Gcode_V] = typeService.GetClassificationType("Gcode_V");
            _GcodeTypes[GcodeTokenTypes.Gcode_W] = typeService.GetClassificationType("Gcode_W");
            _GcodeTypes[GcodeTokenTypes.Gcode_X] = typeService.GetClassificationType("Gcode_X");
            _GcodeTypes[GcodeTokenTypes.Gcode_Y] = typeService.GetClassificationType("Gcode_Y");
            _GcodeTypes[GcodeTokenTypes.Gcode_Z] = typeService.GetClassificationType("Gcode_Z");

            _GcodeTypes[GcodeTokenTypes.Gcode_minus] = typeService.GetClassificationType("Gcode_minus");
            _GcodeTypes[GcodeTokenTypes.Gcode_0] = typeService.GetClassificationType("Gcode_0");
            _GcodeTypes[GcodeTokenTypes.Gcode_1] = typeService.GetClassificationType("Gcode_1");
            _GcodeTypes[GcodeTokenTypes.Gcode_2] = typeService.GetClassificationType("Gcode_2");
            _GcodeTypes[GcodeTokenTypes.Gcode_3] = typeService.GetClassificationType("Gcode_3");
            _GcodeTypes[GcodeTokenTypes.Gcode_4] = typeService.GetClassificationType("Gcode_4");
            _GcodeTypes[GcodeTokenTypes.Gcode_5] = typeService.GetClassificationType("Gcode_5");
            _GcodeTypes[GcodeTokenTypes.Gcode_6] = typeService.GetClassificationType("Gcode_6");
            _GcodeTypes[GcodeTokenTypes.Gcode_7] = typeService.GetClassificationType("Gcode_7");
            _GcodeTypes[GcodeTokenTypes.Gcode_8] = typeService.GetClassificationType("Gcode_8");
            _GcodeTypes[GcodeTokenTypes.Gcode_9] = typeService.GetClassificationType("Gcode_9");

            _GcodeTypes[GcodeTokenTypes.Gcode_Comment] = typeService.GetClassificationType("Gcode_Comment");
            
            _GcodeTypes[GcodeTokenTypes.Gcode_ocode] = typeService.GetClassificationType("ocode");

            // if  typeService.GetClassificationType returns Null, check GcodeClassifierClassificationDefinition
            // o-codes

            // Operators (in order of precedence from highest to lowest)
            // ** 
            // * / MOD
            // + -
            // EQ NE GT GE LT LE
            // AND OR XOR

            // Functions
            // ATAN
            // ABS
            // ACOS
            // ASIN
            // COS
            // EXP
            // FIX
            // FUP
            // ROUND
            // LN
            // SIN
            // SQRT
            // TAN
            // EXISTS

            // keywords
            // if else endif sub endsub call 
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }

        /// <summary>
        /// Search the given span for any instances of classified tags
        /// </summary>
        public IEnumerable<ITagSpan<ClassificationTag>> GetTags(NormalizedSnapshotSpanCollection spans)
        {
            foreach (var tagSpan in _aggregator.GetTags(spans))
            {
                var tagSpans = tagSpan.Span.GetSpans(spans[0].Snapshot);
                // each of the text values found for tagSpan.Tag.type must be defined above in GcodeClassifieif r
                if (_GcodeTypes[tagSpan.Tag.type] != null)
                {
                    ClassificationTag thisClassificationTag = new ClassificationTag(_GcodeTypes[tagSpan.Tag.type]);
                    if (thisClassificationTag != null)
                    {
                        yield return
                            new TagSpan<ClassificationTag>(tagSpans[0], thisClassificationTag);
                    }
                    else
                    {
                        // TODO - how did we possibly end up here? it happens only in release mode??
                    }
                }
                else
                {
                    // TODO - how did we possibly end up here? it happens only in release mode??
                }
            }
        }
    }


}
