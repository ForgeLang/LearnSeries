enum class TokenType {
    Fn, Return, Identifier, StringLiteral,
    LParen, RParen, LBrace, RBrace,
    Arrow, Semicolon, Comma,
    IntegerLiteral, Print, EndOfFile
};

struct Token {
    TokenType type;
    std::string lexeme;
    SourceSpan span;
};