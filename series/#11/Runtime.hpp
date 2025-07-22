class Runtime {
public:
    void register_builtin(const std::string& name, NativeFunction fn);
    void run(const std::vector<Stmt>& program);
};

void builtin_print(const std::vector<Value>& args) {
    std::cout << args[0].as_string() << std::endl;
}