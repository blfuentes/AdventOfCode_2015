module day01_part01

open Utilities

let path = "day01/day01_input.txt"

let execute = 
    let inputline = GetLinesFromFile(path) |> Seq.head |> Seq.toArray
    let elements2 = (inputline |> Array.filter (fun x -> x = '(') |> Array.length , inputline |> Array.filter (fun x -> x = ')') |> Array.length)
    fst elements2 - snd elements2

