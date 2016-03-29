// take and read the elements that are 'members' of a string
// that is a sequence, and then count the occurrence of each elemnt
// in the sequence, and then print out the results

// a string is a seq of char = character
"HELLO" |> Seq.iter (fun c -> printf "%c" c)

// countBy? Why not?

let countAs (input:string) =
    input
    |> Seq.filter (fun c -> c = 'A')
    |> Seq.length

let countCs (input:string) =
    input
    |> Seq.filter (fun c -> c = 'C')
    |> Seq.length

let countGs (input:string) =
    input
    |> Seq.filter (fun c -> c = 'G')
    |> Seq.length

let countTs (input:string) =
    input
    |> Seq.filter (fun c -> c = 'T')
    |> Seq.length

let countAnyLetter (input:string) (letter:char) =
    input
    |> Seq.filter (fun c -> c = letter)
    |> Seq.length




let letter = 'A'
let input = "ABCDEFG"
countAnyLetter input letter


let countChar (input:string) (target:char) =
    input
    |> Seq.filter (fun c -> c = target)
    |> Seq.length


let programFirstPass (dna:string) = 
    // this is a lot of repetition!
    // let's see if we can refactor to 1 function
    let As = countAs dna
    let Cs = countCs dna
    let Gs = countGs dna
    let Ts = countTs dna
    sprintf "%i %i %i %i" As Cs Gs Ts

let programSecondPass (dna:string) = 

    // better but we still have repetition.
    // now we wrote 4 times the same thing.
    // this smells like a map!
    let As = countAnyLetter dna 'A'
    let Cs = countAnyLetter dna 'C'
    let Gs = countAnyLetter dna 'G'
    let Ts = countAnyLetter dna 'T'
    sprintf "%i %i %i %i" As Cs Gs Ts

// instead of 4 calls, we can do one call
// to countChar, but use a map to apply it
// to whatever characters we want
['A';'C';'G';'T'] 
|> List.map (fun target -> countChar "AACCCGT" target)

let program (dna:string) = 
    // we move the chars into a list, and
    // apply a map.
    let As::Cs::Gs::Ts::_ = 
        ['A';'C';'G';'T'] 
        |> List.map (fun target -> countChar dna target)

    sprintf "%i %i %i %i" As Cs Gs Ts


let input = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC"

let output = "20 12 17 21"

let test = program input

//program input = 

let path = @"/home/jacque/Projects/F-sharp/Rosalind/Rosalind/rosalind_dna.txt"

let inputFromFile = System.IO.File.ReadAllText(path)

program inputFromFile 