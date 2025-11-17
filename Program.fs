open Ansi
open AsciiArt

open System.Timers





////////////////////////////////////////////////////////////////////////////////
//
// MAIN
//
////////////////////////////////////////////////////////////////////////////////
[<EntryPoint>]
let main argv =
    //printf "Hello, shitlords!\n"

    //printf "\nForeground Color Test:\n"
    //printf $"{f_red}This text should be red.{d_reset}\n"
    //printf $"{f_blue}This text should be blue.{d_reset}\n"
    //printf $"{f_green}This text should be green.{d_reset}\n"

    //printf "\n\nWell done!\n\n"
    //printf "Background Color Test:\n"
    //printf $"{b_red}The background should be red.{d_reset}\n"
    //printf $"{b_green}The background should be green.{d_reset}\n"
    //printf $"{b_blue}The background should be blue.{d_reset}\n"

    //printf "\n\nWell done!\n\n"
    //printf "Combo Color Test:\n"
    //printf $"{b_red}{f_black}The background should be red and text black.{d_reset}\n"
    //printf $"{b_green}{f_black}The background should be green and text black.{d_reset}\n"
    //printf $"{b_blue}{f_black}The background should be blue and text black.{d_reset}\n"

    //printf "\n\nWell done!\n\n"
    //printf "Coordinate Placement Test:\n"
    //printf $"{aes_generate_coordinate_string 3 30}This text should be at 3x30.{aes_generate_coordinate_string 27 1}{d_reset}\n"

    //printf "\n\nWell done!\n\n"
    //printf "Decorator Test:\n"
    //printf $"{d_all}This text should be decorated to ALMOST high hell.{d_reset}\n"

    //printf $"{aes_generate_coordinate_string 4 30}{f_white}{b_red}{d_all}GIGA DECORATED TEXT!{d_reset}{aes_generate_coordinate_string 27 1}\n"

    //// ATSTRINGPREFIX TEST
    //let a_prefix = [
    //    fun () -> aes_generate_coordinate_string 5 30
    //    fun () -> d_all
    //    fun () -> f_blue
    //    fun () -> b_white
    //]
    //printf $"{aes_generate_atprefix_string a_prefix}ULTRA DECORATION!{d_reset}{aes_generate_coordinate_string 30 1}"

    //// ATSTRING TEST; ALSO TESTS ANONYMOUS BINDING TO THE FUNCTION PARAMETER
    //let a_atstring = fun () -> aes_generate_atprefix_string [
    //    fun () -> aes_generate_coordinate_string 5 30
    //    fun () -> d_all
    //    fun () -> f_blue
    //    fun () -> b_white
    //]
    //let b_atstring = aes_generate_atstring a_atstring "OMAE WA MOU SHINDIERU!" true
    //printf $"{b_atstring}{aes_generate_coordinate_string 30 1}"

    //printf $"{aes_generate_coordinate_string 7 30}Hi \x1b#6DiScOrD{d_reset}{aes_generate_coordinate_string 40 1}"

    //printf $"{colored_rocket}"

    //printf $"{colored_tree}"

    //printf $"{colored_bear}"

    //printf $"{ms_square_cycle3}"

    0
