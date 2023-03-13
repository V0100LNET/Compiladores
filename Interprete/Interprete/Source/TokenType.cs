using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interprete.Source
{
    public enum TokenType
    {
        //KEYWORDS DE LOS METODOS
        CLASS,
        PUBLIC,
        VOID,
        PRIVATE,
        PROTECTED,
        INTERNAL,
        FUNCTION,
        //KEYWORDS DE LOS TIPOS DE VARIABLES
        STRING,
        INT,
        LIST,
        CHAR,
        VAR,
        //KEYWORDS DE BUCLES Y CONDICIONALES
        FOR,
        IN,
        WHILE,
        DO, 
        IF,
        ELSE,
        //VALIDACIONES 
        TRUE,
        FALSE,
        NULL,
        OPENING_ANGLE_BRACKET,    // <
        CLOSING_ANGLE_BRACKET,    // >
        VERTICAL_BAR,             // OR 
        AMPERSAND,                // and 
        //SIGNOS DEL LENGUAJE
        EXCLAMATION_MARK,
        PERCENT_SIGN,
        ASTERISK,
        LEST_PARENTHESIS,         // (
        RIGHT_PARENTHESIS,        // )
        PLUS_SIGN,
        COMMA,    
        PERIOD,                   // . 
        BACKLASH,                 // \
        MINUS_SIGN,               // -
        EQUAL_SIGN,
        QUESTION_MARK,          
        LEFT_BRACE,              // {
        RIGHT_BRACE,             // }
        LEFT_BRACKET,            // [
        RIGHT_BRACKET,           // ]
        COLON,                   // :
        QUOTATION_MARK,          // "
        SEMICOLON,               // ;
        //OTHERS
        RETURN,
        CONSOLE,
        WRITE_LINE,
        READ_LINE,
        SUPER,
        THIS,
        NEW,
        EOF
    }
}
