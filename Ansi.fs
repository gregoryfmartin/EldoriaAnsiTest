module Ansi






///////////////////////////////////////////////////////////////////////////////
//
// DEC ANSI ESCAPE SEQUENCES
//
///////////////////////////////////////////////////////////////////////////////

let aes_esi                      = "\x1b["
let aes_foreground_color_prefx   = $"{aes_esi}38;2;"
let aes_background_color_prefx   = $"{aes_esi}48;2;"
let aes_decoration_blink         = $"{aes_esi}5m"
let aes_decoration_italic        = $"{aes_esi}3m"
let aes_decoration_underline     = $"{aes_esi}4m"
let aes_decoration_strikethrough = $"{aes_esi}9m"
let aes_decoration_reset         = $"{aes_esi}0m"
let aes_cursor_hide              = $"{aes_esi}?25l"
let aes_cursor_show              = $"{aes_esi}?25h"

let aes_generate_fg_string (color_data: int list) =
    $"{aes_foreground_color_prefx}{color_data.Item 0};{color_data.Item 1};{color_data.Item 2}m"

let aes_generate_bg_string (color_data: int list) =
    $"{aes_background_color_prefx}{color_data.Item 0};{color_data.Item 1};{color_data.Item 2}m"

let aes_generate_fg_none =
    ""

let aes_generate_bg_none =
    ""

let aes_generate_coordinate_string (row: int) (col: int) =
    $"{aes_esi}{row};{col}H"

let aes_generate_coordinate_none =
    ""

let aes_generate_decorator_string (blink: bool) (italic: bool) (underline: bool) (strikethrough: bool) =
    let mutable decorator_string = ""

    if blink then
        decorator_string <- decorator_string + aes_decoration_blink
    if italic then
        decorator_string <- decorator_string + aes_decoration_italic
    if underline then
        decorator_string <- decorator_string + aes_decoration_underline
    if strikethrough then
        decorator_string <- decorator_string + aes_decoration_strikethrough

    decorator_string

let aes_generate_decorator_none =
    ""

let aes_generate_atprefix_string (components: (unit -> string) list) =
    components
    |> List.map (fun f -> f())
    |> String.concat ""

let aes_generate_atprefix_none =
    ""

let aes_generate_atstring (prefix: (unit -> string)) (user_data: string) (use_reset: bool) =
    let prefix_str = prefix()
    let reset = if use_reset then aes_decoration_reset else ""

    $"{prefix_str}{user_data}{reset}"

let aes_generate_atstring_none =
    ""

let aes_generate_atstring_composite (atstrings: (unit -> string) list) =
    atstrings
    |> List.map (fun f -> f())
    |> String.concat ""