add_library(ForgeCore ...)
add_library(ForgeLexer ...)
add_library(ForgeParser ...)
add_library(ForgeRuntime ...)

# Dependencies
target_link_libraries(ForgeLexer PUBLIC ForgeCore)
target_link_libraries(ForgeParser PUBLIC ForgeLexer ForgeCore)
target_link_libraries(ForgeRuntime PUBLIC ForgeParser ForgeCore)