using NUnit.Framework;
using Prove.Attributes;
using Prove.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[SetUpFixture]
public class AssemblyLevelSetup
{
    [OneTimeSetUp]
    public void Init()
    {
        Initialised = true;
    }

    public static bool Initialised { get; protected set; }
}