module Feliz.MantineUI.Props.InputBaseProps

open Fable.Core
open Feliz

[<Erase>]
type inputBase =
    static member inline wrapperProps(value: obj) = Interop.mkAttr "wrapperProps" value
    static member inline multiline = Interop.mkAttr "multiline" true
    static member inline multiline'(value: bool) = Interop.mkAttr "multiline" value
    static member inline withAria(value: bool) = Interop.mkAttr "withAria" value
