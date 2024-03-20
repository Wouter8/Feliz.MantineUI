module Feliz.MantineUI.Props.DatePickerProps

open System
open Browser.Types
open Fable.Core
open Feliz
open Feliz.MantineUI

[<Erase>]
module datePicker =
    [<Erase>]
    type ariaLabels =
        static member inline monthLevelControl(value: string) =
            unbox ("ariaLabels.monthLevelControl", value)

        static member inline yearLevelControl(value: string) =
            unbox ("ariaLabels.yearLevelControl", value)

        static member inline nextMonth(value: string) = unbox ("ariaLabels.nextMonth", value)

        static member inline previousMonth(value: string) =
            unbox ("ariaLabels.previousMonth", value)

        static member inline nextYear(value: string) = unbox ("ariaLabels.nextYear", value)

        static member inline previousYear(value: string) =
            unbox ("ariaLabels.previousYear", value)

        static member inline nextDecade(value: string) = unbox ("ariaLabels.nextDecade", value)

        static member inline previousDecade(value: string) =
            unbox ("ariaLabels.previousDecade", value)

    [<Erase>]
    type defaultLevel =
        static member inline month = Interop.mkAttr "defaultLevel" "month"
        static member inline year = Interop.mkAttr "defaultLevel" "year"
        static member inline decade = Interop.mkAttr "defaultLevel" "decade"

    [<Erase>]
    type level =
        static member inline month = Interop.mkAttr "level" "month"
        static member inline year = Interop.mkAttr "level" "year"
        static member inline decade = Interop.mkAttr "level" "decade"

    [<Erase>]
    type maxLevel =
        static member inline month = Interop.mkAttr "maxLevel" "month"
        static member inline year = Interop.mkAttr "maxLevel" "year"
        static member inline decade = Interop.mkAttr "maxLevel" "decade"

    [<Erase>]
    type type' =
        static member inline default' = Interop.mkAttr "type" "default"
        static member inline multiple = Interop.mkAttr "type" "multiple"
        static member inline range = Interop.mkAttr "type" "range"

