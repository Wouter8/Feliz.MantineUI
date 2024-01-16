namespace Feliz.MantineUI

open Feliz
open Fable.Core

module title =
    let order (o: int) = Interop.mkAttr "order" o