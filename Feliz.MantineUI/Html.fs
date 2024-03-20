namespace Wv8

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz


[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module HtmlHelper =
    [<Emit("$0 === undefined")>]
    let private isUndefined x = jsNative

    let fromFlatEntries (kvs: seq<string * obj>) : obj =
        let rec setProperty (target: obj) (key: string) (value: obj) =
            match key.IndexOf '.' with
            | -1 -> target?(key) <- value
            | sepIdx ->
                let topKey = key.Substring(0, sepIdx)
                let nestedKey = key.Substring(sepIdx + 1)

                if isUndefined target?(topKey) then
                    target?(topKey) <- obj ()

                setProperty target?(topKey) nestedKey value

        let target = obj ()

        for (key, value) in kvs do
            setProperty target key value

        target

    let combineProps props (children: List<ReactElement>) =
        let combined = List.append props [ prop.children children ]

        !!combined |> fromFlatEntries

    let createElem tag props children =
        Interop.reactElement tag (combineProps props children)

    let createElemWithoutChildren tag props =
        Interop.reactElement tag (!!props |> fromFlatEntries)

type Html =
    static member inline none: ReactElement = unbox null
    static member inline a = createElem "a"
    static member inline abbr = createElem "abbr"
    static member inline address = createElem "address"
    static member inline anchor = createElem "anchor"
    static member inline animate = createElem "animate"
    static member inline animateMotion = createElem "animateMotion"
    static member inline animateTransform = createElem "animateTransform"
    static member inline area = createElem "area"
    static member inline article = createElem "article"
    static member inline aside = createElem "aside"
    static member inline audio = createElem "audio"
    static member inline b = createElem "b"
    static member inline base' = createElem "base'"
    static member inline bdi = createElem "bdi"
    static member inline bdo = createElem "bdo"
    static member inline blockquote = createElem "blockquote"
    static member inline body = createElem "body"
    static member inline br = createElem "br"
    static member inline button = createElem "button"
    static member inline canvas = createElem "canvas"
    static member inline caption = createElem "caption"
    static member inline cite = createElem "cite"
    static member inline circle = createElem "circle"
    static member inline clipPath = createElem "clipPath"
    static member inline code = createElem "code"
    static member inline col = createElem "col"
    static member inline colgroup = createElem "colgroup"
    static member inline content = createElem "content"
    static member inline data = createElem "data"
    static member inline datalist = createElem "datalist"
    static member inline dd = createElem "dd"
    static member inline defs = createElem "defs"
    static member inline del = createElem "del"
    static member inline details = createElem "details"
    static member inline desc = createElem "desc"
    static member inline dfn = createElem "dfn"
    static member inline dialog = createElem "dialog"
    static member inline div = createElem "div"
    static member inline dl = createElem "dl"
    static member inline dt = createElem "dt"
    static member inline ellipse = createElem "ellipse"
    static member inline em = createElem "em"
    static member inline embed = createElem "embed"
    static member inline fieldSet = createElem "fieldSet"
    static member inline figcaption = createElem "figcaption"
    static member inline figure = createElem "figure"
    static member inline filter = createElem "filter"
    static member inline footer = createElem "footer"
    static member inline form = createElem "form"
    static member inline g = createElem "g"
    static member inline h1 = createElem "h1"
    static member inline h2 = createElem "h2"
    static member inline h3 = createElem "h3"
    static member inline h4 = createElem "h4"
    static member inline h5 = createElem "h5"
    static member inline h6 = createElem "h6"
    static member inline head = createElem "head"
    static member inline header = createElem "header"
    static member inline hr = createElemWithoutChildren "hr"
    static member inline html = createElem "html"
    static member inline i = createElem "i"
    static member inline iframe = createElem "iframe"
    static member inline img = createElem "img"
    static member inline image = createElem "image"
    static member inline input = createElemWithoutChildren "input"
    static member inline ins = createElem "ins"
    static member inline kbd = createElem "kbd"
    static member inline label = createElem "label"
    static member inline legend = createElem "legend"
    static member inline li = createElem "li"
    static member inline line = createElem "line"
    static member inline linearGradient = createElem "linearGradient"
    static member inline link = createElem "link"
    static member inline listItem = createElem "listItem"
    static member inline main = createElem "main"
    static member inline map = createElem "map"
    static member inline mark = createElem "mark"
    static member inline marker = createElem "marker"
    static member inline mask = createElem "mask"
    static member inline meta = createElem "meta"
    static member inline metadata = createElem "metadata"
    static member inline meter = createElem "meter"
    static member inline mpath = createElem "mpath"
    static member inline nav = createElem "nav"
    static member inline noscript = createElem "noscript"
    static member inline object = createElem "object"
    static member inline ol = createElem "ol"
    static member inline option = createElem "option"
    static member inline optgroup = createElem "optgroup"
    static member inline orderedList = createElem "orderedList"
    static member inline output = createElem "output"
    static member inline p = createElem "p"
    static member inline paragraph = createElem "paragraph"
    static member inline param = createElem "param"
    static member inline path = createElem "path"
    static member inline pattern = createElem "pattern"
    static member inline picture = createElem "picture"
    static member inline polygon = createElem "polygon"
    static member inline polyline = createElem "polyline"
    static member inline pre = createElem "pre"
    static member inline progress = createElem "progress"
    static member inline q = createElem "q"
    static member inline radialGradient = createElem "radialGradient"
    static member inline rb = createElem "rb"
    static member inline rect = createElem "rect"
    static member inline rp = createElem "rp"
    static member inline rt = createElem "rt"
    static member inline rtc = createElem "rtc"
    static member inline ruby = createElem "ruby"
    static member inline s = createElem "s"
    static member inline samp = createElem "samp"
    static member inline script = createElem "script"
    static member inline section = createElem "section"
    static member inline select = createElem "select"
    static member inline set = createElem "set"
    static member inline small = createElem "small"
    static member inline source = createElem "source"
    static member inline span = createElem "span"
    static member inline stop = createElem "stop"
    static member inline strong = createElem "strong"
    static member inline style = createElem "style"
    static member inline sub = createElem "sub"
    static member inline summary = createElem "summary"
    static member inline sup = createElem "sup"
    static member inline svg = createElem "svg"
    static member inline switch = createElem "switch"
    static member inline symbol = createElem "symbol"
    static member inline table = createElem "table"
    static member inline tableBody = createElem "tableBody"
    static member inline tableCell = createElem "tableCell"
    static member inline tableHeader = createElem "tableHeader"
    static member inline tableRow = createElem "tableRow"
    static member inline tbody = createElem "tbody"
    static member inline td = createElem "td"
    static member inline template = createElem "template"
    static member inline text(value: float) : ReactElement = unbox value
    static member inline text(value: int) : ReactElement = unbox value
    static member inline text(value: string) : ReactElement = unbox value
    static member inline text(value: System.Guid) : ReactElement = unbox (string value)
    static member inline textf = createElem "textf"
    static member inline textarea = createElem "textarea"
    static member inline textPath = createElem "textPath"
    static member inline tfoot = createElem "tfoot"
    static member inline th = createElem "th"
    static member inline thead = createElem "thead"
    static member inline time = createElem "time"
    static member inline title = createElem "title"
    static member inline tr = createElem "tr"
    static member inline track = createElem "track"
    static member inline tspan = createElem "tspan"
    static member inline u = createElem "u"
    static member inline ul = createElem "ul"
    static member inline unorderedList = createElem "unorderedList"
    static member inline use' = createElem "use'"
    static member inline var = createElem "var"
    static member inline video = createElem "video"
    static member inline view = createElem "view"
    static member inline wbr = createElem "wbr"

[<Erase>]
type attr =
    static member inline none = prop.className []
