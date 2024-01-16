namespace Feliz.MantineUI

open Feliz

module buttonGroup =
    type orientation =
        static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
        static member inline vertical = Interop.mkAttr "orientation" "vertical"