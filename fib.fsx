let rec fib n = 
    match n with
        | 0 -> 0
        | 1 -> 1
        | _ -> fib (n-1) + fib(n-2)

for i in [1..10] do
    printfn "Fib(%d) is: %d" i <| fib i
