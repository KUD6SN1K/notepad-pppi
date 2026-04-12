// ============================================
// MODULE 2: Language Semantics - Syntax Highlighting
// Part of Group 2: Semantics, Search, History
// ============================================

// TODO: Color keywords (if, for, while, class, function)
// TODO: Color strings in quotes
// TODO: Color numbers
// TODO: Color operators (+, -, *, /, =, ==)
// TODO: Color comments

public class SyntaxHighlighter
{
    // Highlights current line
    public void HighlightCurrentLine(int lineNumber)
    {
        // Changes background of current line
    }

    // Highlights all keywords in document
    public void HighlightKeywords()
    {
        // Finds all keywords
        // Applies keyword color
    }

    // Highlights all strings
    public void HighlightStrings()
    {
        // Finds text between quotes
        // Applies string color
    }

    // Highlights all comments
    public void HighlightComments()
    {
        // Finds // and /* */ patterns
        // Applies comment color
    }

    // Re-highlights entire document
    public void RehighlightAll()
    {
        // Clears all colors
        // Applies all highlighting rules
    }
}
