namespace Css

module Model =



    type Value = Value // TODO : add all the different possible values here as a DU

    
    type Declaration = // Property of Value // TODO : add all the different properties and there associated values as a DU + rename to Declaration
        // Color Properties
        |Color
        |Opacity
        
        // Background and Border Properties
        |Background
        |BackgroundAttachment
        |BackgroundBlendMode 
        |BackgroundColor
        |BackgroundImage
        |BackgroundPosition
        |BackgroundRepeat
        |BackgroundClip
        |BackgroundOrigin
        |BackgroundSize
        |Border
        |BorderBottom
        |BorderBottomColor
        |BorderBottomLeftRadius
        |BorderBottomRightRadius
        |BorderBottomStyle
        |BorderBottomWidth
        |BorderColor
        |BorderImage 
        |BorderImageOutset
        |BorderImageRepeat
        |BorderImageSlice
        |BorderImageSource
        |BorderImageWidth
        |BorderLeft
        |BorderLeftColor
        |BorderLeftStyle
        |BorderLeftWidth
        |BorderRadius
        |BorderRight
        |BorderRightColor
        |BorderRightStyle
        |BorderRightWidth
        |BorderStyle
        |BorderTop
        |BorderTopColor
        |BorderTopLeftRadius
        |BorderTopRightRadius
        |BorderTopStyle
        |BorderTopWidth
        |BorderWidth
        |BoxDecorationBreak
        |BoxShadow
        
        // Basic Box Properties
        |Bottom
        |Clear
        |Clip
        |Display 
        |Float 
        |Height
        |Left 
        |Margin 
        |MarginBottom 
        |MarginLeft 
        |MarginRight 
        |MarginTop 
        |MaxHeight 
        |MaxWidth 
        |MinHeight 
        |MinWidth 
        |Overflow
        |OverflowX 
        |OverflowY 
        |Padding 
        |PaddingBottom 
        |PaddingLeft 
        |PaddingRight 
        |PaddingTop 
        |Position 
        |Right 
        |Top 
        |Visibility 
        |Width
        |VerticalAlign
        |ZIndex
        
        // Flexible Box Layout Properties
        |AlignContent
        |AlignItems 
        |AlignSelf
        |Flex
        |FlexBasis
        |FlexDirection 
        |FlexFlow 
        |FlexGrow 
        |FlexShrink
        |FlexWrap 
        |JustifyContent
        |Order
        
        // Text Properties
        |HangingPunctuation 
        |Hyphens 
        |LetterSpacing 
        |LineBreak 
        |LineHeight
        |OverflowWrap 
        |TabSize 
        |TextAlign 
        |TextAlignLast 
        |TextCombineUpright
        |TextIndent 
        |TextJustify
        |TextTransform 
        |WhiteSpace 
        |WordBreak 
        |WordSpacing
        |WordWrap 
        
        // Text Properties
        |TextDecoration 
        |TextDecorationColor
        |TextDecorationLine 
        |TextDecorationStyle
        |TextShadow 
        |TextUnderlinePosition 
        
        // Font Properties
        |AtFontFace 
        |AtFontFeatureValues
        |Font
        |FontFamily 
        |FontFeatureSettings 
        |FontKerning 
        |FontLanguageOverride 
        |FontSize 
        |FontSizeAdjust 
        |FontStretch 
        |FontStyle 
        |FontSynthesis 
        |FontVariant 
        |FontVariantAlternates
        |FontVariantCaps 
        |FontVariantEastAsian
        |FontVariantLigatures 
        |FontVariantNumeric 
        |FontVariantPosition 
        |FontWeight 
        
        // Writing Modes Properties
        |Direction
        |TextOrientation 
        |UnicodeBidi 
        |WritingMode 
        
        // Table Properties
        |BorderCollapse 
        |BorderSpacing 
        |CaptionSide 
        |EmptyCells 
        |TableLayout
        
        // Lists and Counters Properties
        |CounterIncrement 
        |CounterReset 
        |ListStyle 
        |ListStyleImage 
        |ListStylePosition 
        |ListStyleType 
        
        // Animation Properties
        |AtKeyframes  
        |Animation 
        |AnimationDelay 
        |AnimationDirection 
        |AnimationDuration 
        |AnimationFillMode
        |AnimationIterationCount 
        |AnimationName 
        |AnimationPlayState 
        |AnimationTimingFunction 
        
        // Transform Properties
        |BackfaceVisibility 
        |Perspective 
        |PerspectiveOrigin 
        |Transform 
        |TransformOrigin 
        |TransformStyle 
        
        // Transitions Properties
        |Transition 
        |TransitionProperty 
        |TransitionDuration 
        |TransitionTimingFunction
        |TransitionDelay 
        
        // Basic User Interface Properties
        |BoxSizing 
        |Content 
        |Cursor 
        |ImeMode
        |NavDown
        |NavIndex
        |NavLeft 
        |NavRight
        |NavUp 
        |Outline
        |OutlineColor 
        |OutlineOffset 
        |OutlineStyle 
        |OutlineWidth 
        |Resize 
        |TextOverflow 
        
        // Multi-column Layout Properties
        |BreakAfter 
        |BreakBefore
        |Breakinside
        |ColumnCount
        |ColumnFill 
        |ColumnGap 
        |ColumnRule 
        |ColumnRuleColor 
        |ColumnRuleStyle 
        |ColumnRuleWidth 
        |ColumnSpan 
        |ColumnWidth
        |Columns 
        |Widows 
        
        // Paged Media Properties
        |Orphans 
        |PageBreakAfter 
        |PageBreakBefore 
        |PageBreakInside 
        
        //Generated Content for Paged Media
        |Marks 
        |Quotes
        
        // Filter Effects Properties
        |Filter
        
        // Image Values and Replaced Content
        |ImageOrientation
        |ImageRendering 
        |ImageResolution
        |ObjectFit 
        |ObjectPosition 
        
        // Masking Properties
        |Mask 
        |MaskType 
        
        // Speech Properties
        |Mark 
        |MarkAfter 
        |MarkBefore
        |Phonemes 
        |Rest 
        |RestAfter 
        |RestBefore
        |VoiceBalance
        |VoiceDuration 
        |VoicePitch 
        |VoicePitchRange 
        |VoiceRate 
        |VoiceStress 
        |VoiceVolume 
        
        // Marquee Properties
        |MarqueeDirection
        |MarqueePlayCount 
        |MarqueeSpeed 
        |MarqueeStyle 



    type DeclarationBlock = {FirstDeclaration : Declaration ; RestOfDeclarations : Declaration list}


    // TODO : add all the different possible element
    type Element = Element

    type BasicSelector =
        | Only of Element
        // TODO : add all the different possible PseudoClass
        | PseudoClass of Element
        // TODO : add all the different possible PseudoElement
        | PseudoElement of Element

        
    type Selector =
        |Selector of BasicSelector
        // Those are the resultant of Combinators
        |SelectorAdjacentSibling of BasicSelector*BasicSelector
        |SelectorGeneralSibling of BasicSelector*BasicSelector
        |SelectorChild of BasicSelector*BasicSelector
        |SelectorDescendant of BasicSelector*BasicSelector

    type SelectorGroup = {FirstSelector : Selector; RestOfSelectors: Selector list}


    type RuleSet = {Selectors : SelectorGroup ; Style : DeclarationBlock}

    