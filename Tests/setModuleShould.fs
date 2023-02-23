module SetArithmetic.Tests.``Set Module Should``

open NUnit.Framework
open SetArithmetic.OurSet

[<Test>]
let ``start with an empty set`` () =
    initialSet
    |> isEmpty
    |> expectsToBeTrue