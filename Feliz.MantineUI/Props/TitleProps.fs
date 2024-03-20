namespace Feliz.MantineUI

open Feliz
open Fable.Core
open Feliz.MantineUI.Props.TextProps

[<Erase>]
module title =
    /// Changes title size, if not set, then size is controlled by order prop.
    [<Erase>]
    type size =
        static member inline h1 = Interop.mkAttr "size" "h1"
        static member inline h2 = Interop.mkAttr "size" "h2"
        static member inline h3 = Interop.mkAttr "size" "h3"
        static member inline h4 = Interop.mkAttr "size" "h4"
        static member inline h5 = Interop.mkAttr "size" "h5"
        static member inline h6 = Interop.mkAttr "size" "h6"

[<Erase>]
type title =
    /// Determines which tag will be used (h1-h6), controls font-size style if size prop is not set, 1 by default.
    static member inline order(value: int) = Interop.mkAttr "order" value
    /// Changes title size, if not set, then size is controlled by order prop.
    static member inline size(value: string) = Interop.mkAttr "size" value
    /// Number of lines after which Text will be truncated.
    static member inline lineClamp(value: int) = Interop.mkAttr "lineClamp" value
