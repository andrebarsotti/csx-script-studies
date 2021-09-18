#!/usr/bin/env dotnet-script
using System.Runtime.CompilerServices;

public static string GetScriptPath([CallerFilePath] string path = null) => path;
public static string GetScriptFolder([CallerFilePath] string path = null) => Path.GetDirectoryName(path);


Console.WriteLine($"{nameof(GetScriptPath)} => {GetScriptPath()}");
Console.WriteLine($"{nameof(GetScriptFolder)} => {GetScriptFolder()}");
