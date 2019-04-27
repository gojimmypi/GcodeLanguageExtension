using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcodeLanguage
{
    public class GcodeHelper
    {
        readonly string thisLine = "";

        public List<GcodeItem> GcodeItems { get; }

        public class GcodeItem
        {
            public string ItemText { get; }
            public GcodeTokenTypes ItemType { get; }

            public GcodeItem(string itemtext, GcodeTokenTypes itemtype)
            {
                this.ItemText = itemtext;
                this.ItemType = itemtype;
            }

        } //  public class GcodeItem

        // init our GcodeHelper
        public GcodeHelper(string item)
        {
            // item should be a single line of text, with no CR/LF
            thisLine = item;
            GcodeItems = new List<GcodeItem>();
            bool FoundType = false;
            bool CommentActive = false; // true when whe are in a parenthesis-delimmited comment "(like this)"
            GcodeTokenTypes thisBlockType = GcodeTokenTypes.Undefined;
            string thisBlock = "";
            for (int i = 0; i <= this.thisLine.Length - 1; i++)
            {
            
                string thisChar = thisLine.Substring(i, 1);

                // if a semicolon is encountered, the rest of the line is a comment
                if (thisChar == ";")
                {
                    if (thisBlock != "")
                    {
                        // if we have a prior block of text with a different highlight type, add it to the list before moving on
                        GcodeItems.Add(new GcodeItem(thisBlock, thisBlockType));
                        thisBlock = "";
                    }
                    thisBlock = thisLine.Substring(i);
                    GcodeItems.Add(new GcodeItem(thisBlock, GcodeTokenTypes.Comment));
                    thisBlock = "";
                    break;
                }

                // 
                string thisTargetTypeName;
                if (thisChar == "(")
                {
                    if (thisBlock != "" && !CommentActive)
                    {
                        // if we have a prior block of text with a different highlight type, add it to the list before moving on
                        GcodeItems.Add(new GcodeItem(thisBlock, thisBlockType));
                        thisBlock = "";
                    }
                    CommentActive = true;
                    thisBlock += thisChar;
                }
                else if (thisChar == ")" && CommentActive)
                {
                    thisBlock += thisChar;
                    if (CommentActive)
                    {
                        GcodeItems.Add(new GcodeItem(thisBlock, GcodeTokenTypes.Comment));
                        thisBlock = "";
                    }
                    CommentActive = false;
                }
                else if (CommentActive)
                {
                    thisBlock += thisChar;
                }
                else
                {
                    switch (thisChar)
                    {
                        case "-":
                            thisTargetTypeName = "minus";
                            break;
                        default:
                            thisTargetTypeName = "Gcode_" + thisChar;
                            break;
                    }
                    // Get an enum item by string name (e.g. Gcode_A, Gcode_B, etc)
                    GcodeTokenTypes thisTokenType = GcodeTokenTypes.Undefined;
                    Enum.TryParse(thisTargetTypeName, out thisTokenType);
                    if (thisTokenType != GcodeTokenTypes.Undefined)
                    {
                        if (!FoundType)
                        {
                            if (thisBlock != "")
                            {
                                // if we have a prior block of text with a different highlight type, add it to the list before moving on
                                GcodeItems.Add(new GcodeItem(thisBlock, thisBlockType));
                                thisBlock = "";
                            }
                            thisBlockType = thisTokenType; // once a token is found, subsequence chars will share the type. (e.g. the g-code "G" token, followed by numbers)
                            FoundType = true;
                        }
                    }
                    else
                    {
                        if (thisBlock != "")
                        {
                            // if we have a prior block of text with a different highlight type, add it to the list before moving on
                            GcodeItems.Add(new GcodeItem(thisBlock, thisBlockType));
                            thisBlock = "";
                        }
                        thisBlockType = GcodeTokenTypes.Undefined;
                        FoundType = false;
                    }
                    thisBlock += thisChar;

                }

            }

            // if there's anthing left over, append it (e.g. a type that 
            if (thisBlock != "")
            {
                GcodeItems.Add(new GcodeItem(thisBlock, thisBlockType));
            }
        }
    }
}
