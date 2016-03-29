open System
open System.IO

let countChar (input:string) (target:char) =
    input
    |> Seq.filter (fun c -> c = target)
    |> Seq.length

let program (dna:string) = 
    let As::Cs::Gs::Ts::_ = 
        ['A';'C';'G';'T'] 
        |> List.map (fun target -> countChar dna target)

    sprintf "%i %i %i %i" As Cs Gs Ts

[<EntryPoint>]
let main argv = 
    printfn "Welcome to F# lessons!" 

    printfn "PLEASE GIVE ME PATH TO THE FILE"

    //let path = Console.ReadLine()
    let path = @"/home/jacque/Projects/F-sharp/Rosalind/Rosalind/rosalind_dna.txt"

    let inputFromFile = System.IO.File.ReadAllText(path)

    let output = program inputFromFile

    printfn "%s" output

    let wait = Console.ReadLine ()
    0 // return an integer exit code

