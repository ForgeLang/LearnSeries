struct CallExpr {
    std::string callee;
    std::vector<Expr> arguments;
};

struct PrintStmt {
    Expr value;
};

using Stmt = std::variant<PrintStmt, ReturnStmt, FunctionDecl>;