module SetArithmetic.Tests.``Create a set``

open NUnit.Framework
open SetArithmetic.Lib

let baseSet = Set (Some ["Hello"; "world"])

[<SetUp>]
let Setup () =
    ()

[<Test>]
let ``should create an empty set`` () =
    let set = Set (None)
    Assert.IsTrue(set.IsEmpty ())

[<Test>]
let ``should not be empty if containg strings`` () =
    Assert.IsFalse(baseSet.IsEmpty ())

[<Test>]
let ``should be empty if passed an empty list`` () =
    let set = Set (Some [])
    Assert.IsTrue(set.IsEmpty ())

[<Test>]
let ``should contain value passed to it`` () =
    Assert.IsTrue(baseSet.contains "Hello")

[<Test>]
let ``should not contain a value that is not passed`` () =
    Assert.IsFalse(baseSet.contains "Bob")

[<Test>]
let ``should throw exception if given null in set`` () =
    try
        Set (Some ["Hello"; null; "world"]) |> ignore
        Assert.Fail "Should not get here if you throw exceptions"
    with _ ->
        ()
    

