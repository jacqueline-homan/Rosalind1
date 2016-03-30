type DNA =
    | A
    | C
    | G
    | T


let dnaString = ["A";"C";"A";"C";"G";"A";"G";"C";"A";"G";"T"]

let numbers = [1..2000]

let dnaTotals = List.fold(fun (a, c, g, t) char -> 
    match char with
    | "A" -> (a + 1, c, g, t)
    | "C" -> (a, c + 1, g, t)
    | "G" -> (a, c, g + 1, t)
    | "T" -> (a, c, g, t + 1)
    | _ -> (a, c, g, t)) (0, 0, 0, 0) dnaString

let sum = List.fold(fun state num -> state + num) 0 numbers


