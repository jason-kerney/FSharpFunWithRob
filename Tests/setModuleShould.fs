module SetArithmetic.Tests.``Set Module Should``

open NUnit.Framework
open SetArithmetic.OurSet

[<Test>]
let ``start with an empty set`` () =
    initialSet
    |> isEmpty
    |> expectsToBeTrue

[<Test>]
let ``when a string is added it should not be empty`` () =
    initialSet
    |> add "Hello"
    |> isEmpty
    |> expectsToBeFalse

[<Test>]
let ``when the string "Hello" is added it should contain "Hello"`` () =
    initialSet
    |> add "Hello"
    |> contains "Hello"
    |> expectsToBeTrue

[<Test>]
let ``when the string "Bye" is added it should not contain "Hello"`` () =
    initialSet
    |> add "Bye"
    |> contains "Hello"
    |> expectsToBeFalse

[<Test>]
let ``when adding multiple stings should contain First string`` () =
    initialSet
    |> add "Hello"
    |> add "World"
    |> contains "Hello"
    |> expectsToBeTrue

[<Test>]
let ``when adding multiple stings should contain Second string`` () =
    initialSet
    |> add "Hello"
    |> add "World"
    |> contains "World"
    |> expectsToBeTrue

[<Test>]
let ``when unioning two sets the new set should contain all item from left`` () =
    let left =
        initialSet
        |> add "hello"
        |> add "world"

    let right =
        initialSet

    let result = 
        left
        |> union right

    result
    |> contains "world"
    |> expectsToBeTrue

    result
    |> contains "hello"
    |> expectsToBeTrue

[<Test>]
let ``when unioning two sets the new set should contain all item from right`` () =
    let right =
        initialSet
        |> add "hello"
        |> add "world"

    let left =
        initialSet

    let result = 
        left
        |> union right

    result
    |> contains "world"
    |> expectsToBeTrue

    result
    |> contains "hello"
    |> expectsToBeTrue

[<Test>]
let ``when using the intersection of two sets where one is empty returns an empty set`` () =
    let left =
        initialSet
        |> add "Hello"
        |> add "World"
        |> add "!"

    let right = initialSet

    let result = 
        left 
        |> intersection right

    result
    |> isEmpty
    |> expectsToBeTrue

[<Test>]
let ``when using intersection of two identical sets the result should be the same`` () =
    let left =
        initialSet
        |> add "Hello"
        |> add "World"
        |> add "!"

    let right = 
        initialSet
        |> add "Hello"
        |> add "World"
        |> add "!"

    let result = 
        left 
        |> intersection right

    result
    |> expectsToBe right

[<Test>]
let ``when using intersection of two sets result should only contain common elements`` () =
    let left = 
        initialSet
        |> add "Rob"
        |> add "Awesome"

    let right =
        initialSet
        |> add "Jason"
        |> add "Awesome"

    let result =
        left
        |> intersection right

    result
    |> contains "Awesome"
    |> expectsToBeTrue

    result
    |> contains "Rob"
    |> expectsToBeFalse

    result
    |> contains "Jason"
    |> expectsToBeFalse