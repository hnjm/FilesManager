﻿namespace filesmanager;

public class FileData
{
    public string? FileSource { get; set;}
    public string? FolderSource { get; set;}
    public string? FileDestination { get; set; }
    public string? FolderDestination { get; set; }
    public string? LogFileSource { get; set; }
    public string? LogFolderSource { get; set; }
    public string? LogFileDestination { get; set; }
    public string? LogFolderDestination { get; set; }
    public Combined? Combined { get; set; }
    public string[]? FolderCombinedSource {get; set;}
}

public record Combined{
    public string? Name { get; set;}
}