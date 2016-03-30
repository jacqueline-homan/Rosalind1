open System
open System.IO



let countAnyLetter (inputFromFile:string) (letter:char) =
   inputFromFile
   |> Seq.filter (fun c -> c = letter)
   |> Seq.length
   
let program (dna:string) = 
   
   let As = countAnyLetter dna 'A'
   let Cs = countAnyLetter dna 'C'
   let Gs = countAnyLetter dna 'G'
   let Ts = countAnyLetter dna 'T'

   printfn "%i %i %i %i" As Cs Gs Ts

[<EntryPoint>]
let main argv = 
    printfn "Welcome to F# lessons!" 

    //let path = @"/home/jacque/Projects/F-sharp/Rosalind/Rosalind/rosalind_dna_3_output.txt"
    let path = @"/home/jacque/Downloads/rosalind_dna (4).txt"
 
    let inputFromFile = File.ReadAllText(path) 

    inputFromFile |> program

    0 // return an integer exit code

