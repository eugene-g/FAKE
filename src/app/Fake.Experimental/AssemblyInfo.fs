﻿namespace System
open System.Reflection
open System.Runtime.InteropServices

[<assembly: AssemblyTitleAttribute("FAKE - F# Make Experimental Lib")>]
[<assembly: GuidAttribute("5AA28AED-B9D8-4158-A594-32FE5ABC5713")>]
[<assembly: AssemblyProductAttribute("FAKE - F# Make")>]
[<assembly: AssemblyVersionAttribute("3.17.8")>]
[<assembly: AssemblyInformationalVersionAttribute("3.17.8")>]
[<assembly: AssemblyFileVersionAttribute("3.17.8")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "3.17.8"
