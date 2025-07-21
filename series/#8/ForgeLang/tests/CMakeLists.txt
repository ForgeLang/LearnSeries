add_executable(ForgeTests
    LexerTests.cpp
    ParserTests.cpp
)

target_link_libraries(ForgeTests PRIVATE
    ForgeCore
    ForgeLexer
    ForgeParser
)

add_test(NAME LexerTests COMMAND ForgeTests)