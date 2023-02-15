module SetArithmetic.Tests.``Create a set``

open NUnit.Framework
open SetArithmetic.Lib

[<SetUp>]
let Setup () =
    ()

[<Test>]
let ``should create an empty set`` () =
    let set = Set ()
    Assert.IsTrue(set.IsEmpty ())
