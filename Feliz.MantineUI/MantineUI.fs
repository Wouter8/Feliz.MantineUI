namespace Feliz.MantineUI

open Fable.React
open Fable.Core.JsInterop
open Feliz
open System.ComponentModel
open Wv8


[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module ManHelpers =

    (* Packages *)
    [<Literal>]
    let MantineCore = "@mantine/core"

    [<Literal>]
    let MantineDates = "@mantine/dates"

    (* Component creation helpers *)
    let inline reactElement (el: ReactElementType) (props: 'a) : ReactElement = import "createElement" "react"

    let inline createElement (el: ReactElementType) (props: IReactProperty list) : ReactElement =
        reactElement el (!!props |> fromFlatEntries)

    let inline createElementWithChildren
        (el: ReactElementType)
        (props: IReactProperty list)
        (children: List<ReactElement>)
        : ReactElement =
        let childrenProp = [ prop.children children ]
        let combined = Seq.append props childrenProp |> Seq.toArray

        reactElement el (!!combined |> fromFlatEntries)


/// Type containing all MantineUI components.
type Man =
    [<Hook>]
    static member inline useCombobox(options: UseComboboxOptions) : ComboboxStore = import "useCombobox" MantineCore

    static member inline actionIcon props children =
        createElementWithChildren (import "ActionIcon" MantineCore) props children

    static member inline drawer props children =
        createElementWithChildren (import "Drawer" MantineCore) props children

    static member inline mantineProvider props children =
        createElementWithChildren (import "MantineProvider" MantineCore) props children

    static member inline button props children =
        createElementWithChildren (import "Button" MantineCore) props children

    static member inline buttonGroup props children =
        createElementWithChildren (import "ButtonGroup" MantineCore) props children

    static member inline title props children =
        createElementWithChildren (import "Title" MantineCore) props children

    static member inline numberInput props =
        createElement (import "NumberInput" MantineCore) props

    static member inline textInput props =
        createElement (import "TextInput" MantineCore) props

    static member inline table props children =
        createElementWithChildren (import "Table" MantineCore) props children

    /// Provide data through props.
    static member inline table' props =
        createElement (import "Table" MantineCore) props

    static member inline tbody props children =
        createElementWithChildren (import "TableTbody" MantineCore) props children

    static member inline thead props children =
        createElementWithChildren (import "TableThead" MantineCore) props children

    static member inline tfoot props children =
        createElementWithChildren (import "TableTfoot" MantineCore) props children

    static member inline tr props children =
        createElementWithChildren (import "TableTr" MantineCore) props children

    static member inline th props children =
        createElementWithChildren (import "TableTh" MantineCore) props children

    static member inline td props children =
        createElementWithChildren (import "TableTd" MantineCore) props children

    static member inline tableCaption props children =
        createElementWithChildren (import "TableCaption" MantineCore) props children

    static member inline tableScrollContainer props children =
        createElementWithChildren (import "TableScrollContainer" MantineCore) props children

    static member inline text props (t: string) =
        createElementWithChildren (import "Text" MantineCore) props [ Html.text t ]

    static member inline checkbox props children =
        createElementWithChildren (import "Checkbox" MantineCore) props children

    static member inline checkboxGroup props children =
        createElementWithChildren (import "CheckboxGroup" MantineCore) props children

    static member inline datePicker props =
        createElement (import "DatePicker" MantineDates) props

    static member inline dateInput props =
        createElement (import "DateInput" MantineDates) props

    static member inline datesProvider props children =
        createElementWithChildren (import "DatesProvider" MantineDates) props children

    static member inline inputBase props =
        createElement (import "InputBase" MantineCore) props

    static member inline combobox props children =
        createElementWithChildren (import "Combobox" MantineCore) props children

    static member inline comboboxTarget props children =
        createElementWithChildren (import "ComboboxTarget" MantineCore) props children

    static member inline comboboxDropdown props children =
        createElementWithChildren (import "ComboboxDropdown" MantineCore) props children

    static member inline comboboxOptions props children =
        createElementWithChildren (import "ComboboxOptions" MantineCore) props children

    static member inline comboboxOption props children =
        createElementWithChildren (import "ComboboxOption" MantineCore) props children
