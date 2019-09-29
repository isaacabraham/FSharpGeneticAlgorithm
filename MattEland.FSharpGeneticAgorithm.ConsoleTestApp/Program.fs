﻿// Learn more about F# at http://fsharp.org

open Cells

[<EntryPoint>]
let main argv =
    let actors = World.generate
    for y in 1..8 do
      for x in 1..8 do   
        // Determine which character should exist in this line
        let mutable char = '.'
        for actor in actors do
          if actor.Pos.X = x && actor.Pos.Y = y then
            char <- actor.Character

        printCell char (x = 8)

    0 // return an integer exit code
