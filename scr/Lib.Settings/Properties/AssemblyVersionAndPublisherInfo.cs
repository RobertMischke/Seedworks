using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.


[assembly: AssemblyCompany("Robert Mischke")]
[assembly: AssemblyProduct("Seedworks")]
[assembly: AssemblyCopyright("Copyright © Robert Mischke")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: InternalsVisibleTo("Seedworks.Tests")]


// Make it easy to distinguish Debug and Release (i.e. Retail) builds;
// for example, through the file properties window.
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyDescription("Flavor=Debug")] // a.k.a. "Comments"
#else
[assembly: AssemblyConfiguration("Retail")]
[assembly: AssemblyDescription("Flavor=Retail")] // a.k.a. "Comments"
#endif

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("0.8.2.*")]