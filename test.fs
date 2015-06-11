open System

let testBox x =
  match box x with
    | :? String -> "You are string"
    | :? int -> "You are integer"
    | _ -> "Who are you?"

let rs' = testBox 100
let rs'' = testBox "Hello"
let rs''' = testBox (DateTime(2015,10,10))

let double' = [1;2;3;4] |> List.map (fun x -> x + x)

