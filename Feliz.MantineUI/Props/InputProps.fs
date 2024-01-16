module Feliz.MantineUI.Props.InputProps

open Fable.Core
open Feliz

[<Erase>]
type size =
    static member inline sizeXs = Interop.mkAttr "size" "xs"
    static member inline sizeSm = Interop.mkAttr "size" "sm"
    static member inline sizeMd = Interop.mkAttr "size" "md"
    static member inline sizeLg = Interop.mkAttr "size" "lg"
    static member inline sizeXl = Interop.mkAttr "size" "xl"
    static member inline sizeCustom(value: int) = Interop.mkAttr "size" value


[<Erase>]
module input =
    [<Erase>]
    type variant =
        static member inline default' = Interop.mkAttr "variant" "default"
        static member inline filled = Interop.mkAttr "variant" "filled"
        static member inline unstyled = Interop.mkAttr "variant" "unstyled"


    /// Key of theme.radius or any valid CSS value to set border-radius, numbers are converted to rem,
    /// theme.defaultRadius by default.
    [<Erase>]
    type radius =
        static member inline xs = Interop.mkAttr "radius" "xs"
        static member inline sm = Interop.mkAttr "radius" "sm"
        static member inline md = Interop.mkAttr "radius" "md"
        static member inline lg = Interop.mkAttr "radius" "lg"
        static member inline xl = Interop.mkAttr "radius" "xl"
        static member inline custom(value: int) = Interop.mkAttr "radius" value

    [<Erase>]
    type as' =
        static member inline button = Interop.mkAttr "as" "button"
        static member inline select = Interop.mkAttr "as" "select"
        static member inline textarea = Interop.mkAttr "as" "textarea"
        static member inline custom(value: string) = Interop.mkAttr "as" value

[<Erase>]
type input =
    inherit size

    /// Sets disabled attribute on the input element to true.
    static member inline disabled = Interop.mkAttr "disabled" true
    /// Sets disabled attribute on the input element.
    static member inline disabled'(value: bool) = Interop.mkAttr "disabled" value
    /// Determines whether the input should have error styles and aria-invalid attribute.
    static member inline error(value: ReactElement) = Interop.mkAttr "error" value
    /// Content section rendered on the left side of the input.
    static member inline leftSection(value: ReactElement) = Interop.mkAttr "leftSection" value
    /// Content section rendered on the right side of the input
    static member inline rightSection(value: ReactElement) = Interop.mkAttr "rightSection" value
    /// Left section width, used to set width of the section and input padding-left, by default equals to the input
    /// height.
    static member inline leftSectionWidth(value: int) = Interop.mkAttr "leftSectionWidth" value

    /// Right section width, used to set width of the section and input padding-right, by default equals to the input
    /// height.
    static member inline rightSectionWidth(value: int) =
        Interop.mkAttr "rightSectionWidth" value

    /// Sets pointer-events styles on the leftSection element, 'none' by default.
    static member inline leftSectionPointerEvents(value: string) =
        Interop.mkAttr "leftSectionPointerEvents" value

    /// Sets pointer-events styles on the rightSection element, 'none' by default.
    static member inline rightSectionPointerEvents(value: string) =
        Interop.mkAttr "leftSectionPointerEvents" value

    /// Sets pointer style to 'cursor' for the input, false by default.
    static member inline pointer = Interop.mkAttr "pointer" true
    /// Determines whether the input should have cursor: pointer style, false by default
    static member inline pointer'(value: bool) = Interop.mkAttr "pointer" value
    /// Sets multiline to true so that input can have multiple lines, for example when component="textarea", false by
    /// default.
    static member inline multiline = Interop.mkAttr "multiline" true
    /// Determines whether the input can have multiple lines, for example when component="textarea", false by default.
    static member inline multiline'(value: bool) = Interop.mkAttr "multiline" value
    /// Sets required attribute on the input element to true.
    static member inline required = Interop.mkAttr "required" true
    /// Sets required attribute on the input element.
    static member inline required'(value: bool) = Interop.mkAttr "required" value
    /// Determines whether aria- and other accessibility attributes should be added to the input, true by default.
    static member inline withAria(value: bool) = Interop.mkAttr "withAria" value
    /// Determines whether the input should have red border and red text color when the error prop is set, true by
    /// default.
    static member inline withErrorStyles(value: bool) = Interop.mkAttr "withErrorStyles" value
    /// Props passed down to the root element of the Input component. Also see `inputWrapper`.
    static member inline wrapperProps(value: List<IReactProperty>) = Interop.mkAttr "wrapperProps" value


[<Erase>]
module inputLabel =
    /// Input.Label root element, 'label' by default.
    [<Erase>]
    type element =
        static member inline div = Interop.mkAttr "labelElement" "div"
        /// Is the default.
        static member inline label = Interop.mkAttr "labelElement" "label"

[<Erase>]
type inputWrapper =
    inherit size

    /// Contents of Input.Description component. If not set, description is not rendered.
    static member inline description(value: ReactElement) = Interop.mkAttr "description" value
    /// Contents of Input.Error component. If not set, error is not rendered.
    static member inline error(value: ReactElement) = Interop.mkAttr "error" value

    static member inline inputContainer(value: (List<ReactElement>) -> ReactElement) =
        Interop.mkAttr "inputContainer" value

    /// Controls order of the elements, ['label', 'description', 'input', 'error'] by default.
    static member inline inputWrapperOrder(value: List<string>) =
        Interop.mkAttr "inputWrapperOrder" value

    /// Contents of Input.Label component. If not set, label is not rendered.
    static member inline label(value: ReactElement) = Interop.mkAttr "label" value
    /// Sets required attribute on the input element to true.
    static member inline required = Interop.mkAttr "required" true
    /// Sets required attribute on the input element.
    static member inline required'(value: bool) = Interop.mkAttr "required" value
    /// Adds an required asterisk to the input. Overrides required prop. Does not add required attribute to the input.
    /// false by default.
    static member inline withAsterisk = Interop.mkAttr "withAsterisk" true
    /// Determines whether the required asterisk should be displayed. Overrides required prop. Does not add required
    /// attribute to the input. false by default.
    static member inline withAsterisk'(value: bool) = Interop.mkAttr "withAsterisk" value

type inputLabel =
    inherit size

    /// Shows a required asterisk next to the label.
    static member inline required = Interop.mkAttr "required" true
    /// Determines whether the required asterisk should be displayed.
    static member inline required'(value: bool) = Interop.mkAttr "required" value

type inputDescription = size
type inputError = size
