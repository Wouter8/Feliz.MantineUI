module Feliz.MantineUI.Props.DateProviderProps

open Fable.Core

[<Erase>]
module datesProvider =
    [<Erase>]
    type settings =
        static member inline locale(value: string) = unbox ("settings.locale", value)
        static member inline timezone(value: string) = unbox ("settings.timezone", value)

        static member inline firstDayOfWeek(value: int) =
            unbox ("settings.firstDayOfWeek", value)

        static member inline weekendDays(value: int[]) = unbox ("settings.weekendDays", value)

        static member inline labelSeparator(value: string) =
            unbox ("settings.labelSeparator", value)
