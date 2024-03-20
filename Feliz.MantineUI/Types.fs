namespace Feliz.MantineUI

open System
open Fable.Core
open Feliz

[<AutoOpen; Erase>]
module Domain =
    [<RequireQualifiedAccess>]
    [<StringEnum>]
    [<Erase>]
    type Size =
        | Xs
        | Sm
        | Md
        | Lg
        | Xl

    [<RequireQualifiedAccess>]
    [<StringEnum>]
    [<Erase>]
    type Variant =
        | Default
        | Filled
        | Light
        | Outline
        | Subtle
        | Transparent
        | White

    let tryInt (s: string) =
        match Int32.TryParse s with
        | (true, i) -> Some i
        | _ -> None

    let tryFloat (s: string) =
        match Double.TryParse s with
        | (true, i) -> Some i
        | _ -> None

module Types =
    [<Erase>]
    type gradient =
        static member inline from(value: string) = unbox ("gradient.from", value)
        static member inline to'(value: string) = unbox ("gradient.to'", value)
        static member inline deg(value: string) = unbox ("gradient.deg", value)

    [<Erase>]
    type labelElement =
        static member inline div = Interop.mkAttr "labelElement" "div"
        /// Is the default.
        static member inline label = Interop.mkAttr "labelElement" "label"

type ComboboxStringItem = { disabled: bool; value: string }

type ComboboxItem =
    { disabled: bool
      value: int
      label: string }

type ComboboxParsedItemGroup =
    { group: string
      items: List<ComboboxItem> }

[<StringEnum>]
type ComboboxDropdownEventSource =
    | Keyboard
    | Mouse
    | Unknown

type ComboboxStore =
    abstract dropdownOpened: Option<bool> with get, set
    abstract openDropdown: (Option<ComboboxDropdownEventSource> -> unit) with get, set
    abstract closeDropdown: (Option<ComboboxDropdownEventSource> -> unit) with get, set
    abstract toggleDropdown: (Option<ComboboxDropdownEventSource> -> unit) with get, set
    abstract resetSelectedOption: (unit -> unit) with get, set

type ComboboxOptionProps =
    abstract value: string with get, set
    abstract active: bool with get, set
    abstract disabled: bool with get, set
    abstract selected: bool with get, set

[<StringEnum>]
type ScrollBehavior =
    | Auto
    | Instant
    | Smooth

[<Global>]
type UseComboboxOptions
    [<ParamObject; Emit("$0")>]
    (
        ?defaultOpened: bool,
        ?opened: bool,
        ?onOpenedChange: (bool -> unit),
        ?onDropdownClose: (ComboboxDropdownEventSource -> unit),
        ?onDropdownOpen: (ComboboxDropdownEventSource -> unit),
        ?loop: bool,
        ?scrollBehavior: ScrollBehavior
    ) =
    member val defaultOpened: Option<bool> = jsNative with get, set
    member val opened: Option<bool> = jsNative with get, set
    member val onOpenedChange: Option<(bool -> unit)> = jsNative with get, set
    member val onDropdownClose: Option<(ComboboxDropdownEventSource -> unit)> = jsNative with get, set
    member val onDropdownOpen: Option<(ComboboxDropdownEventSource -> unit)> = jsNative with get, set
    member val loop: Option<bool> = jsNative with get, set
    member val scrollBehavior: Option<ScrollBehavior> = jsNative with get, set
