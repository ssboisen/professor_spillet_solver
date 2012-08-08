type BodyPart =
    | Top
    | Bottom

type Color =
    | Blue
    | Brown
    | Green
    | Purple

type ProfessorChecker = {
                Top: Color * BodyPart; 
                Right: Color * BodyPart; 
                Bottom: Color * BodyPart; 
                Left: Color * BodyPart; 
             } with           
            member a.RotateRight =
                { Top = a.Left; Right = a.Top; Bottom = a.Right; Left = a.Bottom; }

let SolveProfessorPuzzle (checkers : ProfessorChecker Set) =
    let findMatchingCheckers board index =
        let currentIndex = index + 1
        let unused = checkers |> Set.difference board
        let boardArray = board |> Array.ofSeq
        let getColor index f =
            (fst (boardArray.[index] |> f))
        let getBodyPart index f =
            (snd (boardArray.[index] |> f))
        let getCheckerVariations (u : ProfessorChecker) =
            seq {
                   yield u
                   yield u.RotateRight
                   yield u.RotateRight.RotateRight
                   yield u.RotateRight.RotateRight.RotateRight
                } 
        seq { 
            for u in unused do
                for c in getCheckerVariations u do
                    match c, currentIndex with
                        | { Left = (lColor, lBodyPart) }, idx when 
                                                                    idx >= 1 && idx <= 3 && 
                                                                    getColor index (fun c -> c.Right) = lColor && 
                                                                    getBodyPart index (fun c -> c.Right) <> lBodyPart -> 
                                                                    yield c

                        | { Top = (tColor,tBodyPart) }, idx when 
                                                                idx % 4 = 0 &&
                                                                getColor (idx - 4) (fun c -> c.Bottom) = tColor & 
                                                                getBodyPart (idx - 4) (fun c -> c.Bottom) <> tBodyPart -> 
                                                                yield c

                        | { Left = (lColor, lBodyPart); Top = (tColor, tBodyPart) }, idx when 
                                                                                                idx > 4 &&
                                                                                                getColor (idx - 1)  (fun c -> c.Right) = lColor && 
                                                                                                getBodyPart (idx - 1) (fun c -> c.Right) <> lBodyPart &&
                                                                                                getColor (idx - 4) (fun c -> c.Bottom) = tColor &&
                                                                                                getBodyPart (idx - 4) (fun c -> c.Bottom) <> tBodyPart -> 
                                                                                                yield c
                        | _ -> ()

                   
                    
            }
               
    let rec buildSolution board index =
        let nextIndex = index + 1
        let matches = findMatchingCheckers board index
        seq {
            for c in matches do
                yield c
        }

    buildSolution checkers 0