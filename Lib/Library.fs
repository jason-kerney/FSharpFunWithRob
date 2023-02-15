namespace SetArithmetic.Lib

type Set (values: (_ list) option) =
    member _.IsEmpty () = 
        match values with
        | None
        | Some [] -> true
        | _ -> false

    member _.contains candidate = 
        match values with
        | None
        | Some [] -> false
        | Some values ->
            values
            |> List.contains candidate