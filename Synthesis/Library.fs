module Synthesis

let abelar num =
  num > 12 && num < 3097 && (num % 12 = 0)

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
    match rem <> 0 with
    | true -> countDigits (count+1) (rem/10)
    | _ -> max count 1
  countDigits 0 num

let minmax (a,b,c,d) =
  let rec helper (smallest, largest) alist =
    match alist with 
    | [] -> (smallest, largest)
    | head::tail -> helper ( (min smallest head), (max largest head) ) tail
  helper (a,a) ([a;b;c;d])

let isLeap year =
  match year<1582, year%4 = 0 && year%100 <> 0 with
  | true, _ -> failwith "Value of the Year is not allowed to be less than 1582"
  | _, false -> year%400 = 0
  | _, true -> true

let month num =
  let monthIndex = [ ("January", 31); ("February", 28); ("March", 31); ("April", 30); ("May", 31); ("June", 30);
    ("July", 31); ("August", 31); ("September", 30); ("October", 31); ("November", 30); ("December", 31) ]

  let rec getItemOnIndex index alist =
    match (index = num, alist) with
    | (true, head::_) -> head
    | (_, _::tail) -> getItemOnIndex (index+1) tail
    | (_, []) -> failwith "Value less than 1 or greater than 12 are not allowed"

  getItemOnIndex 1 monthIndex

let toBinary num =
  let rec helper binary decimal =
    match decimal with
    | 0 | 1 -> (string)decimal+binary
    | _ -> helper (((string)(decimal%2))+binary) (decimal/2)
  
  match num<0 with
  | true -> failwith "Negative valuea not allowed"
  | _ -> helper "" num

let bizFuzz num =
  let isDivisibleBy3 num = num%3=0
  let isDivisibleBy5 num = num%5=0
  let isDivisibleBy3And5 num = num%3=0 && num%5=0

  let rec countDivisible predicate count value = 
    match (predicate value), value>num with
    | _, true -> count
    | true, _ -> countDivisible predicate (count+1) (value+1)
    | _ -> countDivisible predicate count (value+1)

  (countDivisible isDivisibleBy3 0 3 , countDivisible isDivisibleBy5 0 3, countDivisible isDivisibleBy3And5 0 3)

let monthDay d y =
  let getMonth = fun monthIndex isLeapYear ->
    match monthIndex=2 with
    | false -> month monthIndex 
    | _ -> 
      match isLeapYear with 
      | true -> ("February", 29)
      | _ -> ("February", 28)

  let isLeapYear = isLeap y
  let rec helper monthIndex start =
    let (month, days) = getMonth monthIndex isLeapYear
    let daysCount = start+days
    match d>=1 && daysCount>= d with
    | false-> helper (monthIndex+1) (days+start)
    | true -> month

  helper 1 0
  
let sqrt n =
  let rec calculate guess i =
    match i with
    | 10 -> guess
    | _ -> 
      let g = (guess + n/guess) / 2.0
      calculate g (i+1)

  match n <= 0.0 with
  | true -> None
  | _ -> Some (calculate (n/2.0) 0)

let coord _ =
  //let coord (x1, y1) (x2, y2) : double =
  //let result = (x1-x2)**2.0 + (y1-y2)**2.0
  //match sqrt result with 
  //| Some v -> v
  //| None -> failwith ""
  failwith ""