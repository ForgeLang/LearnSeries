CHECK(tokenize("var x = 5;") == std::vector<Token>{
    {TokenType::Keyword, "var"}, {TokenType::Identifier, "x"},
    {TokenType::Operator, "="}, {TokenType::Number, "5"},
    {TokenType::Semicolon, ";"}
});