[<AutoOpen>]
module SetArithmetic.Tests.TestHelpers

open NUnit.Framework

let expectsToBe expected actual =
    Assert.AreEqual (expected, actual, sprintf "%A != %A" expected actual)

let expectsToBeTrue actual =
    Assert.IsTrue actual

let expectsToBeFalse actual =
    Assert.IsFalse actual