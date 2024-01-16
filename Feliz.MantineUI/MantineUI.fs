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
