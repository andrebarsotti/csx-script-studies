#!/usr/bin/env dotnet-script
#load "nuget: ScriptUnit, 0.2.0"
#r "nuget:FluentAssertions, 4.19.4"

using static ScriptUnit;   
using FluentAssertions;

return await AddTestsFrom<SampleTests>().Execute();

public class SampleTests
{    
    public void Success()
    {
        "Ok".Should().Be("Ok");
    }
  
  	public void Fail()
    {
        "Ok".Should().NotBe("Ok");
    }
}