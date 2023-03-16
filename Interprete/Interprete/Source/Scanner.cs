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
        private int indexAux = 0;

        public Scanner() 
        {
            Keywords.Add("class", TokenType.CLASS);
            Keywords.Add("else", TokenType.ELSE);
            Keywords.Add("false", TokenType.FALSE);
            Keywords.Add("for", TokenType.FOR);
            Keywords.Add("function", TokenType.FUNCTION);
            Keywords.Add("if", TokenType.IF);
            Keywords.Add("null", TokenType.NULL);
            Keywords.Add("print", TokenType.PRINT);
            Keywords.Add("return", TokenType.RETURN);
            Keywords.Add("super", TokenType.SUPER);
            Keywords.Add("this", TokenType.THIS);
            Keywords.Add("true", TokenType.TRUE);
            Keywords.Add("var", TokenType.VAR);
            Keywords.Add("while", TokenType.WHILE);
            Keywords.Add("and", TokenType.AND);
            Keywords.Add("or", TokenType.OR);
        }

        private void SetIndexAux(int numberIndex)
        {
            indexAux = numberIndex;
        }

        private int GetIndexAux()
        {
            return indexAux;
        }

        private bool IsLetter(char letter)
        {
            return char.IsLetter(letter);
        }

        private bool IsNumber(char letter)
        {
            return char.IsNumber(letter);
        }

        private bool IsKeyword(string word)
        {
            return Keywords.ContainsKey(word);
        }

        private void AssignTokenSymbols(char symbol)
        {

        }

        private void ValidateCharacters(char[] charArray, int index, char symbol)
        {

            int startIndex = GetIndexAux();
            int endIndex = index - GetIndexAux();
            
            string charactersToString = new string(charArray);
            string word = charactersToString.Substring(startIndex, endIndex);


            if (IsKeyword(word))
            {
                switch (word)
                {
                    case "class":
                        Tokens.Add(new Token(TokenType.CLASS, word, "null", 1));
                        break;
                    case "else":
                        Tokens.Add(new Token(TokenType.ELSE, word, "null", 1));
                        break;
                    case "false":
                        Tokens.Add(new Token(TokenType.FALSE, word, "false", 1));
                        break;
                    case "for":
                        Tokens.Add(new Token(TokenType.FOR, word, "null", 1));
                        break;
                    case "function":
                        Tokens.Add(new Token(TokenType.FUNCTION, word, "null", 1));
                        break;
                    case "if":
                        Tokens.Add(new Token(TokenType.IF, word, "null", 1));
                        break;
                    case "null":
                        Tokens.Add(new Token(TokenType.NULL, word, "null", 1));
                        break;
                    case "print":
                        Tokens.Add(new Token(TokenType.PRINT, word, "lo que tenga dentro del print", 1));
                        break;
                    case "return":
                        Tokens.Add(new Token(TokenType.RETURN, word, "null", 1));
                        break;
                    case "super":
                        Tokens.Add(new Token(TokenType.SUPER, word, "null", 1));
                        break;
                    case "this":
                        Tokens.Add(new Token(TokenType.THIS, word, "null", 1));
                        break;
                    case "true":
                        Tokens.Add(new Token(TokenType.TRUE, word, "null", 1));
                        break;
                    case "var":
                        Tokens.Add(new Token(TokenType.VAR, word, "null", 1));
                        break;
                    case "while":
                        Tokens.Add(new Token(TokenType.WHILE, word, "null", 1));
                        break;
                    case "and":
                        Tokens.Add(new Token(TokenType.AND, word, "null", 1));
                        break;
                    case "or":
                        Tokens.Add(new Token(TokenType.OR, word, "null", 1));
                        break;
                    default: break;
                }
            }

            //if (!IsKeyword(word))
            //{
            //    Console.WriteLine("fff");
            //}

            //Console.WriteLine(symbol);

            SetIndexAux(index + 1);
        }

        public void ScannerInput(StringBuilder input)
        {
            char[] charArray = input.ToString().Trim().ToCharArray();
            int index;

            for(index=0; index<charArray.Length; index++)
            {
                if (IsLetter(charArray[index]))
                {
                    continue;
                }

                if (IsNumber(charArray[index]))
                {
                    continue;
                }

                switch (charArray[index])
                {
                    case '(':
                        Tokens.Add(new Token(TokenType.LEST_PARENTHESIS, charArray[index].ToString(), "null", 1));
                        ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case ')':
                        Tokens.Add(new Token(TokenType.RIGHT_PARENTHESIS, charArray[index].ToString(), "null", 1));
                        ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '{': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '}': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case ',': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '.': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case ';': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '-': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '+': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '*': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '/': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '!': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '=': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '<': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    case '>': ValidateCharacters(charArray, index, charArray[index]);
                        break;
                    default: break;
                }
            }

            foreach (var token in Tokens)
            {
                Console.WriteLine(token.toString());
            }

            input.Clear();
        }
    }
}
