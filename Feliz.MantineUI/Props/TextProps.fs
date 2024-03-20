module Feliz.MantineUI.Props.TextProps

open Fable.Core
open Feliz
open Feliz.MantineUI

[<Erase>]
module text =
    /// Gradient configuration, ignored when variant is not gradient, theme.defaultGradient by default.
    [<Erase>]
    type gradient = Types.gradient

    /// Side on which Text must be truncated, if true, text is truncated from the start.
    [<Erase>]
    type truncate =
        static member inline start = Interop.mkAttr "truncate" "start"
        static member inline end' = Interop.mkAttr "truncate" "end"

[<Erase>]
type text =
    static member inline color(value: string) = Interop.mkAttr "c" value
    /// Sets line-height to 1 for centering, false by default.
    static member inline inline' = Interop.mkAttr "inline" true
    /// Sets line-height to 1 for centering, false by default.
    static member inline inline''(value: bool) = Interop.mkAttr "inline" value
    /// Number of lines after which Text will be truncated.
    static member inline lineClamp(value: int) = Interop.mkAttr "lineClamp" value
    /// Shorthand for component="span", false by default, default root element is p.
    static member inline span = Interop.mkAttr "span" true
    /// Shorthand for component="span", false by default, default root element is p.
    static member inline span'(value: bool) = Interop.mkAttr "span" value
    /// Side on which Text must be truncated, if true, text is truncated from the start.
    static member inline truncate = Interop.mkAttr "truncate" true
    /// Side on which Text must be truncated, if true, text is truncated from the start.
    static member inline truncate'(value: bool) = Interop.mkAttr "truncate" value
    /// Controls font-size and line-height, 'md' by default.
    static member inline size(value: Domain.Size) = Interop.mkAttr "size" value
    /// Controls font-size and line-height, 'md' by default.
    static member inline size(value: string) = Interop.mkAttr "size" value
