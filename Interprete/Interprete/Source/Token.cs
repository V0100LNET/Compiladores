﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interprete.Source
{
    public class Token
    {
        private TokenType _type;
        private string _lexeme;
        private object _literal;
        private int _line;

        public Token(TokenType type, string lexeme, Object literal, int line) 
        {
            _type = type;
            _lexeme = lexeme;
            _literal = literal;
            _line = line;
        }

        public string toString()
        {
            return _type + " " + _lexeme + " " + _literal;
        }
    }
}
