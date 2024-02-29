open System
let rec do_math_funcs() =
    let mutable bool = true;
    while (bool) do
        printfn "Numara giriniz ya da çıkış yapınız (*0*)"
        let item = Console.ReadLine()
        if item = "*0*" then
            bool <- false
        else 
            let rec factorial x =
                if x < 1 then 1
                else x * factorial (x-1)
            Printf.printfn "Faktöriyel: %d" (factorial (Int32.Parse(item)))
            let rec sqrt x =
                if x >= 1 then x * x
                else 1
            Printf.printfn "Karesi : %d" (sqrt (Int32.Parse(item)))
            match Int32.TryParse(item) with
            | (true, value) -> printfn ""
            | _ -> printfn ""
do_math_funcs();