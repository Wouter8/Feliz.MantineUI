module Feliz.MantineUI.Props.NumberInputProps

open Fable.Core.JS
open Feliz
open Fable.Core
open Feliz.MantineUI
open Feliz.MantineUI.Props.InputProps
open Browser.Types
open Fable.Core.JsInterop
open Fable.Core
open Feliz.Styles
open System.ComponentModel
open System

[<Erase>]
type NumberInputHandlers =
    abstract member increment: unit -> unit
    abstract member decrement: unit -> unit

[<Erase>]
module numberInput =
    /// Controls how value is clamped, strict – user is not allowed to enter values that are not in [min, max] range,
    /// blur – user is allowed to enter any values, but the value is clamped when the input loses focus (default
    /// behavior), none – lifts all restrictions, [min, max] range is applied only for controls and up/down keys.
    [<Erase>]
    type clampBehavior =
        static member inline none = Interop.mkAttr "clampBehavior" "none"
        static member inline blur = Interop.mkAttr "clampBehavior" "blur"
        static member inline strict = Interop.mkAttr "clampBehavior" "strict"

    /// Defines the thousand grouping style.
    [<Erase>]
    type thousandsGroupStyle =
        static member inline none = Interop.mkAttr "thousandsGroupStyle" "none"
        static member inline thousand = Interop.mkAttr "thousandsGroupStyle" "thousand"
        static member inline lakh = Interop.mkAttr "thousandsGroupStyle" "lakh"
        static member inline wan = Interop.mkAttr "thousandsGroupStyle" "wan"

    /// Controls input type attribute, 'text' by default.
    [<Erase>]
    type type' =
        static member inline text = Interop.mkAttr "type" "text"
        static member inline tel = Interop.mkAttr "type" "tel"
        static member inline password = Interop.mkAttr "type" "password"


/// Also supports all `inputWrapper` and `input` element props.
[<Erase>]
type numberInput =
    inherit input

    /// Determines whether decimal values are allowed, true by default.
    static member inline allowDecimal(value: bool) = Interop.mkAttr "allowDecimal" value
    /// Determines whether leading zeros are allowed. If not set, leading zeros are removed when the input is blurred.
    /// false by default.
    static member inline allowLeadingZeros = Interop.mkAttr "allowLeadingZeros" true

    /// Determines whether leading zeros are allowed. If not set, leading zeros are removed when the input is blurred.
    /// false by default.
    static member inline allowLeadingZeros'(value: bool) =
        Interop.mkAttr "allowLeadingZeros" value

    /// Determines whether negative values are allowed, true by default.
    static member inline allowNegative(value: bool) = Interop.mkAttr "allowNegative" value

    /// Characters which when pressed result in a decimal separator, ['.'] by default.
    static member inline allowedDecimalSeparators(value: List<string>) =
        Interop.mkAttr "allowedDecimalSeparators" value

    /// Limits the number of digits that can be entered after the decimal point.
    static member inline decimalScale(value: int) = Interop.mkAttr "decimalScale" value
    /// Character used as a decimal separator, '.' by default.
    static member inline decimalSeparator(value: char) = Interop.mkAttr "decimalSeparator" value
    /// If set, 0s are added after decimalSeparator to match given decimalScale. false by default.
    static member inline fixedDecimalScale = Interop.mkAttr "fixedDecimalScale" true

    /// If set, 0s are added after decimalSeparator to match given decimalScale. false by default.
    static member inline fixedDecimalScale'(value: bool) =
        Interop.mkAttr "fixedDecimalScale" value

    /// Increment/decrement handlers.
    static member inline handlers(value: IRefValue<NumberInputHandlers>) = Interop.mkAttr "handlers" value

    /// Determines whether the up/down controls should be hidden, false by default.
    static member inline hideControls = Interop.mkAttr "hideControls" true
    /// Determines whether the up/down controls should be hidden, false by default.
    static member inline hideControls'(value: bool) = Interop.mkAttr "hideControls" value
    /// A function to validate the input value. If this function returns false, the onChange will not be called and the
    /// input value will not change.
    static member inline isAllowed(value: (string -> bool)) = Interop.mkAttr "isAllowed" value
    /// A function to validate the input value. If this function returns false, the onChange will not be called and the
    /// input value will not change.
    static member inline isAllowed(value: (float -> bool)) = Interop.mkAttr "isAllowed" value
    /// Maximum possible value.
    static member inline max(value: float) = Interop.mkAttr "max" value
    /// Minimum possible value.
    static member inline min(value: float) = Interop.mkAttr "min" value

    /// Called when value changes.
    static member inline onChange(value: string -> unit) = Interop.mkAttr "onChange" value

    /// Called when value changes.
    static member inline onChange(handler: Option<int> -> unit) =
        Interop.mkAttr "onChange" (tryInt >> handler)

    /// Called when value changes.
    static member inline onChange(handler: Option<float> -> unit) =
        Interop.mkAttr "onChange" (tryFloat >> handler)
    //static member inline onChange(value: 't -> unit) = Interop.mkAttr "onChange" value
    /// Prefix added before the input value.
    static member inline prefix(value: string) = Interop.mkAttr "prefix" value

    /// Value set to the input when increment/decrement buttons are clicked or up/down arrows pressed if the input is
    /// empty, 0 by default.
    static member inline startValue(value: float) = Interop.mkAttr "startValue" value
    /// Number by which value will be incremented/decremented with up/down controls and keyboard arrows, 1 by default.
    static member inline step(value: int) = Interop.mkAttr "step" value
    /// Number by which value will be incremented/decremented with up/down controls and keyboard arrows, 1 by default.
    static member inline step(value: float) = Interop.mkAttr "step" value
    /// Initial delay in milliseconds before stepping the value.
    static member inline stepHoldDelay(value: int) = Interop.mkAttr "stepHoldDelay" value
    /// Delay before stepping the value. Can be a number of milliseconds or a function that receives the current step
    /// count and returns the delay in milliseconds.
    static member inline stepHoldInterval(value: int) = Interop.mkAttr "stepHoldInterval" value
    /// Delay before stepping the value. Can be a number of milliseconds or a function that receives the current step
    /// count and returns the delay in milliseconds.
    static member inline stepHoldInterval(value: int -> int) = Interop.mkAttr "stepHoldInterval" value
    /// Suffix added after the input value.
    static member inline suffix(value: string) = Interop.mkAttr "suffix" value

    /// A character used to separate thousands, ',' by default.
    static member inline thousandSeparator(value: string) =
        Interop.mkAttr "thousandSeparator" value

    /// Enable/disable thousand separator. Enabled by default.
    static member inline thousandSeparator(value: bool) =
        Interop.mkAttr "thousandSeparator" value

    /// Controlled component value.
    static member inline value(value: string) = Interop.mkAttr "value" value

    /// Controlled component value.
    static member inline value(value: int) = Interop.mkAttr "value" (string value)

    /// Controlled component value.
    static member inline value(value: float) = Interop.mkAttr "value" (string value)

    /// Controlled component value.
    static member inline value(value: Option<int>) =
        Interop.mkAttr "value" (value |> Option.map string |> Option.defaultValue "")

    /// Controlled component value.
    static member inline value(value: Option<float>) =
        Interop.mkAttr "value" (value |> Option.map string |> Option.defaultValue "")
