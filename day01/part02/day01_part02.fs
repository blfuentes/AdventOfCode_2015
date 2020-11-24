module day01_part02

open Utilities

let path = "day01/day01_input.txt"
let inputline = GetLinesFromFile(path) |> Seq.head |> Seq.toArray
let numOfMovs = inputline |> Seq.length

let calculateFloor (checkFloor:int) = 
    let elements2 = (inputline |> Seq.take(checkFloor) |> Seq.filter (fun x -> x = '(') |> Seq.length , inputline |> Seq.take(checkFloor) |> Seq.filter (fun x -> x = ')') |> Seq.length)
    fst elements2 - snd elements2

let execute =
    1 + ([0..numOfMovs] |> List.takeWhile(fun x -> (calculateFloor x) >= 0) |> List.rev |> List.head)
