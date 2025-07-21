cmake_minimum_required(VERSION 3.25)
project(ForgeLang VERSION 0.1 LANGUAGES CXX)

# Require C++23
set(CMAKE_CXX_STANDARD 23)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_EXPORT_COMPILE_COMMANDS ON)

# Use folders in IDEs like Visual Studio
set_property(GLOBAL PROPERTY USE_FOLDERS ON)

# Modules path
list(APPEND CMAKE_MODULE_PATH "${CMAKE_SOURCE_DIR}/cmake")

# Enable warnings and options
include(cmake/CompilerWarnings.cmake)
include(cmake/EnableSanitizers.cmake)

# Add source directories
add_subdirectory(src/core)
add_subdirectory(src/lexer)
add_subdirectory(src/parser)
add_subdirectory(src/semantics)
add_subdirectory(src/runtime)
add_subdirectory(src/main)

# Add tests
enable_testing()
add_subdirectory(tests)