module SetArithmetic.Tests.``Create a set``

open NUnit.Framework
open SetArithmetic.Lib

[<SetUp>]
let Setup () =
    ()

[<Test>]
let ``should create an empty set`` () =
    let set = Set (None)
    Assert.IsTrue(set.IsEmpty ())

[<Test>]
let ``should not be empty if containg strings`` () =
    let set = Set (Some ["Hello"; "World"])
    Assert.IsFalse(set.IsEmpty ())
