using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcodeLanguage
{
    public class GcodeHelper
    {
        public bool CaseSensitivity { get; set; }

        private readonly string thisLine = "";

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
            CaseSensitivity = false;
            // item should be a single line of text, with no CR/LF
            thisLine = item;
            GcodeItems = new List<GcodeItem>();
            bool FoundType = false;
            bool FoundNonBlank = false;
            bool CommentActive = false; // true when whe are in a parenthesis-delimmited comment "(like this)"
            GcodeTokenTypes thisBlockType = GcodeTokenTypes.Gcode_Undefined;
            string thisBlock = "";
            GcodeTokenTypes thisTokenType = GcodeTokenTypes.Gcode_Undefined;
            for (int i = 0; i < this.thisLine.Length; i++)
            {
                string priorChar = (i > 0)? thisLine.Substring(i - 1, 1) : "";
                string thisChar = thisLine.Substring(i, 1);
                string nextChar =(i < this.thisLine.Length - 1)? thisLine.Substring(i + 1, 1) : "";

                if (thisChar != " " && thisChar != "/t")
                {
                    FoundNonBlank = true;
                }
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
                    GcodeItems.Add(new GcodeItem(thisBlock, GcodeTokenTypes.Gcode_Comment));
                    thisBlock = "";
                    break;
                }

                // lowercase "o"s are considered an o-code block for the rest of the line
                if (thisChar == "o" && ((i == 0) || !FoundNonBlank)) 
                {
                    if (thisBlock != "")
                    {
                        // if we have a prior block of text with a different highlight type, add it to the list before moving on
                        GcodeItems.Add(new GcodeItem(thisBlock, thisBlockType));
                        thisBlock = "";
                    }
                    thisBlock = thisLine.Substring(i);
                    GcodeItems.Add(new GcodeItem(thisBlock, GcodeTokenTypes.Gcode_ocode)); // little o's are "o-codes"
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
                        GcodeItems.Add(new GcodeItem(thisBlock, GcodeTokenTypes.Gcode_Comment));
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
                        case ".":
                        case "0":
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
//                            thisTokenType = GcodeTokenTypes.numbers;
                            break;
                        case " ":
                            thisTokenType = GcodeTokenTypes.Gcode_Undefined;
                            break;
                        default:
                            // check to see if we are searching for a keyword type. Numbers and dashes are included.
                            if (!FoundType && 
                                (nextChar != "") &&  // apparently C# thinks an empty string is a number :/
                                (nextChar.All(char.IsNumber) || (nextChar == "-")))
                            {
                                thisTokenType = GcodeTokenTypes.Gcode_Undefined;
                                if (CaseSensitivity)
                                {
                                    thisTargetTypeName = "Gcode_" + thisChar;
                                }
                                else 
                                {
                                    thisTargetTypeName = "Gcode_" + thisChar.ToUpper();
                                }
                                Enum.TryParse(thisTargetTypeName, out thisTokenType);
                            }
                            break;
                    }
                    // Get an enum item by string name (e.g. Gcode_A, Gcode_B, etc)
                    if (thisTokenType != GcodeTokenTypes.Gcode_Undefined)
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
                        thisBlockType = GcodeTokenTypes.Gcode_Undefined;
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
