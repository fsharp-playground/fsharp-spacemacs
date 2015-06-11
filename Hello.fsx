

open System

let bin (x:int) =
  let pad k (y:string) = y.PadLeft(k, '0')
  (x,2) |> Convert.ToString |> pad 32

let rs1 = 2 |> bin
let rs2 = 3 |> bin
