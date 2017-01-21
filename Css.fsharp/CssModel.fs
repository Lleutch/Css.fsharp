namespace Css

module Model =

    type Value = Value // TODO : add all the different possible values here as a DU

    type Declaration = Property of Value // TODO : add all the different properties and there associated values as a DU + rename to Declaration

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






