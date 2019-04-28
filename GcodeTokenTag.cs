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
            _GcodeTypes["Gcode_A"] = GcodeTokenTypes.Gcode_A;
            _GcodeTypes["Gcode_B"] = GcodeTokenTypes.Gcode_B;
            _GcodeTypes["Gcode_C"] = GcodeTokenTypes.Gcode_C;
            _GcodeTypes["Gcode_D"] = GcodeTokenTypes.Gcode_D;
            _GcodeTypes["Gcode_E"] = GcodeTokenTypes.Gcode_E;
            _GcodeTypes["Gcode_F"] = GcodeTokenTypes.Gcode_F;
            _GcodeTypes["Gcode_G"] = GcodeTokenTypes.Gcode_G;
            _GcodeTypes["Gcode_H"] = GcodeTokenTypes.Gcode_H;
            _GcodeTypes["Gcode_I"] = GcodeTokenTypes.Gcode_I;
            _GcodeTypes["Gcode_J"] = GcodeTokenTypes.Gcode_J;
            _GcodeTypes["Gcode_K"] = GcodeTokenTypes.Gcode_K;
            _GcodeTypes["Gcode_L"] = GcodeTokenTypes.Gcode_L;
            _GcodeTypes["Gcode_M"] = GcodeTokenTypes.Gcode_M;
            _GcodeTypes["Gcode_N"] = GcodeTokenTypes.Gcode_N;
            _GcodeTypes["Gcode_O"] = GcodeTokenTypes.Gcode_O;
            _GcodeTypes["Gcode_P"] = GcodeTokenTypes.Gcode_P;
            _GcodeTypes["Gcode_Q"] = GcodeTokenTypes.Gcode_Q;
            _GcodeTypes["Gcode_R"] = GcodeTokenTypes.Gcode_R;
            _GcodeTypes["Gcode_S"] = GcodeTokenTypes.Gcode_S;
            _GcodeTypes["Gcode_T"] = GcodeTokenTypes.Gcode_T;
            _GcodeTypes["Gcode_U"] = GcodeTokenTypes.Gcode_U;
            _GcodeTypes["Gcode_V"] = GcodeTokenTypes.Gcode_V;
            _GcodeTypes["Gcode_W"] = GcodeTokenTypes.Gcode_W;
            _GcodeTypes["Gcode_X"] = GcodeTokenTypes.Gcode_X;
            _GcodeTypes["Gcode_Y"] = GcodeTokenTypes.Gcode_Y;
            _GcodeTypes["Gcode_Z"] = GcodeTokenTypes.Gcode_Z;

            _GcodeTypes["Gcode_minus"] = GcodeTokenTypes.Gcode_minus;

            _GcodeTypes["Gcode_0"] = GcodeTokenTypes.Gcode_0;
            _GcodeTypes["Gcode_1"] = GcodeTokenTypes.Gcode_1;
            _GcodeTypes["Gcode_2"] = GcodeTokenTypes.Gcode_2;
            _GcodeTypes["Gcode_3"] = GcodeTokenTypes.Gcode_3;
            _GcodeTypes["Gcode_4"] = GcodeTokenTypes.Gcode_4;
            _GcodeTypes["Gcode_5"] = GcodeTokenTypes.Gcode_5;
            _GcodeTypes["Gcode_6"] = GcodeTokenTypes.Gcode_6;
            _GcodeTypes["Gcode_7"] = GcodeTokenTypes.Gcode_7;
            _GcodeTypes["Gcode_8"] = GcodeTokenTypes.Gcode_8;
            _GcodeTypes["Gcode_9"] = GcodeTokenTypes.Gcode_9;

            _GcodeTypes["comment"] = GcodeTokenTypes.comment;

            _GcodeTypes["ocode"] = GcodeTokenTypes.ocode; // not to be confused with capital O

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
                string tokenLine = containingLine.GetText();

                // by the time we get here, we might have a tag with adjacent comments:
                //     G01(isthisacomment)X21
                GcodeHelper GcodeHelper = new GcodeHelper(tokenLine);
                foreach (GcodeHelper.GcodeItem Item in GcodeHelper.GcodeItems)
                {
                    var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Item.ItemText.Length));

                    // is this item a comment? If so, color as appropriate
                    if (Item.ItemType == GcodeTokenTypes.comment)
                    {
                        if (tokenSpan.IntersectsWith(curSpan))
                            yield return new TagSpan<GcodeTokenTag>(tokenSpan,
                                                                  new GcodeTokenTag(_GcodeTypes["comment"]));
                    }
                    else if (Item.ItemType == GcodeTokenTypes.ocode)
                    {
                        if (tokenSpan.IntersectsWith(curSpan))
                            yield return new TagSpan<GcodeTokenTag>(tokenSpan,
                                                                  new GcodeTokenTag(_GcodeTypes["ocode"]));
                    }
                    // otherwise check to see if it is a keyword
                    else
                    {
                        if (_GcodeTypes.ContainsKey(Item.ItemType.ToString()))
                        {
                            if (tokenSpan.IntersectsWith(curSpan))
                                yield return new TagSpan<GcodeTokenTag>(tokenSpan,
                                                                      new GcodeTokenTag(Item.ItemType));
                        }
                        else
                        {
                            // no tag colorization
                        }
                    }
                    curLoc += Item.ItemText.Length;

                }

            }

        }
    }
}
