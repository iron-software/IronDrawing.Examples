using IronSoftware.Drawing;

// Create a new Font object
Font font = new Font("Times New Roman", FontStyle.Italic | FontStyle.Bold, 30);

// Cast between System.Drawing.Font and IronSoftware.Drawing.Font
System.Drawing.Font drawingFont = new System.Drawing.Font("Courier New", 30);
IronSoftware.Drawing.Font ironFont = drawingFont;

// Access Font Properties
var name = ironFont.FamilyName;
var style = ironFont.Style;
var size = ironFont.Size;
var isItalic = ironFont.Italic;
var isBold = ironFont.Bold;


