module Feliz.MantineUI.Props.TextInputProps

open Feliz
open Fable.Core
open Feliz.MantineUI.Props.InputProps

/// Also supports all `inputWrapper` and `input` element props.
[<Erase>]
type textInput =
    inherit input

    static member inline value(value: string) = Interop.mkAttr "value" value
