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
let sum = List.fold(fun x num -> x + num) 0 numbers

let dna = ['G';'A';'T';'G';'G';'A';'A';'C';'T';'T';'G';'A';'C';'T';'A';'C';'G';'T';'A';'A';'A';'T';'T']
//1st Rosalind problem
type DNA =
    | A
    | C
    | G
    | T

let dnaString = ["A";"C";"A";"C";"G";"A";"G";"C";"A";"G";"T"]

let dnaSequence = Array.ofSeq(String.Join(String.Empty, file))
                                |> Array.map (fun x ->
                                    match x with
                                    | 'A' -> A
                                    | 'C' -> C
                                    | 'G' -> G
                                    | 'T' -> T) 
                                |> Array.groupBy

//2nd Rosalind problem
//let

(* 
type CharacterCounts = {
    Gs: int
    Cs: int
    As: int
    Ts: int
}


let countChar (input:string) (target:char) =
    input
    |> Seq.filter (fun c -> c = target)
    |> Seq.length  

let initialCounts = {
    Gs = 0
    Cs = 0
    As = 0
    Ts = 0
    }
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
        
*)

