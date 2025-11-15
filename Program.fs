open Colors
open Ansi





////////////////////////////////////////////////////////////////////////////////
//
// MAIN
//
////////////////////////////////////////////////////////////////////////////////
[<EntryPoint>]
let main argv =
    printf "Hello, shitlords!\n"

    printf "\nForeground Color Test:\n"
    printf $"{aes_generate_fg_string cc_red}This text should be red.{aes_decoration_reset}\n"
    printf $"{aes_generate_fg_string cc_blue}This text should be blue.{aes_decoration_reset}\n"
    printf $"{aes_generate_fg_string cc_green}This text should be green.{aes_decoration_reset}\n"

    printf "\n\nWell done!\n\n"
    printf "Background Color Test:\n"
    printf $"{aes_generate_bg_string cc_red}The background should be red.{aes_decoration_reset}\n"
    printf $"{aes_generate_bg_string cc_green}The background should be green.{aes_decoration_reset}\n"
    printf $"{aes_generate_bg_string cc_blue}The background should be blue.{aes_decoration_reset}\n"

    printf "\n\nWell done!\n\n"
    printf "Combo Color Test:\n"
    printf $"{aes_generate_bg_string cc_red}{aes_generate_fg_string cc_black}The background should be red and text black.{aes_decoration_reset}\n"
    printf $"{aes_generate_bg_string cc_green}{aes_generate_fg_string cc_black}The background should be green and text black.{aes_decoration_reset}\n"
    printf $"{aes_generate_bg_string cc_blue}{aes_generate_fg_string cc_black}The background should be blue and text black.{aes_decoration_reset}\n"

    printf "\n\nWell done!\n\n"
    printf "Coordinate Placement Test:\n"
    printf $"{aes_generate_coordinate_string 3 30}This text should be at 3x30.{aes_generate_coordinate_string 27 1}{aes_decoration_reset}\n"

    printf "\n\nWell done!\n\n"
    printf "Decorator Test:\n"
    printf $"{aes_generate_decorator_string true true true true}This text should be decorated to ALMOST high hell.{aes_decoration_reset}\n"

    printf $"{aes_generate_coordinate_string 4 30}{aes_generate_fg_string cc_white}{aes_generate_bg_string cc_red}{aes_generate_decorator_string true true true true}GIGA DECORATED TEXT!{aes_decoration_reset}{aes_generate_coordinate_string 27 1}\n"

    // ATSTRINGPREFIX TEST
    let a_prefix = [
        fun () -> aes_generate_coordinate_string 5 30
        fun () -> aes_generate_decorator_string true true true true
        fun () -> aes_generate_fg_string cc_blue
        fun () -> aes_generate_bg_string cc_white
    ]
    printf $"{aes_generate_atprefix_string a_prefix}ULTRA DECORATION!{aes_decoration_reset}{aes_generate_coordinate_string 30 1}"

    // ATSTRING TEST; ALSO TESTS ANONYMOUS BINDING TO THE FUNCTION PARAMETER
    let a_atstring = fun () -> aes_generate_atprefix_string [
        fun () -> aes_generate_coordinate_string 5 30
        fun () -> aes_generate_decorator_string true true true true
        fun () -> aes_generate_fg_string cc_blue
        fun () -> aes_generate_bg_string cc_white
    ]
    let b_atstring = aes_generate_atstring a_atstring "OMAE WA MOU SHINDIERU!" true
    printf $"{b_atstring}{aes_generate_coordinate_string 30 1}"

    printf $"{aes_generate_coordinate_string 7 30}Hi \x1b#6DiScOrD{aes_decoration_reset}{aes_generate_coordinate_string 40 1}"

    0
