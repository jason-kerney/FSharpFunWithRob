namespace SetArithmetic.Lib

type Set (values: (_ list) option) =
    member _.IsEmpty () = 
        match values with
        | None
        | Some [] -> true
        | _ -> false

    member _.contains _ = true