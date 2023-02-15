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

[<Test>]
let ``should be empty if passed an empty list`` () =
    let set = Set (Some [])
    Assert.IsTrue(set.IsEmpty ())

[<Test>]
let ``should contain value passed to it`` () =
    let set = Set (Some ["Hello"; "world"])
    Assert.IsTrue(set.contains "Hello")

[<Test>]
let ``should not contain a value that is not passed`` () =
    let set = Set (Some ["Hello"; "world"])
    Assert.IsFalse(set.contains "Bob")
