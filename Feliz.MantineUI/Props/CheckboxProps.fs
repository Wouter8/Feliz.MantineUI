module Feliz.MantineUI.Props.CheckboxProps

open Browser.Types
open Fable.Core
open Feliz
open Feliz.MantineUI

[<Erase>]
type checkboxProps =
    { indeterminate: bool
      className: string }

[<Erase>]
module checkbox =
    /// Position of the label relative to the input, 'right' by default.
    [<Erase>]
    type labelPosition =
        static member inline left = "left"
        static member inline right = "right"

[<Erase>]
type checkbox =
    /// Determines whether icon color with filled variant should depend on background-color. If luminosity of the color
    /// prop is less than theme.luminosityThreshold, then theme.white will be used for text color, otherwise
    /// theme.black. Overrides theme.autoContrast.
    static member inline autoContrast = Interop.mkAttr "autoContrast" true
    /// Determines whether icon color with filled variant should depend on background-color. If luminosity of the color
    /// prop is less than theme.luminosityThreshold, then theme.white will be used for text color, otherwise
    /// theme.black. Overrides theme.autoContrast.
    static member inline autoContrast'(value: bool) = Interop.mkAttr "autoContrast" value
    /// Key of theme.colors or any valid CSS color to set input background color in checked state, theme.primaryColor by
    /// default.
    static member inline color(value: string) = Interop.mkAttr "color" value
    /// Description displayed below the label.
    static member inline description(value: string) = Interop.mkAttr "description" value
    /// Description displayed below the label.
    static member inline description(value: ReactElement) = Interop.mkAttr "description" value
    /// Error message displayed below the label.
    static member inline error(value: string) = Interop.mkAttr "error" value
    /// Error message displayed below the label.
    static member inline error(value: ReactElement) = Interop.mkAttr "error" value
    /// Icon displayed when checkbox is in checked or indeterminate state.
    static member inline icon(value: (checkboxProps -> ReactElement)) = Interop.mkAttr "icon" value
    /// Key of theme.colors or any valid CSS color to set icon color, by default value depends on theme.autoContrast.
    static member inline iconColor(value: string) = Interop.mkAttr "iconColor" value
    /// Id used to connect input with the label. If not set, unique id is generated instead.
    static member inline id(value: string) = Interop.mkAttr "id" value
    /// Indeterminate state of the checkbox. If set, checked prop is ignored.
    static member inline indeterminate = Interop.mkAttr "indeterminate" true
    /// Indeterminate state of the checkbox. If set, checked prop is ignored.
    static member inline indeterminate'(value: bool) = Interop.mkAttr "indeterminate" value
    /// Content of the label associated with the checkbox.
    static member inline label(value: string) = Interop.mkAttr "label" value
    /// Content of the label associated with the checkbox.
    static member inline label(value: int) = Interop.mkAttr "label" value
    /// Content of the label associated with the checkbox.
    static member inline label(value: ReactElement) = Interop.mkAttr "label" value
    /// Key of theme.radius or any valid CSS value to set border-radius, theme.defaultRadius by default.
    static member inline radius(value: Domain.Size) = Interop.mkAttr "radius" value
    /// Key of theme.radius or any valid CSS value to set border-radius, theme.defaultRadius by default.
    static member inline radius(value: int) = Interop.mkAttr "radius" value
    /// Assigns ref of the root element.
    static member inline rootRef(value: IRefValue<HTMLDivElement>) = Interop.mkAttr "rootRef" value
    /// Controls size of the component, 'sm' by default.
    static member inline size(value: Domain.Size) = Interop.mkAttr "size" value
    /// Controls size of the component, 'sm' by default.
    static member inline size(value: string) = Interop.mkAttr "size" value
    /// Props passed down to the root element.
    static member inline wrapperProps(value: List<IReactProperty>) = Interop.mkAttr "wrapperProps" value

[<Erase>]
module checkboxGroup =
    /// Input.Label root element, 'label' by default.
    [<Erase>]
    type labelElement = Types.labelElement

[<Erase>]
type checkboxGroup =
    /// Contents of Input.Description component. If not set, description is not rendered.
    static member inline description(value: string) = Interop.mkAttr "description" value
    /// Contents of Input.Description component. If not set, description is not rendered.
    static member inline description(value: ReactElement) = Interop.mkAttr "description" value
    /// Props passed down to the Input.Description component.
    static member inline descriptionProps(value: List<IReactProperty>) = Interop.mkAttr "descriptionProps" value
    /// Contents of Input.Error component. If not set, error is not rendered.
    static member inline error(value: string) = Interop.mkAttr "error" value
    /// Contents of Input.Error component. If not set, error is not rendered.
    static member inline error(value: ReactElement) = Interop.mkAttr "error" value
    /// Props passed down to the Input.Error component.
    static member inline errorProps(value: List<IReactProperty>) = Interop.mkAttr "errorProps" value
    /// Static id used as base to generate aria- attributes, by default generates random id.
    static member inline id(value: string) = Interop.mkAttr "id" value

    /// Input container component, React.Fragment by default.
    static member inline inputContainer(value: (List<ReactElement> -> ReactElement)) =
        Interop.mkAttr "inputContainer" value

    /// Controls order of the elements, ['label', 'description', 'input', 'error'] by default.
    static member inline inputWrapperOrder(value: List<string>) =
        Interop.mkAttr "inputWrapperOrder" value

    /// Contents of Input.Label component. If not set, label is not rendered.
    static member inline label(value: string) = Interop.mkAttr "label" value
    /// Contents of Input.Label component. If not set, label is not rendered.
    static member inline label(value: ReactElement) = Interop.mkAttr "label" value
    /// Props passed down to the Input.Label component.
    static member inline labelProps(value: List<IReactProperty>) = Interop.mkAttr "labelProps" value
    /// Called with an array of selected checkboxes values when value changes.
    static member inline onChange(value: List<string> -> unit) = Interop.mkAttr "onChange" value
    /// Adds required attribute to the input and a red asterisk on the right side of label, false by default.
    static member inline required = Interop.mkAttr "required" true
    /// Adds required attribute to the input and a red asterisk on the right side of label, false by default.
    static member inline required'(value: bool) = Interop.mkAttr "required" value
    /// Controls size of the Input.Wrapper, 'sm' by default.
    static member inline size(value: Domain.Size) = Interop.mkAttr "size" value
    /// Controls size of the Input.Wrapper, 'sm' by default.
    static member inline size(value: string) = Interop.mkAttr "size" value
    /// Controlled component value.
    static member inline value(value: List<string>) = Interop.mkAttr "value" value
    /// Determines whether the required asterisk should be displayed. Overrides required prop. Does not add required
    /// attribute to the input. false by default.
    static member inline withAsterisk = Interop.mkAttr "withAsterisk" true
    /// Determines whether the required asterisk should be displayed. Overrides required prop. Does not add required
    /// attribute to the input. false by default.
    static member inline withAsterisk'(value: bool) = Interop.mkAttr "withAsterisk" value
    /// Props passed down to the root element (Input.Wrapper component).
    static member inline wrapperProps(value: List<IReactProperty>) = Interop.mkAttr "wrapperProps" value
