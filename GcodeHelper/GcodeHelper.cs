using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcodeHelperNamespace
{
    public class GcodeHelper
    {
        readonly string thisLine = "";

        public List<GcodeItem> GcodeItems { get; }

        public class GcodeItem
        {
            public string ItemText { get; }
            public GcodeTokenTypes ItemType { get; }

            public bool IsComment;

            public GcodeItem(string itemtext, GcodeTokenTypes itemtype)
            {
                this.ItemText = itemtext;
                this.ItemType = itemtype;
                IsComment = false;
            }

        } //  public class GcodeItem

        // init our GcodeHelper
        public GcodeHelper(string item)
        {
            // item should be a single line of text, with no CR/LF
            thisLine = item;
            GcodeItems = new List<GcodeItem>();

            for (int i = 0; i <= this.thisLine.Length - 1; i++)
            {
            
                string thisChar = thisLine.Substring(i, 1);

                // if a semicolon is encountered, the rest of the line is a comment
                if (thisChar == ";")
                {
                    GcodeItems.Add(new GcodeItem(thisLine.Substring(i), GcodeTokenTypes.Comment));
                }
                string thisTargetTypeName;
                switch (thisChar )
                {
                    case "-":
                        thisTargetTypeName = "minus";
                        break;
                    default:
                        thisTargetTypeName = thisChar;
                        break;
                }


                // Get an enum item by string name (e.g. Gcode_A, Gcode_B, etc)
                GcodeTokenTypes thisTokenType = GcodeTokenTypes.Undefined;
                Enum.TryParse(thisTargetTypeName, out thisTokenType);
                GcodeItems.Add(new GcodeItem(thisChar, thisTokenType));
            }
        }
    }
}
