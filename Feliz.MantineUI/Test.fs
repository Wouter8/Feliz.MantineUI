module Test

open Feliz
open Feliz.MantineUI
open Wv8

let app =
    Man.mantineProvider [] [
        Html.div [] [
            Man.button [
                button.size.lg ;
                button.color "red"
            ] [
                Html.text "123"
            ]
        ]
    ]


let button =
    Man.button [
        button.size.xl
        button.color "red"

        prop.children [
            Html.text "Text!"
        ]
    ] []
