module Feliz.MantineUI.Props.SelectProps

open Fable.Core
open Feliz
open Feliz.MantineUI

[<Erase>]
module select =
    type checkIconPosition =
        static member inline left = Interop.mkAttr "left" true
        static member inline right = Interop.mkAttr "right" true

[<Erase>]
type select =
    // static member inline allowDeselect = Interop.mkAttr "allowDeselect" true
    // static member inline allowDeselect' (value: bool) = Interop.mkAttr "allowDeselect" value
    // static member inline clearButtonProps' (value: List<IReactProperty>) = Interop.mkAttr "clearButtonProps" value
    // static member inline clearable = Interop.mkAttr "clearable" true
    // static member inline clearable' (value: bool) = Interop.mkAttr "clearable" value
    // static member inline comboboxProps
    static member inline data(value: List<string>) = Interop.mkAttr "data" value
    static member inline data(value: List<ComboboxStringItem>) = Interop.mkAttr "data" value
    static member inline data(value: List<ComboboxItem>) = Interop.mkAttr "data" value
    static member inline data(value: List<ComboboxParsedItemGroup>) = Interop.mkAttr "data" value
