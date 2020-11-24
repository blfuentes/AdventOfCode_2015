module day01_part01

open Utilities

let path = "test_input_00.txt"

let execute =    
    let lines = GetLinesFromFile(path)
    let elements = lines |> Seq.head |> Seq.toList
    elements

