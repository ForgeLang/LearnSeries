template<typename T>
concept TokenStream = requires(T stream) {
    { stream.next_token() } -> std::same_as<Token>;
};