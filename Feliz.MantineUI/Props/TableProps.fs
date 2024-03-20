module Feliz.MantineUI.Props.TableProps

open Fable.Core
open Feliz

[<Erase>]
module table =
    /// Determines on which side Table.Caption is displayed, bottom by default.
    [<Erase>]
    type captionSide =
        static member inline top = Interop.mkAttr "captionSide" "top"
        static member inline bottom = Interop.mkAttr "captionSide" "bottom"

    /// Horizontal cells spacing, key of theme.spacing or any valid CSS value for padding, numbers are converted to rem,
    /// default value is xs.
    [<Erase>]
    type horizontalSpacing =
        static member inline xs = Interop.mkAttr "horizontalSpacing" "xs"
        static member inline sm = Interop.mkAttr "horizontalSpacing" "sm"
        static member inline md = Interop.mkAttr "horizontalSpacing" "md"
        static member inline lg = Interop.mkAttr "horizontalSpacing" "lg"
        static member inline xl = Interop.mkAttr "horizontalSpacing" "xl"

    /// Vertical cells spacing, key of theme.spacing or any valid CSS value for padding, numbers are converted to rem,
    /// default value is xs.
    [<Erase>]
    type verticalSpacing =
        static member inline xs = Interop.mkAttr "verticalSpacing" "xs"
        static member inline sm = Interop.mkAttr "verticalSpacing" "sm"
        static member inline md = Interop.mkAttr "verticalSpacing" "md"
        static member inline lg = Interop.mkAttr "verticalSpacing" "lg"
        static member inline xl = Interop.mkAttr "verticalSpacing" "xl"

    /// Determines whether every odd/even row background should be changed to strippedColor, if set to true, then odd
    /// value will be used, false by default.
    [<Erase>]
    type striped =
        static member inline odd = Interop.mkAttr "striped" "odd"
        static member inline even = Interop.mkAttr "striped" "even"

    [<Erase>]
    type classNames =
        static member inline table(value: string) = unbox ("classNames.table", value)
        static member inline thead(value: string) = unbox ("classNames.thead", value)
        static member inline tbody(value: string) = unbox ("classNames.tbody", value)
        static member inline tfoot(value: string) = unbox ("classNames.tfoot", value)
        static member inline tr(value: string) = unbox ("classNames.tr", value)
        static member inline th(value: string) = unbox ("classNames.th", value)
        static member inline td(value: string) = unbox ("classNames.td", value)
        static member inline caption(value: string) = unbox ("classNames.caption", value)

