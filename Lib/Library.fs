namespace SetArithmetic.Lib

type Set (values: (_ list) option) =
    let memberValues =
        match values with
        | None -> []
        | Some realValues -> realValues


    member _.IsEmpty () = 
        memberValues
        |> List.isEmpty

    member _.contains candidate = 
        memberValues
        |> List.contains candidate