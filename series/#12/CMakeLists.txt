cmake_minimum_required(VERSION 3.26)
project(MyLangInterpreter LANGUAGES CXX)
set(CMAKE_CXX_STANDARD 23)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

add_executable(interpreter src/main.cpp src/lexer.cpp src/parser.cpp)
target_include_directories(interpreter PRIVATE include)