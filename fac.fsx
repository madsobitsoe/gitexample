let rec fac n =
    match n with
    | 1 -> 1
    | _ -> n * fac (n-1)

for i in [1..10] do
    printfn "fac (%d) is: %d" i <| fac i
