﻿module Actors
  open WorldPos

  [<AbstractClass>]
  type Actor(pos: WorldPos) =
    member this.Pos = pos
    abstract member Character: char

  type Squirrel(pos: WorldPos, hasAcorn: bool) =
    inherit Actor(pos)
    member this.HasAcorn = hasAcorn
    override this.Character = 'S'

  let createSquirrel x y = 
    let pos = newPos x y
    new Squirrel(pos, false)