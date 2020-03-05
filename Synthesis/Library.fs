module Synthesis

let abelar num =
  let isWithInRange = num > 12 && num < 3097
  let isDivisibleBy12 = (num % 12 = 0)
  isWithInRange && isDivisibleBy12

let area baseLength height =
  match baseLength>=0.0 && height>=0.0 with
  | true -> 0.5*baseLength*height
  | _ -> failwith "Negative values not allowed"

let zollo num =
  match num>=0 with
  | true -> num*2
  | false -> -1*num

let min a b =
  match a>b with
  | true -> b
  | _ -> a

let max a b =
  match a<b with
  | true -> b
  | _ -> a

let ofTime hours minutes seconds =
  hours*60*60 + minutes*60 + seconds

let toTime totalTime =
  match totalTime>=0 with
  | false -> (0,0,0)
  | _ ->
    let hours = totalTime / 3600
    let minutes = (totalTime - hours*3600) / 60
    let seconds = totalTime - (hours*3600 + minutes*60)
    (hours, minutes, seconds)
  
let digits num =
  let rec countDigits count rem =
    match rem <> 0, count with
    | true, _ -> countDigits (count+1) (rem/10)
    | _, 0 -> count+1
    | _ -> count
  countDigits 0 num

let minmax (a,b,c,d) =
  let rec helper (smallest, largest) alist =
    match alist with 
    | [] -> (smallest, largest)
    | head::tail -> helper ( (min smallest head), (max largest head) ) tail
  helper (a,a) ([a;b;c;d])

let isLeap year =
  match year<1582 with
  | true -> failwith "Value of the Year is not allowed to be less than 1582"
  | _ -> 
    match year%4 = 0 && year%400<>0 && year 

let month _ =
    failwith "Not implemented"

let toBinary _ =
    failwith "Not implemented"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"