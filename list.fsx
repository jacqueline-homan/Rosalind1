// intro to list and matching

let xs = [1;2;3;4;5]

let shorter = [1.. 2 .. 5]

let array = [|1;2;3;4;5|]

let sequence = seq { for i in 1 ..5 -> i }

// a list is a linked list
// that is, it is something, which may have a list behind it, or nothing

let head::tail = xs

let first::second::rest = xs

// this is bad, because empty has no head
let bad::worse = []

let safeMatch (xs:int list) =
    match xs with
    | [] -> printfn "EMPTY"
    | head::tail ->
         printfn "HEAD IS %i" head

