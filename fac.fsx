let rec fac acc n =
    match n with
    | 1 -> acc
    | _ -> fac (n * acc) (n-1)

for i in [1..10] do
    printfn "fac (%d) is: %d" i <| fac 1 i
