module Feliz.MantineUI.Props.DrawerProps

open Fable.Core
open Feliz
open Feliz.MantineUI

[<Erase>]
module drawer =
    [<Erase>]
    type position =
        static member inline left = Interop.mkAttr "position" "left"
        static member inline top = Interop.mkAttr "position" "top"
        static member inline right = Interop.mkAttr "position" "right"
        static member inline bottom = Interop.mkAttr "position" "bottom"

[<Erase>]
type drawer =
    static member inline closeButtonProps(value: List<IReactProperty>) = Interop.mkAttr "closeButtonProps" value

    static member inline closeOnClickOutside(value: bool) =
        Interop.mkAttr "closeOnClickOutside" value

    static member inline closeOnEscape(value: bool) = Interop.mkAttr "closeOnEscape" value
    static member inline keepMounted = Interop.mkAttr "keepMounted" true
    static member inline keepMounted'(value: bool) = Interop.mkAttr "keepMounted" value
    static member inline lockScroll(value: bool) = Interop.mkAttr "lockScroll" value
    static member inline offset(value: int) = Interop.mkAttr "offset" value
    static member inline offset(value: string) = Interop.mkAttr "overlay" value
    static member inline onClose(value: unit -> unit) = Interop.mkAttr "onClose" value
    static member inline opened(value: bool) = Interop.mkAttr "opened" value
    static member inline overlayProps(value: List<IReactProperty>) = Interop.mkAttr "overlayProps" value
    static member inline padding(value: Domain.Size) = Interop.mkAttr "padding" value
    static member inline portalProps(value: List<IReactProperty>) = Interop.mkAttr "portalProps" value
    static member inline radius(value: Domain.Size) = Interop.mkAttr "radius" value
    static member inline radius(value: int) = Interop.mkAttr "radius" value

    static member inline removeScrollProps(value: List<IReactProperty>) =
        Interop.mkAttr "removeScrollProps" value

    static member inline returnFocus(value: bool) = Interop.mkAttr "returnFocus" value
    // ScrollAreaComponent
    static member inline shadow(value: Domain.Size) = Interop.mkAttr "shadow" value
    static member inline size(value: Domain.Size) = Interop.mkAttr "size" value
    static member inline size(value: int) = Interop.mkAttr "size" value
    static member inline size(value: string) = Interop.mkAttr "size" value
    static member inline title(value: string) = Interop.mkAttr "title" value
    static member inline transitionProps(value: List<IReactProperty>) = Interop.mkAttr "transitionProps" value
    static member inline trapFocus(value: bool) = Interop.mkAttr "trapFocus" value
    static member inline withCloseButton(value: bool) = Interop.mkAttr "withCloseButton" value
    static member inline withOverlay(value: bool) = Interop.mkAttr "withOverlay" value
    static member inline withinPortal(value: bool) = Interop.mkAttr "withinPortal" value
    static member inline zIndex(value: int) = Interop.mkAttr "zIndex" value
    static member inline zIndex(value: string) = Interop.mkAttr "zIndex" value