[<Erase>]
type datePicker =
    static member inline allowDeselect = Interop.mkAttr "allowDeselect" true
    static member inline allowDeselect'(value: bool) = Interop.mkAttr "allowDeselect" value
    static member inline allowSingleDateInRange = Interop.mkAttr "allowSingleDateInRange" true

    static member inline allowSingleDateInRange'(value: bool) =
        Interop.mkAttr "allowSingleDateInRange" value

    static member inline columnsToScroll(value: int) = Interop.mkAttr "columnsToScroll" value
    static member inline value(value: DateTime) = Interop.mkAttr "value" value
    static member inline value(value: DateOnly) = Interop.mkAttr "value" value
    static member inline value(value: DateTime option) = Interop.mkAttr "value" value
    static member inline value(value: DateOnly option) = Interop.mkAttr "value" value
    static member inline value(value: DateTime * DateTime) = Interop.mkAttr "value" value
    static member inline value(value: DateOnly * DateOnly) = Interop.mkAttr "value" value
    static member inline value(value: DateTime list) = Interop.mkAttr "value" value

    static member inline decadeLabelFormat(value: string) =
        Interop.mkAttr "decadeLabelFormat" value

    static member inline decadeLabelFormat(value: (DateTime * DateTime -> ReactElement)) =
        Interop.mkAttr "decadeLabelFormat" value

    static member inline defaultValue(value: DateTime) = Interop.mkAttr "defaultDate" value
    static member inline defaultValue(value: DateOnly) = Interop.mkAttr "defaultDate" value
    static member inline defaultValue(value: DateTime option) = Interop.mkAttr "defaultValue" value
    static member inline defaultValue(value: DateOnly option) = Interop.mkAttr "defaultValue" value
    static member inline defaultValue(value: DateTime * DateTime) = Interop.mkAttr "defaultValue" value
    static member inline defaultValue(value: DateOnly option * DateOnly option) = Interop.mkAttr "defaultValue" value
    static member inline defaultValue(value: DateTime list) = Interop.mkAttr "defaultValue" value
    static member inline defaultValue(value: DateOnly list) = Interop.mkAttr "defaultValue" value
    static member inline excludeDate(value: DateTime -> bool) = Interop.mkAttr "excludeDate" value
    static member inline excludeDate(value: DateOnly -> bool) = Interop.mkAttr "excludeDate" value
    static member inline firstDayOfWeek(value: int) = Interop.mkAttr "firstDayOfWeek" value
    static member inline getDayAriaLabel(value: DateTime -> string) = Interop.mkAttr "getDayAriaLabel" value
    static member inline getDayAriaLabel(value: DateOnly -> string) = Interop.mkAttr "getDayAriaLabel" value
    // static member inline getDayProps
    // static member inline getMonthControlProps
    // static member inline getYearControlProps
    static member inline hasNextLevel(value: bool) = Interop.mkAttr "hasNextLevel" value
    static member inline hideOutsideDates = Interop.mkAttr "hideOutsideDates" true
    static member inline hideOutsideDates'(value: bool) = Interop.mkAttr "hideOutsideDates" value
    static member inline hideWeekdays = Interop.mkAttr "hideWeekdays" true
    static member inline hideWeekdays'(value: bool) = Interop.mkAttr "hideWeekdays" value
    static member inline locale(value: string) = Interop.mkAttr "locale" value
    static member inline maxDate(value: DateTime) = Interop.mkAttr "maxDate" value
    static member inline maxDate(value: DateOnly) = Interop.mkAttr "maxDate" value
    static member inline minDate(value: DateTime) = Interop.mkAttr "minDate" value
    static member inline minDate(value: DateOnly) = Interop.mkAttr "minDate" value
    static member inline monthLabelFormat(value: string) = Interop.mkAttr "monthLabelFormat" value
    static member inline monthLabelFormat(value: (DateTime -> ReactElement)) = Interop.mkAttr "monthLabelFormat" value
    static member inline monthLabelFormat(value: (DateOnly -> ReactElement)) = Interop.mkAttr "monthLabelFormat" value
    static member inline monthsListFormat(value: string) = Interop.mkAttr "monthsListFormat" value
    static member inline nextIcon(value: ReactElement) = Interop.mkAttr "nextIcon" value
    static member inline nextLabel(value: string) = Interop.mkAttr "nextLabel" value
    static member inline numberOfColumns(value: int) = Interop.mkAttr "numberOfColumns" value
    static member inline onChange(value: List<DateTime> -> unit) = Interop.mkAttr "onChange" value
    static member inline onChange(value: List<DateOnly> -> unit) = Interop.mkAttr "onChange" value
    static member inline onChange(value: DateTime * DateTime -> unit) = Interop.mkAttr "onChange" value
    static member inline onChange(value: DateOnly * DateOnly -> unit) = Interop.mkAttr "onChange" value
    static member inline onChange(value: DateTime option -> unit) = Interop.mkAttr "onChange" value
    static member inline onChange(value: DateOnly option -> unit) = Interop.mkAttr "onChange" value
    static member inline onDateChange(value: DateTime -> unit) = Interop.mkAttr "onDateChange" value
    static member inline onDateChange(value: DateOnly -> unit) = Interop.mkAttr "onDateChange" value
    static member inline onLevelChange(value: string -> unit) = Interop.mkAttr "onLevelChange" value

    static member inline onMonthMouseEnter(value: MouseEvent * DateTime -> unit) =
        Interop.mkAttr "onMonthMouseEnter" value

    static member inline onMonthMouseEnter(value: MouseEvent * DateOnly -> unit) =
        Interop.mkAttr "onMonthMouseEnter" value

    static member inline onMonthSelect(value: DateTime -> unit) = Interop.mkAttr "onMonthSelect" value
    static member inline onMonthSelect(value: DateOnly -> unit) = Interop.mkAttr "onMonthSelect" value
    static member inline onNextDecade(value: DateTime -> unit) = Interop.mkAttr "onNextDecade" value
    static member inline onNextDecade(value: DateOnly -> unit) = Interop.mkAttr "onNextDecade" value
    static member inline onNextMonth(value: DateTime -> unit) = Interop.mkAttr "onNextMonth" value
    static member inline onNextMonth(value: DateOnly -> unit) = Interop.mkAttr "onNextMonth" value
    static member inline onNextYear(value: DateTime -> unit) = Interop.mkAttr "onNextYear" value
    static member inline onNextYear(value: DateOnly -> unit) = Interop.mkAttr "onNextYear" value
    static member inline onPreviousDecade(value: DateTime -> unit) = Interop.mkAttr "onPreviousDecade" value
    static member inline onPreviousDecade(value: DateOnly -> unit) = Interop.mkAttr "onPreviousDecade" value
    static member inline onPreviousMonth(value: DateTime -> unit) = Interop.mkAttr "onPreviousMonth" value
    static member inline onPreviousMonth(value: DateOnly -> unit) = Interop.mkAttr "onPreviousMonth" value
    static member inline onPreviousYear(value: DateTime -> unit) = Interop.mkAttr "onPreviousYear" value
    static member inline onPreviousYear(value: DateOnly -> unit) = Interop.mkAttr "onPreviousYear" value

    static member inline onYearMouseEnter(value: MouseEvent * DateTime -> unit) =
        Interop.mkAttr "onYearMouseEnter" value

    static member inline onYearMouseEnter(value: MouseEvent * DateOnly -> unit) =
        Interop.mkAttr "onYearMouseEnter" value

    static member inline onYearSelect(value: DateTime -> unit) = Interop.mkAttr "onYearSelect" value
    static member inline onYearSelect(value: DateOnly -> unit) = Interop.mkAttr "onYearSelect" value
    static member inline previousIcon(value: ReactElement) = Interop.mkAttr "previousIcon" value
    static member inline previousLabel(value: string) = Interop.mkAttr "previousLabel" value
    static member inline renderDay(value: DateTime -> ReactElement) = Interop.mkAttr "renderDay" value
    static member inline renderDay(value: DateOnly -> ReactElement) = Interop.mkAttr "renderDay" value
    static member inline size(value: Domain.Size) = Interop.mkAttr "size" value
    static member inline size(value: string) = Interop.mkAttr "size" value
    static member inline weekdayFormat(value: string) = Interop.mkAttr "weekdayFormat" value
    static member inline weekdayFormat(value: (DateTime -> ReactElement)) = Interop.mkAttr "weekdayFormat" value
    static member inline weekdayFormat(value: (DateOnly -> ReactElement)) = Interop.mkAttr "weekdayFormat" value
    static member inline weekendDays(value: int list) = Interop.mkAttr "weekendDays" value
    static member inline withCellSpacing(value: bool) = Interop.mkAttr "withCellSpacing" value
    static member inline yearLabelFormat(value: string) = Interop.mkAttr "yearLabelFormat" value
    static member inline yearLabelFormat(value: (DateTime -> ReactElement)) = Interop.mkAttr "yearLabelFormat" value
    static member inline yearLabelFormat(value: (DateOnly -> ReactElement)) = Interop.mkAttr "yearLabelFormat" value
    static member inline yearsListFormat(value: string) = Interop.mkAttr "yearsListFormat" value
