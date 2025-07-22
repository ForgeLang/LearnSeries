int main(int argc, char** argv) {
    if (argc < 2) {
        std::cerr << "Usage: forge <file.lang>" << std::endl;
        return 1;
    }

    std::string source = SourceManager::read_file(argv[1]);
    auto tokens = Lexer(source).tokenize();
    auto ast = Parser(tokens).parse_program();

    Runtime runtime;
    runtime.register_builtin("print", builtin_print);
    runtime.run(ast);

    return 0;
}