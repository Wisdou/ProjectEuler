// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let rec getDigitSum (numb: bigint) =
    if (numb = 0I) then
        0I
    else
        (numb % 10I) + (getDigitSum (numb / 10I))

let getFactorial (numb: int) =
    [1..numb] |> List.map bigint |> List.reduce (fun acc x -> acc * x)

let getResult = getFactorial >> getDigitSum

[<EntryPoint>]
let main argv =
    printfn "%A" (getResult 100)
    0 // return an integer exit code