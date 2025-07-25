constexpr bool valid = validate_syntax_rules();
static_assert(valid, "Grammar validation failed at compile time");