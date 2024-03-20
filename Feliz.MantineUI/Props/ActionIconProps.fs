module Feliz.MantineUI.Props.ActionIconProps

open Fable.Core
open Feliz
open Feliz.MantineUI

[<Erase>]
type actionIcon =
    static member inline autoContrast = Interop.mkAttr "autoContrast" true
    static member inline color(value: string) = Interop.mkAttr "color" value
    static member inline disabled = Interop.mkAttr "disabled" true
    static member inline disable'(value: bool) = Interop.mkAttr "disable" value
    // gradient
    static member inline loaderProps(value: List<IReactProperty>) = Interop.mkAttr "loaderProps" value
    static member inline loading = Interop.mkAttr "loading" true
    static member inline loading'(value: bool) = Interop.mkAttr "loading" value
    static member inline radius(value: Domain.Size) = Interop.mkAttr "radius" value
    static member inline radius(value: int) = Interop.mkAttr "radius" value
    static member inline size(value: Domain.Size) = Interop.mkAttr "size" value
    static member inline size(value: int) = Interop.mkAttr "size" value
    static member inline size(value: string) = Interop.mkAttr "size" value
    static member inline variant(value: Domain.Variant) = Interop.mkAttr "variant" value
