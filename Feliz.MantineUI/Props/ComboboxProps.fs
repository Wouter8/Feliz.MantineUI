module Feliz.MantineUI.Props.ComboboxProps

open Fable.Core
open Feliz
open Feliz.MantineUI


[<Erase>]
type combobox =
    static member inline store(value: ComboboxStore) = Interop.mkAttr "store" value

    static member inline onOptionSubmit(value: (string * ComboboxOptionProps -> unit)) =
        Interop.mkAttr "onOptionSubmit" value

    static member inline size(value: Size) = Interop.mkAttr "size" value
    static member inline size(value: string) = Interop.mkAttr "size" value
    static member inline padding(value: string) = Interop.mkAttr "padding" value
    static member inline padding(value: int) = Interop.mkAttr "padding" value

    static member inline resetSelectionOnOptionHover =
        Interop.mkAttr "resetSelectionOnOptionHover" true

    static member inline resetSelectionOnOptionHover'(value: bool) =
        Interop.mkAttr "resetSelectionOnOptionHover" value

    static member inline readOnly = Interop.mkAttr "readOnly" true
    static member inline readOnly'(value: bool) = Interop.mkAttr "readOnly" value

[<Erase>]
module comboboxTarget =
    [<Erase>]
    type targetType =
        static member inline button = Interop.mkAttr "targetType" "button"
        static member inline input = Interop.mkAttr "targetType" "input"

[<Erase>]
type comboboxTarget =
    static member inline refProp(value: string) = Interop.mkAttr "ref" value

    static member inline withKeyboardNavigation(value: bool) =
        Interop.mkAttr "withKeyboardNavigation" value

    static member inline withAriaAttributes(value: bool) =
        Interop.mkAttr "withAriaAttributes" value

    static member inline withExpandedAttribute = Interop.mkAttr "withExpandedAttribute" true

    static member inline withExpandedAttribute'(value: bool) =
        Interop.mkAttr "withExpandedAttribute" value


[<Erase>]
type comboboxDropdown =
    static member inline hidden = Interop.mkAttr "hidden" true
    static member inline hidden'(value: bool) = Interop.mkAttr "hidden" value

[<Erase>]
type comboboxOptions =
    static member inline labelledBy(value: string) = Interop.mkAttr "labelledBy" value

[<Erase>]
type comboboxOption =
    static member inline value(value: string) = Interop.mkAttr "value" value
    static member inline active(value: bool) = Interop.mkAttr "active" value
    static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
    static member inline selected(value: bool) = Interop.mkAttr "selected" value
