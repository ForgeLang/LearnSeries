add_library(ForgeCore STATIC
    SourceManager.cpp
    ErrorReporter.cpp
    Utility.cpp
)

target_include_directories(ForgeCore PUBLIC ${CMAKE_SOURCE_DIR}/src)
target_compile_features(ForgeCore PUBLIC cxx_std_23)

# Optional sanitizers and warnings
target_link_options(ForgeCore PRIVATE ${SANITIZER_FLAGS})