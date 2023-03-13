using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interprete.Source
{
    public class Scanner
    {
        private Dictionary<string, TokenType> Keywords = new Dictionary<string, TokenType>();
        private List<Token> Tokens = new List<Token>();

        public Scanner() 
        {
            Keywords.Add("class", TokenType.CLASS);
            Keywords.Add("public", TokenType.PUBLIC);
            Keywords.Add("void", TokenType.VOID);
            Keywords.Add("private", TokenType.PRIVATE);
            Keywords.Add("protected", TokenType.PROTECTED);
            Keywords.Add("internal", TokenType.INTERNAL);
            Keywords.Add("function", TokenType.FUNCTION);
            Keywords.Add("string", TokenType.STRING);
            Keywords.Add("int", TokenType.INT);
            Keywords.Add("list", TokenType.LIST);
            Keywords.Add("char", TokenType.CHAR);
            Keywords.Add("var", TokenType.VAR);
            Keywords.Add("for", TokenType.FOR);
            Keywords.Add("in", TokenType.IN);
            Keywords.Add("while", TokenType.WHILE);
            Keywords.Add("do", TokenType.DO);
            Keywords.Add("if", TokenType.IF);
            Keywords.Add("else", TokenType.ELSE);
            Keywords.Add("true", TokenType.TRUE);
            Keywords.Add("false", TokenType.FALSE);
            Keywords.Add("null", TokenType.NULL);
            Keywords.Add("return", TokenType.RETURN);
            Keywords.Add("console", TokenType.CONSOLE);
            Keywords.Add("super", TokenType.SUPER);
            Keywords.Add("this", TokenType.THIS);
            Keywords.Add("new", TokenType.NEW);

        }
        public void ScannerInput(StringBuilder input)
        {
            Console.WriteLine(input.ToString());
            Console.WriteLine(input.Length);

            // TODO: AGREGAR LOGICA PARA SCANEAR ENTRADA DE CARACTERES


            //Tokens.Add(new Token(TokenType.INT, "int", "null", 1));
            //Tokens.Add(new Token(TokenType.IF, "if", "null", 1));
            //Tokens.Add(new Token(TokenType.EOF, "", "null", 1));

            foreach (var token in Tokens)
            {
                Console.WriteLine(token.toString());
            }







            input.Clear();
        }
    }
}
