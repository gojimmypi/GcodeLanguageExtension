//***************************************************************************
// 
//  MIT License
//
//  Copyright(c) 2019 gojimmypi
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
//
//***************************************************************************

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
    using GcodeHelperNamespace;

    [Export(typeof(ITaggerProvider))]
    [ContentType("gcode")]
    [TagType(typeof(GcodeTokenTag))]
    internal sealed class GcodeTokenTagProvider : ITaggerProvider
    {

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {
            return new GcodeTokenTagger(buffer) as ITagger<T>;
        }
    }

    public class GcodeTokenTag : ITag
    {
        public GcodeTokenTypes type { get; private set; }

        public GcodeTokenTag(GcodeTokenTypes type)
        {
            this.type = type;
        }
    }

    internal sealed class GcodeTokenTagger : ITagger<GcodeTokenTag>
    {

        ITextBuffer _buffer;
        IDictionary<string, GcodeTokenTypes> _GcodeTypes;

        internal GcodeTokenTagger(ITextBuffer buffer)
        {
            _buffer = buffer;
            _GcodeTypes = new Dictionary<string, GcodeTokenTypes>();
            _GcodeTypes["A"] = GcodeTokenTypes.Gcode_A;
            _GcodeTypes["B"] = GcodeTokenTypes.Gcode_B;
            _GcodeTypes["C"] = GcodeTokenTypes.Gcode_C;
            _GcodeTypes["D"] = GcodeTokenTypes.Gcode_D;
            _GcodeTypes["E"] = GcodeTokenTypes.Gcode_E;
            _GcodeTypes["F"] = GcodeTokenTypes.Gcode_F;
            _GcodeTypes["G"] = GcodeTokenTypes.Gcode_G;
            _GcodeTypes["H"] = GcodeTokenTypes.Gcode_H;
            _GcodeTypes["I"] = GcodeTokenTypes.Gcode_I;
            _GcodeTypes["J"] = GcodeTokenTypes.Gcode_J;
            _GcodeTypes["K"] = GcodeTokenTypes.Gcode_K;
            _GcodeTypes["L"] = GcodeTokenTypes.Gcode_L;
            _GcodeTypes["M"] = GcodeTokenTypes.Gcode_M;
            _GcodeTypes["N"] = GcodeTokenTypes.Gcode_N;
            _GcodeTypes["O"] = GcodeTokenTypes.Gcode_O;
            _GcodeTypes["P"] = GcodeTokenTypes.Gcode_P;
            _GcodeTypes["Q"] = GcodeTokenTypes.Gcode_Q;
            _GcodeTypes["R"] = GcodeTokenTypes.Gcode_R;
            _GcodeTypes["S"] = GcodeTokenTypes.Gcode_S;
            _GcodeTypes["T"] = GcodeTokenTypes.Gcode_T;
            _GcodeTypes["U"] = GcodeTokenTypes.Gcode_U;
            _GcodeTypes["V"] = GcodeTokenTypes.Gcode_V;
            _GcodeTypes["W"] = GcodeTokenTypes.Gcode_W;
            _GcodeTypes["X"] = GcodeTokenTypes.Gcode_X;
            _GcodeTypes["Y"] = GcodeTokenTypes.Gcode_Y;
            _GcodeTypes["Z"] = GcodeTokenTypes.Gcode_Z;

            _GcodeTypes["minus"] = GcodeTokenTypes.Gcode_minus;
            _GcodeTypes["0"] = GcodeTokenTypes.Gcode_0;
            _GcodeTypes["1"] = GcodeTokenTypes.Gcode_1;
            _GcodeTypes["2"] = GcodeTokenTypes.Gcode_2;
            _GcodeTypes["3"] = GcodeTokenTypes.Gcode_3;
            _GcodeTypes["4"] = GcodeTokenTypes.Gcode_4;
            _GcodeTypes["5"] = GcodeTokenTypes.Gcode_5;
            _GcodeTypes["6"] = GcodeTokenTypes.Gcode_6;
            _GcodeTypes["7"] = GcodeTokenTypes.Gcode_7;
            _GcodeTypes["8"] = GcodeTokenTypes.Gcode_8;
            _GcodeTypes["9"] = GcodeTokenTypes.Gcode_9;
            _GcodeTypes["10"] = GcodeTokenTypes.Gcode_10;


            _GcodeTypes[";"] = GcodeTokenTypes.Comment;

        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }



        public IEnumerable<ITagSpan<GcodeTokenTag>> GetTags(NormalizedSnapshotSpanCollection spans)
        {

            foreach (SnapshotSpan curSpan in spans)
            {
                ITextSnapshotLine containingLine = curSpan.Start.GetContainingLine();
                int curLoc = containingLine.Start.Position;
                string[] tokens = containingLine.GetText().Split(separator: new char[] { ' ', '\t', '[', ';' },
                                                                 options: StringSplitOptions.None);

                Boolean IsContinuedLineComment = false; // comments with ";" are only effective forthe current line
                foreach (string GcodeToken in tokens) // this group of tokens in in a single line
                {
                    // by the time we get here, we might have a tag with adjacent comments:
                    //     G01(isthisacomment)X21
                    GcodeHelper GcodeHelper = new GcodeHelper(GcodeToken);
                    foreach (GcodeHelper.GcodeItem Item in GcodeHelper.GcodeItems)
                    {
                        var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Item.ItemText.Length));

                        // is this item a comment? If so, color as appropriate
                        if (Item.IsComment)
                        {
                            if (tokenSpan.IntersectsWith(curSpan))
                                yield return new TagSpan<GcodeTokenTag>(tokenSpan,
                                                                      new GcodeTokenTag(_GcodeTypes[";"]));
                        }

                        // otherwise check to see if it is a keyword
                        else
                        {
                            if (_GcodeTypes.ContainsKey(Item.ItemText))
                            {
                                if (tokenSpan.IntersectsWith(curSpan))
                                    yield return new TagSpan<GcodeTokenTag>(tokenSpan,
                                                                          new GcodeTokenTag(_GcodeTypes[Item.ItemText]));
                            }
                            else
                            {
                                // no tag colorization
                            }
                        }
                        curLoc += Item.ItemText.Length;

                    }

                    //add an extra char location because of the tag delimiters:  ' ', '\t', '[', ';'
                    curLoc += +1;
                }
            }

        }
    }
}