[<Erase>]
type table =
    /// Color of table borders, key of theme.colors or any valid CSS color.
    static member inline borderColor(value: string) = Interop.mkAttr "borderColor" value
    /// An array of React nodes (React.ReactNode[]) to render Table.Th in Table.Thead.
    /// Data that should be used to generate table, ignored if children prop is set.
    static member inline dataHead(value: List<ReactElement>) = unbox ("data.head", value)
    // An array of React nodes (React.ReactNode[]) to render Table.Th in Table.Tfoot.
    /// Data that should be used to generate table, ignored if children prop is set.
    static member inline dataFoot(value: List<ReactElement>) = unbox ("data.foot", value)
    /// An array of arrays of React nodes (React.ReactNode[][]) to render Table.Td in Table.Tbody.
    /// Same as `dataBody`.
    /// Data that should be used to generate table, ignored if children prop is set.
    static member inline data(value: List<ReactElement>) = unbox ("data.body", value)
    /// An array of arrays of React nodes (React.ReactNode[][]) to render Table.Td in Table.Tbody.
    /// Same as `data`.
    /// Data that should be used to generate table, ignored if children prop is set.
    static member inline dataBody(value: List<ReactElement>) = unbox ("data.body", value)
    /// A React node to render Table.Caption.
    /// Data that should be used to generate table, ignored if children prop is set.
    static member inline dataCaption(value: ReactElement) = unbox ("data.caption", value)
    /// Determines whether table rows background should change to highlightOnHoverColor when hovered, false by default.
    static member inline highlightOnHover(value: bool) = Interop.mkAttr "highlightOnHover" value

    /// Background color of table rows when hovered, key of theme.colors or any valid CSS color.
    static member inline highlightOnHoverColor(value: string) =
        Interop.mkAttr "highlightOnHoverColor" value

    /// Horizontal cells spacing, key of theme.spacing or any valid CSS value for padding, numbers are converted to rem,
    /// default value is xs.
    static member inline horizontalSpacing(value: int) =
        Interop.mkAttr "horizontalSpacing" value

    /// Value of table-layout style, auto by default.
    static member inline layout(value: string) = Interop.mkAttr "layout" value
    /// Determines whether Table.Thead should be sticky, false by default.
    static member inline stickyHeader = Interop.mkAttr "stickyHeader" true
    /// Determines whether Table.Thead should be sticky, false by default.
    static member inline stickyHeader'(value: bool) = Interop.mkAttr "stickyHeader" value

    /// Offset from top at which Table.Thead should become sticky, 0 by default.
    static member inline stickyHeaderOffset(value: string) =
        Interop.mkAttr "stickyHeaderOffset" value

    /// Offset from top at which Table.Thead should become sticky, 0 by default.
    static member inline stickyHeaderOffset(value: int) =
        Interop.mkAttr "stickyHeaderOffset" value

    /// Determines whether every odd/even row background should be changed to strippedColor, if set to true, then odd
    /// value will be used, false by default.
    static member inline striped = Interop.mkAttr "striped" true
    /// Determines whether every odd/even row background should be changed to strippedColor, if set to true, then odd
    /// value will be used, false by default.
    static member inline striped'(value: bool) = Interop.mkAttr "striped" value
    /// Background color of striped rows, key of theme.colors or any valid CSS color.
    static member inline stripedColor(value: string) = Interop.mkAttr "stripedColor" value
    /// Vertical cells spacing, key of theme.spacing or any valid CSS value for padding, numbers are converted to rem,
    /// default value is xs.
    static member inline verticalSpacing(value: int) = Interop.mkAttr "verticalSpacing" value
    /// Determines whether the table should have borders between columns, false by default.
    static member inline withColumnBorders = Interop.mkAttr "withColumnBorders" true

    /// Determines whether the table should have borders between columns, false by default.
    static member inline withColumnBorders'(value: bool) =
        Interop.mkAttr "withColumnBorders" value

    /// Determines whether the table should have borders between rows, true by default.
    static member inline withRowBorders = Interop.mkAttr "withRowBorders" true
    /// Determines whether the table should have borders between rows, true by default.
    static member inline withRowBorders'(value: bool) = Interop.mkAttr "withRowBorders" value
    /// Determines whether the table should have outer border, false by default.
    static member inline withTableBorder = Interop.mkAttr "withTableBorder" true
    /// Determines whether the table should have outer border, false by default.
    static member inline withTableBorder'(value: bool) = Interop.mkAttr "withTableBorder" value

[<Erase>]
module tableScrollContainer =
    /// Type of the scroll container, `native` to use native scrollbars, `scrollarea` to use `ScrollArea` component,
    /// `scrollarea` by default.
    [<Erase>]
    type type' =
        static member inline native = Interop.mkAttr "type" "native"
        static member inline scrollArea = Interop.mkAttr "type" "scrollarea"

[<Erase>]
type tableScrollContainer =
    /// `min-width` of the `Table` at which it should become scrollable.
    /// TODO: does this work or should it be a string which includes "px"?
    static member inline minWidth(value: int) = Interop.mkAttr "minWidth" value
    /// `min-width` of the `Table` at which it should become scrollable.
    static member inline minWidth(value: string) = Interop.mkAttr "minWidth" value
