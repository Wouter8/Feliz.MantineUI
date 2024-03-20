module Feliz.MantineUI.Props.DateInputProps

open System
open Fable.Core
open Feliz
open Feliz.MantineUI

[<Erase>]
type dateInput =
    static member inline clearButtonProps(value: List<IReactProperty>) = Interop.mkAttr "clearButtonProps" value
    static member inline clearable = Interop.mkAttr "clearable" true
    static member inline clearable'(value: bool) = Interop.mkAttr "clearable" value
    static member inline dateParser(value: string -> DateTime option) = Interop.mkAttr "dateParser" value
    static member inline dateParser(value: string -> DateOnly option) = Interop.mkAttr "dateParser" value

    static member inline description(value: string) =
        Interop.mkAttr "description" (Html.text value)

    static member inline description(value: ReactElement) = Interop.mkAttr "description" value
    static member inline descriptionProps(value: List<IReactProperty>) = Interop.mkAttr "descriptionProps" value
    static member inline disabled = Interop.mkAttr "disabled" true
    static member inline disabled'(value: bool) = Interop.mkAttr "disabled" value

    static member inline error(value: string) =
        Interop.mkAttr "error" (Html.text value)

    static member inline error(value: ReactElement) = Interop.mkAttr "error" value
    static member inline errorProps(value: List<IReactProperty>) = Interop.mkAttr "errorProps" value
    static member inline fixOnBlur(value: bool) = Interop.mkAttr "fixOnBlur" value

    static member inline inputContainer(value: List<ReactElement> -> ReactElement) =
        Interop.mkAttr "inputContainer" value

    static member inline inputWrapperOrder(value: List<string>) =
        Interop.mkAttr "inputWrapperOrder" value

    static member inline label(value: string) =
        Interop.mkAttr "label" (Html.text value)

    static member inline label(value: ReactElement) = Interop.mkAttr "label" value
    static member inline labelProps(value: List<IReactProperty>) = Interop.mkAttr "labelProps" value
    static member inline leftSection(value: ReactElement) = Interop.mkAttr "leftSection" value

    static member inline leftSectionPointerEvents(value: string) =
        Interop.mkAttr "leftSectionPointerEvents" value

    static member inline leftSectionProps(value: List<IReactProperty>) = Interop.mkAttr "leftSectionProps" value
    static member inline leftSectionWidth(value: int) = Interop.mkAttr "leftSectionWidth" value
    static member inline pointer = Interop.mkAttr "pointer" true
    static member inline pointer'(value: bool) = Interop.mkAttr "pointer" value
    static member inline popoverProps(value: List<IReactProperty>) = Interop.mkAttr "popoverProps" value
    static member inline preserveTime(value: bool) = Interop.mkAttr "preserveTime" value
    static member inline radius(value: Domain.Size) = Interop.mkAttr "radius" value
    static member inline radius(value: string) = Interop.mkAttr "radius" value
    static member inline rightSection(value: ReactElement) = Interop.mkAttr "rightSection" value

    static member inline rightSectionPointerEvents(value: string) =
        Interop.mkAttr "rightSectionPointerEvents" value

    static member inline rightSectionProps(value: List<IReactProperty>) =
        Interop.mkAttr "rightSectionProps" value

    static member inline rightSectionWidth(value: int) =
        Interop.mkAttr "rightSectionWidth" value

    static member inline valueFormat(value: string) = Interop.mkAttr "valueFormat" value

    static member inline withAsterisk = Interop.mkAttr "withAsterisk" true
    static member inline withAsterisk'(value: bool) = Interop.mkAttr "withAsterisk" value
    static member inline withErrorStyles(value: bool) = Interop.mkAttr "withErrorStyles" value
    static member inline wrapperProps(value: List<IReactProperty>) = Interop.mkAttr "wrapperProps" value
