open System.IO

let path = "test_input_00.txt"
let lines = File.ReadLines(__SOURCE_DIRECTORY__ + @"../../" + path)

let elements = lines |> Seq.head |> Seq.toList
elements