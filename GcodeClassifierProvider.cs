
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
    //    /// <summary>
    //    /// Classifier provider. It adds the classifier to the set of classifiers.
    //    /// </summary>
    //    [Export(typeof(IClassifierProvider))]
    //    [ContentType("text")] // This classifier applies to all text files.
    //    internal class GcodeClassifierProvider : IClassifierProvider
    //    {
    //        // Disable "Field is never assigned to..." compiler's warning. Justification: the field is assigned by MEF.
    //#pragma warning disable 649

    //        /// <summary>
    //        /// Classification registry to be used for getting a reference
    //        /// to the custom classification type later.
    //        /// </summary>
    //        [Import]
    //        private IClassificationTypeRegistryService classificationRegistry;

    //#pragma warning restore 649

    //        #region IClassifierProvider

    //        /// <summary>
    //        /// Gets a classifier for the given text buffer.
    //        /// </summary>
    //        /// <param name="buffer">The <see cref="ITextBuffer"/> to classify.</param>
    //        /// <returns>A classifier for the text buffer, or null if the provider cannot do so in its current state.</returns>
    //        public IClassifier GetClassifier(ITextBuffer buffer)
    //        {
    //            return buffer.Properties.GetOrCreateSingletonProperty<GcodeClassifier>(creator: () => new GcodeClassifier(this.classificationRegistry));
    //        }

    //        #endregion
    //    }
    [Export(typeof(ITaggerProvider))]
    [ContentType("gcode")]
    [TagType(typeof(ClassificationTag))]
    internal sealed class GcodeClassifierProvider : ITaggerProvider
    {

        [Export(typeof(ContentTypeDefinition))]
        [Name("gcode")]
        [BaseDefinition("text")]
        internal static ContentTypeDefinition GcodeContentType = null;

        [Export(typeof(FileExtensionToContentTypeDefinition))]
        [FileExtension(".gcode")]
        [ContentType("gcode")]
        internal static FileExtensionToContentTypeDefinition GcodeFileType = null;

        [Export(typeof(FileExtensionToContentTypeDefinition))]
        [FileExtension(".mpf")]
        [ContentType("gcode")]
        internal static FileExtensionToContentTypeDefinition GcodeFileTypeMPF = null;

        [Export(typeof(FileExtensionToContentTypeDefinition))]
        [FileExtension(".mpt")]
        [ContentType("gcode")]
        internal static FileExtensionToContentTypeDefinition GcodeFileTypeMPT = null;

        [Export(typeof(FileExtensionToContentTypeDefinition))]
        [FileExtension(".nc")]
        [ContentType("gcode")]
        internal static FileExtensionToContentTypeDefinition GcodeFileTypeNC = null;

        [Import]
        internal IClassificationTypeRegistryService ClassificationTypeRegistry = null;

        [Import]
        internal IBufferTagAggregatorFactoryService aggregatorFactory = null;

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {

            ITagAggregator<GcodeTokenTag> GcodeTagAggregator =
                                            aggregatorFactory.CreateTagAggregator<GcodeTokenTag>(buffer);

            return new GcodeClassifier(buffer, GcodeTagAggregator, ClassificationTypeRegistry) as ITagger<T>;
        }
    }


}
