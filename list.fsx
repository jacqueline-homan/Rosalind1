// intro to list and matching

let xs = [1;2;3;4;5] //list

let shorter = [1.. 2 .. 5] //range

let array = [|1;2;3;4;5|] //array

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

let numbers = [1;2;3;4;]
let sum = numbers |> List.fold(fun state num -> state + num) 0 numbers

