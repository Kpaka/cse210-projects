using System;
using System.Collections.Generic;
using System.IO;

public class JournalEntry
{
    public DateTime Date {get; set; }
    public string Prompt {get; set; }
    public string Respond {get; set; }
}