const fn factorial(n: int) -> int {
    if n <= 1 {
        return 1;
    }
    return n * factorial(n - 1);
}

fn main() {
    const fact_5: int = factorial(5); // Computed at compile time
    print(fact_5);                    // Output: 120
}