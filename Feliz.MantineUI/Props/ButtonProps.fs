namespace Feliz.MantineUI

open Feliz
open Fable.Core
open Fable.Core.JsInterop

(*
Component props
*)
[<Erase>]
module button =
    [<Erase>]
    type component' =
        static member inline a = Interop.mkAttr "component" "a"
        static member inline custom(value: string) = Interop.mkAttr "component" value

    [<Erase>]
    type classNames =
        static member inline root(value: string) = unbox ("classNames.root", value)
        static member inline loader(value: string) = unbox ("classNames.loader", value)
        static member inline inner(value: string) = unbox ("classNames.inner", value)
        static member inline section(value: string) = unbox ("classNames.section", value)
        static member inline label(value: string) = unbox ("classNames.label", value)

    [<Erase>]
    type variant =
        static member inline default' = Interop.mkAttr "variant" "default"
        static member inline filled = Interop.mkAttr "variant" "filled"
        static member inline light = Interop.mkAttr "variant" "light"
        static member inline outline = Interop.mkAttr "variant" "outline"
        static member inline subtle = Interop.mkAttr "variant" "subtle"
        static member inline transparent = Interop.mkAttr "variant" "transparent"
        static member inline white = Interop.mkAttr "variant" "white"

    let fullWidth = Interop.mkAttr "fullWidth" true
    let color (value: string) = Interop.mkAttr "color" value
    let disabled (value: bool) = Interop.mkAttr "disabled" value
    let leftSection (value: ReactElement) = Interop.mkAttr "leftSection" value
    let loaderProps (value: seq<IReactProperty>) = Interop.mkAttr "loaderProps" value
    let loading (value: bool) = Interop.mkAttr "loading" value
    let rightSection (value: ReactElement) = Interop.mkAttr "rightSection" value

    [<Erase>]
    type size =
        static member inline xs = Interop.mkAttr "size" "xs"
        static member inline sm = Interop.mkAttr "size" "sm"
        static member inline md = Interop.mkAttr "size" "md"
        static member inline lg = Interop.mkAttr "size" "lg"
        static member inline xl = Interop.mkAttr "size" "xl"
        static member inline custom(value: int) = Interop.mkAttr "size" value
