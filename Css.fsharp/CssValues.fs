namespace Css
open FSharp.DependentTypes.Numbers
open FSharp.DependentTypes.Strings

module Values =

    type R = R of byte
    type G = G of byte
    type B = B of byte

    type Hue = BoundedInt32<0,360>
    type Saturity = BoundedInt32<0,100>
    
    type Color = Color

    type Colors = Colors