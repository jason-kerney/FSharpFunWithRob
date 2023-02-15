namespace SetArithmetic.Lib

type Set (values: (string list) option) =
    member _.IsEmpty () = values.IsNone
