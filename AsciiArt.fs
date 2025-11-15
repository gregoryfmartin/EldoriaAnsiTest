module AsciiArt

open Ansi





let single_square = "█"
let ms_square = """
████████████████████
████████████████████
████████████████████
████████████████████
████████████████████
████████████████████
████████████████████
"""
let rocket = """
       /\
      /  \
     /____\
     |    |
     |NASA|
     |    |
    /| |  |\
   /_|_|__|_\
     /_\/_\
    /_/  \_\
"""
let colored_rocket = $"""
       {f_white}/\
      /  \
     /____\
     |    |
     |{f_blue}NASA{f_white}|
     |    |
    /| {f_red}|{f_white}  |\
   /_|_{f_red}|{f_white}__|_\
     /_\/_\
    /_/  \_\{deco_reset}
"""
let owl = """
   ,_,  
  (O,O) 
  (   ) 
   " "  
"""
let cat = """
 /\_/\  
( o.o ) 
 > ^ <  
"""
let dog = """
  / \__
 (    @\___
 /         O
 /   (_____/
 /_____/
"""
let fish = """
   ><(((('> 
"""
let heart = """
  __  __  
 /  \/  \ 
 \      / 
  \    /  
   \  /   
    \/    
"""
let smiley_face = """
   _____  
  /     \ 
 |  o o  |
 |   ^   |
 |  \_/  |
  \_____/ 
"""
let tree = """
    /\
   /  \
  /++++\
 /  ()  \
/________\
    ||    
    ||    
    ||
"""
let colored_tree = $"""{f_forest_green}
    /\
   /  \
  /{f_red}+{f_green}+{f_blue}+{f_red}+{f_forest_green}\
 /  {f_yellow}(){f_forest_green}  \
/________\{f_brown_dark}
    ||    
    ||    
    ||{deco_reset}
"""
let colored_bear = $"""{f_brown_dark}
  _      _                        
 : `.--.' ;              _....,_  
 .'      `.      _..--'"'       `-._
:          :_.-'"                  .`.
:  {f_white}6    6{f_brown_dark}  :                     :  '.;
:          :                      `..';
`: .----. :'                          ;
  `._{f_red}Y{f_brown_dark} _.'               '           ;
    '{f_red}U{f_brown_dark}'      .'          `.         ; 
       `:   ;`-..___       `.     .'`.
jgs    _:   :  :    ```"''"'``.    `.  `.
     .'     ;..'            .'       `.'`
    `.......'              `........-'`
{deco_reset}"""