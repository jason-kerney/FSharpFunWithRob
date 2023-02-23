module SetArithmetic.OurSet

let initialSet = []

let isEmpty set = 
    set
    |> List.isEmpty

let add (element: string) set = 
    element::set

let contains candidate set = 
    set
    |> List.contains candidate

let union right left =
    left
    |> List.append right

let intersection right left = 
    left
    |> List.filter(fun element -> 
        right
        |> List.contains element
    )