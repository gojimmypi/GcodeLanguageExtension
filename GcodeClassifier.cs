
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
            _GcodeTypes[GcodeTokenTypes.Gcode_A] = typeService.GetClassificationType("A");
            _GcodeTypes[GcodeTokenTypes.Gcode_B] = typeService.GetClassificationType("B");
            _GcodeTypes[GcodeTokenTypes.Gcode_C] = typeService.GetClassificationType("C");
            _GcodeTypes[GcodeTokenTypes.Gcode_D] = typeService.GetClassificationType("D");
            _GcodeTypes[GcodeTokenTypes.Gcode_E] = typeService.GetClassificationType("E");
            _GcodeTypes[GcodeTokenTypes.Gcode_F] = typeService.GetClassificationType("F");
            _GcodeTypes[GcodeTokenTypes.Gcode_G] = typeService.GetClassificationType("G");
            _GcodeTypes[GcodeTokenTypes.Gcode_H] = typeService.GetClassificationType("H");
            _GcodeTypes[GcodeTokenTypes.Gcode_I] = typeService.GetClassificationType("I");
            _GcodeTypes[GcodeTokenTypes.Gcode_J] = typeService.GetClassificationType("J");
            _GcodeTypes[GcodeTokenTypes.Gcode_K] = typeService.GetClassificationType("K");
            _GcodeTypes[GcodeTokenTypes.Gcode_L] = typeService.GetClassificationType("L");
            _GcodeTypes[GcodeTokenTypes.Gcode_M] = typeService.GetClassificationType("M");
            _GcodeTypes[GcodeTokenTypes.Gcode_N] = typeService.GetClassificationType("N");
            _GcodeTypes[GcodeTokenTypes.Gcode_O] = typeService.GetClassificationType("O");
            _GcodeTypes[GcodeTokenTypes.Gcode_P] = typeService.GetClassificationType("P");
            _GcodeTypes[GcodeTokenTypes.Gcode_Q] = typeService.GetClassificationType("Q");
            _GcodeTypes[GcodeTokenTypes.Gcode_R] = typeService.GetClassificationType("R");
            _GcodeTypes[GcodeTokenTypes.Gcode_S] = typeService.GetClassificationType("S");
            _GcodeTypes[GcodeTokenTypes.Gcode_T] = typeService.GetClassificationType("T");
            _GcodeTypes[GcodeTokenTypes.Gcode_U] = typeService.GetClassificationType("U");
            _GcodeTypes[GcodeTokenTypes.Gcode_V] = typeService.GetClassificationType("V");
            _GcodeTypes[GcodeTokenTypes.Gcode_W] = typeService.GetClassificationType("W");
            _GcodeTypes[GcodeTokenTypes.Gcode_X] = typeService.GetClassificationType("X");
            _GcodeTypes[GcodeTokenTypes.Gcode_Y] = typeService.GetClassificationType("Y");
            _GcodeTypes[GcodeTokenTypes.Gcode_Z] = typeService.GetClassificationType("Z");

            _GcodeTypes[GcodeTokenTypes.Gcode_minus] = typeService.GetClassificationType("minus");
            _GcodeTypes[GcodeTokenTypes.Gcode_0] = typeService.GetClassificationType("0");
            _GcodeTypes[GcodeTokenTypes.Gcode_1] = typeService.GetClassificationType("1");
            _GcodeTypes[GcodeTokenTypes.Gcode_2] = typeService.GetClassificationType("2");
            _GcodeTypes[GcodeTokenTypes.Gcode_3] = typeService.GetClassificationType("3");
            _GcodeTypes[GcodeTokenTypes.Gcode_4] = typeService.GetClassificationType("4");
            _GcodeTypes[GcodeTokenTypes.Gcode_5] = typeService.GetClassificationType("5");
            _GcodeTypes[GcodeTokenTypes.Gcode_6] = typeService.GetClassificationType("6");
            _GcodeTypes[GcodeTokenTypes.Gcode_7] = typeService.GetClassificationType("7");
            _GcodeTypes[GcodeTokenTypes.Gcode_8] = typeService.GetClassificationType("8");
            _GcodeTypes[GcodeTokenTypes.Gcode_9] = typeService.GetClassificationType("9");

            _GcodeTypes[GcodeTokenTypes.Comment] = typeService.GetClassificationType("Comment");
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
                // each of the text values found for tagSpan.Tag.type must be defined above in GcodeClassifier
                yield return
                    new TagSpan<ClassificationTag>(tagSpans[0],
                                                   new ClassificationTag(_GcodeTypes[tagSpan.Tag.type]));
            }
        }
    }


}
