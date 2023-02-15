namespace SetArithmetic.Lib

type Set (values: (string list) option) =
    member _.IsEmpty () = 
        match values with
        | None
        | Some [] -> true
        | _ -> false
